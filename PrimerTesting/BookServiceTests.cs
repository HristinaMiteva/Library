using Library.Contracts;
using Library.Data;
using Library.Services;
using Microsoft.EntityFrameworkCore;
using static Testing.DataBaseSeeder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models.BookViewModels;
using Library.Data.Models;

namespace Testing
{
    [TestFixture]
    public class BookServiceTests
    {
        private DbContextOptions<LibraryDbContext> dbOptions;
        private LibraryDbContext dbContext;
        private IBookServices bookService;


        [SetUp]
        public void SetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<LibraryDbContext>()
                    .UseInMemoryDatabase("LibraryInMemoryDb" + Guid.NewGuid().ToString())
                    .Options;

            this.dbContext = new LibraryDbContext(this.dbOptions, false);
            this.dbContext.Database.EnsureCreated();
            SeedDatabase(this.dbContext);


            this.bookService = new BookServices(dbContext);

        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task GetAllAsync_Should_Return_AllBooks_With_Publisher()
        {
            // Arrange
            var expectedBooks = new List<BooksViewModel>
    {
        new BooksViewModel { Id = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6"), Title = "Where the Wild Things Are", Author = "Maurice Sendak", Pages = 48, ISBN = "9780060254926", Price = 8.99, Image = "https://m.media-amazon.com/images/I/91tBaQgfHeL._AC_UF1000,1000_QL80_.jpg", PublishingYear = 1963, PublisherName = "Holiday House" },
        new BooksViewModel { Id = Guid.Parse("b2b63af9-18b0-48f4-9078-30836e6f54f7"), Title = "The Very Hungry Caterpillar", Author = "Eric Carle", Pages = 26, ISBN = "9780399226908", Price = 6.99, Image = "https://m.media-amazon.com/images/I/81qsstEtrgL._AC_UF1000,1000_QL80_.jpg", PublishingYear = 1969, PublisherName = "Candlewick Press" },
        new BooksViewModel { Id = Guid.Parse("36bda0c2-9ea8-4c67-a86f-f81486343f12"), Title = "Goodnight Moon", Author = "Margaret Wise Brown", Pages = 32, ISBN = "9780060775858", Price = 6.29, Image = "https://m.media-amazon.com/images/I/91WuHblNkEL._AC_UF1000,1000_QL80_.jpg", PublishingYear = 1947, PublisherName = "Arbordale Publishing" }
    };

            // Act
            var result = await bookService.GetAllAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedBooks.Count, result.Count());

            foreach (var expectedBook in expectedBooks)
            {
                Assert.IsTrue(result.Any(b => b.Id == expectedBook.Id && b.Title == expectedBook.Title && b.Author == expectedBook.Author
                    && b.Pages == expectedBook.Pages && b.ISBN == expectedBook.ISBN && b.Price == expectedBook.Price
                    && b.Image == expectedBook.Image && b.PublishingYear == expectedBook.PublishingYear && b.PublisherName == expectedBook.PublisherName));
            }
        }
        [Test]
        public async Task ReadBookAsync_Should_Add_Book_To_User_Books()
        {
            // Arrange
            var bookId = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6"); // Existing book ID from seed data
            var userId = Guid.NewGuid();
            var user = new User { Id = userId };

            // Act
            await bookService.ReadBookAsync(bookId, user);

            // Assert
            var userBooks = await dbContext.UserBooks.Where(ub => ub.UserId == userId).ToListAsync();
            Assert.IsTrue(userBooks.Any(ub => ub.BookId == bookId));
        }

        [Test]
        public async Task BookReadAsync_Should_Return_Books_Read_By_User()
        {
            // Arrange
            var userId = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6"); // Existing user ID from seed data
            var user = new User { Id = userId };

            // Act
            var result = await bookService.BookReadAsync(user);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count()); // Assuming there are 3 books in the seed data
            // Add more specific assertions based on the seed data if needed
        }

    }
}

