using Library.Contracts;
using Library.Data;
using Library.Data.Models;
using Library.Models.BookViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public class BookServices : IBookServices
    {
        private readonly LibraryDbContext context;

        public BookServices(LibraryDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<BooksViewModel>> GetAllAsync()
        {
            var entities = await context.Books.Include(book => book.Publisher).ToListAsync();
            return entities
                .Select(b => new BooksViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Pages = b.Pages,
                    ISBN = b.ISBN,
                    Price = b.Price,
                    Image = b.Image,
                    PublishingYear = b.PublishingYear,
                    PublisherName = b?.Publisher.Name
                });
        }
        public SelectList AddBookAsync()
        {
            return new SelectList(this.context.Publishers, "Id", "Name");
        }


        public async Task AddBookAsync(AddBookViewModel model)
        {
            Book book = new Book()
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                Author = model.Author,
                Pages = model.Pages,
                ISBN = model.ISBN,
                Price = model.Price,
                Image = model.Image,
                PublishingYear = model.PublishingYear,
                PublisherId = model.PublisherId
            };
            await this.context.Books.AddAsync(book);
            await context.SaveChangesAsync();

        }

        public async Task ReadBookAsync(Guid id, User user)
        {
            Book book = await this.context.Books.FindAsync(id);

            if (book != null && user != null)
            {
                UserBook book1 = new UserBook()
                {
                    Book = book,
                    User = user
                };
                await this.context.UserBooks.AddAsync(book1);
                await this.context.SaveChangesAsync();
            }

        }

        public async Task<IEnumerable<BooksViewModel>> BookReadAsync(User user)
        {
            User? userWithBooks = await context.Users
                .Where(u => u.Id == user.Id)
                .Include(u => u.UserBooks)
                .ThenInclude(b => b.Book)
                .ThenInclude(b => b.Publisher)
                .FirstOrDefaultAsync();
            if (userWithBooks.UserBooks != null)
            {
                var books = userWithBooks.UserBooks
                    .Select(b => new BooksViewModel()
                    {
                        Title = b.Book.Title,
                        Author = b.Book.Author,
                        Pages = b.Book.Pages,
                        ISBN = b.Book.ISBN,
                        Image = b.Book.Image,
                        PublishingYear = b.Book.PublishingYear,
                        PublisherName = b.Book?.Publisher?.Name
                    });
                return books;
            }

            throw new NullReferenceException();
        }

        public async Task FavoriteBookAsync(Guid id, User user)
        {
            Book book = await this.context.Books.FindAsync(id);

            if (book != null && user != null)
            {
                Favorite book1 = new Favorite()
                {
                    Book = book,
                    User = user
                };
                await this.context.Favorites.AddAsync(book1);
                await this.context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<BooksViewModel>> BookFavoriteAsync(User user)
        {
            User? userWithBooks = await context.Users
                 .Where(u => u.Id == user.Id)
                 .Include(u => u.Favorites)
                 .ThenInclude(b => b.Book)
                 .ThenInclude(b => b.Publisher)
                 .FirstOrDefaultAsync();
            if (userWithBooks.Favorites != null)
            {
                var books = userWithBooks.Favorites
                    .Select(b => new BooksViewModel()
                    {
                        Id = b.BookId,
                        Title = b.Book.Title,
                        Author = b.Book.Author,
                        Pages = b.Book.Pages,
                        ISBN = b.Book.ISBN,
                        Price = b.Book.Price,
                        Image = b.Book.Image,
                        PublishingYear = b.Book.PublishingYear,
                        PublisherName = b.Book?.Publisher?.Name
                    });
                return books;
            }

            throw new NullReferenceException();
        }
        public async Task DeleteBookAsync(Guid id)
        {
            var model = await this.context.Books
                .FirstOrDefaultAsync(x => x.Id == id);

            if (model != null)
            {
                context.Books.Remove(model);
                await context.SaveChangesAsync();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public async Task RemoveFromFavoiretesAsync(Guid bookId, User user)
        {
            var favourite = await this.context.Favorites.Include(favorite => favorite.Book)
                                                            .Include(favourite => favourite.User)
                                                            .Where(favourite => favourite.BookId == bookId && favourite.User == user)
                                                            .FirstOrDefaultAsync();

            if (favourite != null)
            {
                this.context.Favorites.Remove(favourite);
                await this.context.SaveChangesAsync();
            }

            else throw new ArgumentNullException();
        }

        public async Task<IEnumerable<BooksViewModel>> SearchedBooksAsync(string bookName)
        {
            if (String.IsNullOrEmpty(bookName))
            {
                throw new ArgumentNullException();
            }
            else
            {
                var searchedItems = await this.context.Books.Include(book => book.Publisher)
                                                            .Where(book => book.Title.ToLower().Contains(bookName.ToLower()))
                                                            .ToListAsync();

                return searchedItems.Select(b => new BooksViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Pages = b.Pages,
                    ISBN = b.ISBN,
                    Image = b.Image,
                    PublishingYear = b.PublishingYear,
                    PublisherName = b?.Publisher.Name
                });
            }
        }

        public async Task<IEnumerable<BooksViewModel>> GetAllQuizesAsync()
        {
            var entities = await context.Books.Include(book => book.Publisher).ToListAsync();
            return entities
                .Select(b => new BooksViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Pages = b.Pages,
                    ISBN = b.ISBN,
                    Image = b.Image,
                    PublishingYear = b.PublishingYear,
                    PublisherName = b?.Publisher.Name
                });
        }

        public async Task<IEnumerable<BooksViewModel>> FindBooksByAuthorAsync(string author)
        {
            if (String.IsNullOrEmpty(author))
            {
                throw new ArgumentNullException(nameof(author), "Author cannot be null or empty.");
            }
            else
            {
                var searchedItems = await this.context.Books
                    .Include(book => book.Publisher)
                    .Where(book => book.Author.ToLower().Contains(author.ToLower()))
                    .ToListAsync();

                return searchedItems.Select(b => new BooksViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Pages = b.Pages,
                    ISBN = b.ISBN,
                    Image = b.Image,
                    Price = b.Price,
                    PublishingYear = b.PublishingYear,
                    PublisherName = b.Publisher?.Name
                }).ToList();
            }
        }

        public async Task<IEnumerable<BooksViewModel>> FindBooksByPublishingHouseAsync(string publishingHouse)
        {
            if (String.IsNullOrEmpty(publishingHouse))
            {
                throw new ArgumentNullException(nameof(publishingHouse), "Publishing house cannot be null or empty.");
            }
            else
            {
                var searchedItems = await this.context.Books
                    .Include(book => book.Publisher)
                    .Where(book => book.Publisher.Name.ToLower().Contains(publishingHouse.ToLower()))
                    .ToListAsync();

                return searchedItems.Select(b => new BooksViewModel
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Pages = b.Pages,
                    ISBN = b.ISBN,
                    Image = b.Image,
                    Price = b.Price,
                    PublishingYear = b.PublishingYear,
                    PublisherName = b.Publisher?.Name
                }).ToList();
            }
        }

        public async Task<IEnumerable<BooksViewModel>> FindBooksByPriceRangeAsync(int minPrice, int maxPrice)
        {
          

            var searchedItems = await this.context.Books
                .Include(book => book.Publisher)
                .Where(book => book.Price >= minPrice && book.Price <= maxPrice)
                .ToListAsync();

            return searchedItems.Select(b => new BooksViewModel
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author,
                Pages = b.Pages,
                ISBN = b.ISBN,
                Image = b.Image,
                Price = b.Price,
                PublishingYear = b.PublishingYear,
                PublisherName = b.Publisher?.Name
            });
        }


    }
}
