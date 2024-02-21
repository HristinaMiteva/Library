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
        private readonly ApplicationDbContext context;

        public BookServices(ApplicationDbContext context)
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
                Pages= model.Pages,
                ISBN = model.ISBN,
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
                        Pages=b.Book.Pages,
                        ISBN = b.Book.ISBN,
                        Image = b.Book.Image,
                        PublishingYear = b.Book.PublishingYear,
                        PublisherName = b.Book?.Publisher?.Name
                    });
                return books;
            }

            throw new NullReferenceException();
        }
     
    }
}
