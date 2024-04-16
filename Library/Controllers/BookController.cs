using Library.Contracts;
using Library.Data.Models;
using Library.Models.BookViewModels;
using Library.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.VisualStudio;
using System.Runtime.InteropServices;

namespace Library.Controllers
{
    [Authorize]
    public class BookController : Controller
    {
        private readonly UserManager<User> userManager;

        private readonly IBookServices bookServices;

        public BookController(IBookServices bookServices, UserManager<User> userManager)
        {
            this.bookServices = bookServices;
            this.userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (!User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View(await this.bookServices.GetAllAsync());
            }
        }
        [HttpPost]
        public async Task<IActionResult> Index(string bookname)
        {
            try
            {
                return View(await this.bookServices.SearchedBooksAsync(bookname));
            }
            catch (ArgumentNullException) { return View(await this.bookServices.GetAllAsync()); }
        }



        [HttpGet]
        [Authorize(Roles = "Writer, Redactor, Administrator")]
        public IActionResult Add()
        {
            ViewBag.PublisherId = this.bookServices.AddBookAsync();
            return View();
        }


        [HttpPost]
        [Authorize(Roles = "Writer, Redactor, Administrator")]
        public async Task<IActionResult> Add(AddBookViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.PublisherId = this.bookServices.AddBookAsync();
                return View(viewModel);
            }
            await this.bookServices.AddBookAsync(viewModel);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [Authorize(Roles = "Writer, Reader, Redactor")]
        public async Task<IActionResult> ReadBook(Guid id)
        {
            var user = await userManager.FindByNameAsync(User.Identity?.Name);

            try
            {
                await this.bookServices.ReadBookAsync(id, user);
            }
            catch (Exception)
            {
                TempData["message"] = "Book is already marked as read!";
            }

            return RedirectToAction("Index");
        }
        [HttpGet]
        [Authorize(Roles = "Writer, Reader, Redactor")]
        public async Task<IActionResult> BookRead()
        {
            var user = await userManager.GetUserAsync(User);
            try
            {
                return View(await bookServices.BookReadAsync(user));

            }
            catch (Exception ex) { ModelState.AddModelError("", ex.Message); }


            return RedirectToAction("Index");


        }
        [HttpPost]
        [Authorize(Roles = "Writer, Reader, Redactor")]
        public async Task<IActionResult> FavoriteBook(Guid id)
        {
            var user = await userManager.FindByNameAsync(User.Identity?.Name);

            try
            {
                await this.bookServices.FavoriteBookAsync(id, user);
            }
            catch (Exception)
            {
                TempData["message"] = "Book is already marked as favourite!";
            }

            return RedirectToAction("Index");

        }
        [HttpGet]
        [Authorize(Roles = "Writer, Reader, Redactor")]
        public async Task<IActionResult> BookFavorite()
        {
            var user = await userManager.GetUserAsync(User);
            try
            {
                return View(await bookServices.BookFavoriteAsync(user));

            }
            catch (Exception ex) { ModelState.AddModelError("", ex.Message); }


            return RedirectToAction("Index", "Home");


        }
        [Authorize(Roles = "Administrator, Redactor, Writer")]
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await bookServices.DeleteBookAsync(id);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                return BadRequest("An error occurred while deleting the book.");
            }
        }


        [HttpGet]
        [Authorize(Roles = "Writer, Reader")]
        public async Task<IActionResult> RemoveFromFavorites(Guid bookId)
        {
            User user = await userManager.GetUserAsync(User);

            try
            {
                await this.bookServices.RemoveFromFavoiretesAsync(bookId, user);
            }
            catch (ArgumentNullException ex)
            {
                ModelState.AddModelError("", ex.Message);
            }

            return RedirectToAction("BookFavorite");
        }
        [HttpGet]
        public async Task<IActionResult> AllQuizes()
        {
            if (!User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View(await this.bookServices.GetAllQuizesAsync());
            }
        }
       
        
        [HttpGet]
        public IActionResult FindByAuthor()
        {
            if (!User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> FindByAuthor(string author)
        {
            try
            {
                var books = await this.bookServices.FindBooksByAuthorAsync(author);
                if (books.Any())
                {
                    return View(books);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "No books found for the given author.");
                    return View();
                }
            }
            catch (ArgumentNullException)
            {
                ModelState.AddModelError(string.Empty, "Author cannot be empty.");
                return View();
            }
        }
        [HttpGet]
        public IActionResult FindByPublishingHouse()
        {
            if (!User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> FindByPublishingHouse(string publishingHouse)
        {
            try
            {
                var books = await this.bookServices.FindBooksByPublishingHouseAsync(publishingHouse);
                if (books.Any())
                {
                    ViewBag.PublishingHouse = publishingHouse;
                    return View(books);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "No books found for the given house.");
                    return View();
                }
            }
            catch (ArgumentNullException)
            {
                ModelState.AddModelError(string.Empty, "House cannot be empty.");
                return View();
            }
        }

        [HttpGet]
        public IActionResult FindByPriceRange()
        {
            if (!User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Login", "Account");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> FindByPriceRange(int minPrice, int maxPrice)
        {
            try
            {
                var books = await this.bookServices.FindBooksByPriceRangeAsync(minPrice, maxPrice);
                if (books.Any())
                {
                    return View(books);
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "No books found in the given price range.");
                    return View();
                }
            }
            catch (ArgumentNullException)
            {
                ModelState.AddModelError(string.Empty, "Price range cannot be empty.");
                return View();
            }
        }
        [HttpGet]
        [Authorize(Roles = "Administrator, Redactor, Writer")]
        public async Task<IActionResult> Edit(Guid id)
        {
            var book = await bookServices.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            var viewModel = new EditBookViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Pages = book.Pages,
                ISBN = book.ISBN,
                Price = book.Price,
                Image = book.Image,
                PublishingYear = book.PublishingYear,
                PublisherId = book.PublisherId
            };

            return View(viewModel);
        }

        [HttpPost]
        [Authorize(Roles = "Administrator, Redactor, Writer")]
        public async Task<IActionResult> Edit(Guid id, EditBookViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await bookServices.UpdateBookAsync(id, viewModel);
                    return RedirectToAction(nameof(Index));
                }
                catch (ArgumentNullException ex)
                {
                    ModelState.AddModelError("", ex.Message);
                    return View(viewModel);
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "An error occurred while updating the book.");
                }
            }

            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Quiz()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Quiz2()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Quiz3()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Quiz4()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Quiz5()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Quiz6()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Quiz7()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Quiz8()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Quiz9()
        {
            return View();
        }
        
        [HttpGet]
        public async Task<IActionResult> Find()
        {
            return View();
        }
    }
}
