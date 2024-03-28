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
            if (!ModelState.IsValid) {
                ViewBag.PublisherId = this.bookServices.AddBookAsync();
                return View(viewModel); }
            await this.bookServices.AddBookAsync(viewModel);
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        [Authorize(Roles = "Writer, Administrator, Reader")]
        public async Task<IActionResult> ReadBook(Guid id)
        {
            var user = await userManager.FindByNameAsync(User.Identity?.Name);
            await this.bookServices.ReadBookAsync(id, user);

            return RedirectToAction("Index", "Home");

        }
        [HttpGet]
        [Authorize(Roles = "Writer, Reader, Administrator")]
        public async Task<IActionResult> BookRead()
        {
            var user = await userManager.GetUserAsync(User);
            try
            {
                return View(await bookServices.BookReadAsync(user));

            }
            catch (Exception ex) { ModelState.AddModelError("", ex.Message); }


            return RedirectToAction("Index", "Home");


        }
        [HttpPost]
        [Authorize(Roles = "Writer, Reader")]
        public async Task<IActionResult> FavoriteBook(Guid id)
        {
            var user = await userManager.FindByNameAsync(User.Identity?.Name);
            await this.bookServices.FavoriteBookAsync(id, user);

            return RedirectToAction("Index", "Home");

        }
        [HttpGet]
        [Authorize(Roles = "Writer, Reader")]
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
            await bookServices.DeleteBookAsync(id);
            return RedirectToAction("Index", "Home");
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
    }
}
