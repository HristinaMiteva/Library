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
using Library.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Moq;

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
        public async Task GetAllAsync_ReturnsListOfBooks()
        {
            // Act
            var result = await bookService.GetAllAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }

        [Test]
        public async Task GetAllAsync_ReturnsBooksViewModel()
        {
            // Act
            var result = (await bookService.GetAllAsync()).FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Where the Wild Things Are", result.Title);
            Assert.AreEqual("Holiday House", result.PublisherName);
        }

        [Test]
        public async Task GetAllAsync_ReturnsEmptyList_WhenNoBooks()
        {
            // Arrange
            dbContext.Books.RemoveRange(dbContext.Books);
            await dbContext.SaveChangesAsync();

            // Act
            var result = await bookService.GetAllAsync();

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task GetAllAsync_ReturnsCorrectNumberOfBooks()
        {
            // Act
            var result = await bookService.GetAllAsync();

            // Assert
            Assert.AreEqual(3, result.Count());
        }

        [Test]
        public async Task GetAllAsync_ReturnsCorrectBookDetails()
        {
            // Act
            var result = (await bookService.GetAllAsync()).FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Where the Wild Things Are", result.Title);
            Assert.AreEqual("Maurice Sendak", result.Author);
            Assert.AreEqual(48, result.Pages);
            Assert.AreEqual("9780060254926", result.ISBN);
            Assert.AreEqual(8.99, result.Price);
            Assert.AreEqual(1963, result.PublishingYear);
            Assert.AreEqual("https://m.media-amazon.com/images/I/91tBaQgfHeL._AC_UF1000,1000_QL80_.jpg", result.Image);
            Assert.AreEqual("Holiday House", result.PublisherName);
        }

        [Test]
        public void AddBookAsync_Should_Return_Publisher_SelectList()
        {
            // Act
            var result = bookService.AddBookAsync() as SelectList;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count()); // Assuming there are 3 publishers in the seed data
        }

        [Test]
        public async Task AddBookAsync_Should_Add_Book_To_Database()
        {
            // Arrange
            var model = new AddBookViewModel
            {
                Title = "Test Book",
                Author = "Test Author",
                Pages = 100,
                ISBN = "9781234567890",
                Price = 9.99,
                Image = "https://example.com/image.jpg",
                PublishingYear = 2022,
                PublisherId = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6") // Existing publisher ID from seed data
            };

            // Act
            await bookService.AddBookAsync(model);

            // Assert
            var addedBook = await dbContext.Books.FirstOrDefaultAsync(b => b.Title == model.Title);
            Assert.IsNotNull(addedBook);
            Assert.AreEqual(model.Title, addedBook.Title);
            // Add more assertions for other properties if needed
        }


        [Test]
        public async Task ReadBookAsync_AddsBookToUserBooks()
        {
            // Arrange
            var user = dbContext.Users.First();
            var book = dbContext.Books.First();

            // Act
            await bookService.ReadBookAsync(book.Id, user);

            // Assert
            Assert.AreEqual(1, dbContext.UserBooks.Count());
            var addedUserBook = dbContext.UserBooks.First();
            Assert.AreEqual(user.Id, addedUserBook.UserId);
            Assert.AreEqual(book.Id, addedUserBook.BookId);
        }

        [Test]
        public async Task ReadBookAsync_BookNotFound_DoesNotAddToUserBooks()
        {
            // Arrange
            var user = dbContext.Users.First();
            var nonExistingBookId = Guid.NewGuid();

            // Act
            await bookService.ReadBookAsync(nonExistingBookId, user);

            // Assert
            Assert.IsEmpty(dbContext.UserBooks);
        }

        [Test]
        public async Task BookReadAsync_ReturnsBooksForUser()
        {
            // Arrange
            var user = dbContext.Users.First();

            // Act
            var result = await bookService.BookReadAsync(user);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(user.UserBooks.Count, result.Count());
        }

        [Test]
        public async Task BookReadAsync_UserWithNoBooks_ThrowsException()
        {
            // Arrange
            var user = new User { Id = Guid.NewGuid().ToString(), FirstName = "John", LastName = "Doe", Age = 20 }; // Create a user without any books

            // Act & Assert
            Assert.ThrowsAsync<NullReferenceException>(() => bookService.BookReadAsync(user));
        }
        [Test]
        public async Task FavoriteBookAsync_AddsBookToUserFavorites()
        {
            // Arrange
            var user = dbContext.Users.First();
            var book = dbContext.Books.First();

            // Act
            await bookService.FavoriteBookAsync(book.Id, user);

            // Assert
            Assert.AreEqual(1, dbContext.Favorites.Count());
            var addedFavorite = dbContext.Favorites.First();
            Assert.AreEqual(user.Id, addedFavorite.UserId);
            Assert.AreEqual(book.Id, addedFavorite.BookId);
        }

        [Test]
        public async Task FavoriteBookAsync_BookNotFound_DoesNotAddToUserFavorites()
        {
            // Arrange
            var user = dbContext.Users.First();
            var nonExistingBookId = Guid.NewGuid();

            // Act
            await bookService.FavoriteBookAsync(nonExistingBookId, user);

            // Assert
            Assert.IsEmpty(dbContext.Favorites);
        }

        [Test]
        public async Task BookFavoriteAsync_ReturnsFavoriteBooksForUser()
        {
            // Arrange
            var user = dbContext.Users.First();

            // Act
            var result = await bookService.BookFavoriteAsync(user);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(user.Favorites.Count, result.Count());
        }

        [Test]
        public async Task BookFavoriteAsync_UserWithNoFavoriteBooks_ThrowsException()
        {
            // Arrange
            var user = new User { Id = Guid.NewGuid().ToString(), FirstName = "John", LastName = "Doe", Age = 20 }; // Create a user without any favorite books

            // Act & Assert
            Assert.ThrowsAsync<NullReferenceException>(() => bookService.BookFavoriteAsync(user));
        }

        [Test]
        public async Task GetAllQuizesAsync_ReturnsListOfBooks()
        {
            // Act
            var result = await bookService.GetAllQuizesAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count());
        }

        [Test]
        public async Task GetAllQuizesAsync_ReturnsBooksViewModel()
        {
            // Act
            var result = (await bookService.GetAllQuizesAsync()).FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Where the Wild Things Are", result.Title);
            Assert.AreEqual("Holiday House", result.PublisherName);
        }

        [Test]
        public async Task GetAllQuizesAsync_ReturnsEmptyList_WhenNoBooks()
        {
            // Arrange
            dbContext.Books.RemoveRange(dbContext.Books);
            await dbContext.SaveChangesAsync();

            // Act
            var result = await bookService.GetAllQuizesAsync();

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task GetAllQuizesAsync_ReturnsCorrectNumberOfBooks()
        {
            // Act
            var result = await bookService.GetAllQuizesAsync();

            // Assert
            Assert.AreEqual(3, result.Count());
        }

        [Test]
        public async Task GetAllQuizesAsync_ReturnsCorrectBookDetails()
        {
            // Act
            var result = (await bookService.GetAllQuizesAsync()).FirstOrDefault();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Where the Wild Things Are", result.Title);
            Assert.AreEqual("Maurice Sendak", result.Author);
            Assert.AreEqual(48, result.Pages);
            Assert.AreEqual("9780060254926", result.ISBN);
            Assert.AreEqual(1963, result.PublishingYear);
            Assert.AreEqual("https://m.media-amazon.com/images/I/91tBaQgfHeL._AC_UF1000,1000_QL80_.jpg", result.Image);
            Assert.AreEqual("Holiday House", result.PublisherName);
        }

       
        [Test]
        public async Task GetAllQuizesAsync_ReturnsCorrectNumberOfPages()
        {
            // Act
            var result = await bookService.GetAllQuizesAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(106, result.Sum(b => b.Pages));
        }
        [Test]
    public async Task FindBooksByAuthorAsync_Should_Return_CorrectBooks_For_ValidAuthor()
    {
        // Arrange
        string authorToSearch = "Maurice Sendak"; // Author of one of the seeded books

        // Act
        var result = await bookService.FindBooksByAuthorAsync(authorToSearch);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsInstanceOf<IEnumerable<BooksViewModel>>(result);

        // Assuming only one book is seeded with the specified author
        Assert.AreEqual(1, result.Count());

        var book = result.FirstOrDefault();
        Assert.IsNotNull(book);

        Assert.AreEqual("Where the Wild Things Are", book.Title);
        Assert.AreEqual("Maurice Sendak", book.Author);
        Assert.AreEqual(48, book.Pages);
        Assert.AreEqual("9780060254926", book.ISBN);
        Assert.AreEqual(8.99m, book.Price);
        Assert.AreEqual("https://m.media-amazon.com/images/I/91tBaQgfHeL._AC_UF1000,1000_QL80_.jpg", book.Image);
        Assert.AreEqual(1963, book.PublishingYear);
        Assert.AreEqual("Holiday House", book.PublisherName);
    }

    [Test]
        public void FindBooksByAuthorAsync_Should_Throw_ArgumentNullException_For_NullAuthor()
        {
            // Arrange - No need for additional setup

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await bookService.FindBooksByAuthorAsync(null));
        }

        [Test]
        public void FindBooksByAuthorAsync_Should_Throw_ArgumentNullException_For_EmptyAuthor()
        {
            // Arrange - No need for additional setup

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await bookService.FindBooksByAuthorAsync(""));
        }
        [Test]
        public async Task FindBooksByPublishingHouseAsync_WithValidPublishingHouse_ReturnsMatchingBooks()
        {
            // Arrange
            var publishingHouse = "Holiday"; // Part of the publishing house name
            var expectedCount = 3; // All books belong to the "Holiday House" publishing house

            // Act
            var result = await bookService.FindBooksByPublishingHouseAsync(publishingHouse);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(expectedCount, result.Count());
        }

        [Test]
        public void FindBooksByPublishingHouseAsync_WithNullPublishingHouse_ThrowsArgumentNullException()
        {
            // Arrange
            string publishingHouse = null;

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(() => bookService.FindBooksByPublishingHouseAsync(publishingHouse));
        }

        [Test]
        public async Task FindBooksByPublishingHouseAsync_WithNonExistingPublishingHouse_ReturnsEmptyList()
        {
            // Arrange
            var publishingHouse = "NonExistentPublishingHouse"; // A publishing house that does not exist

            // Act
            var result = await bookService.FindBooksByPublishingHouseAsync(publishingHouse);

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task FindBooksByPublishingHouseAsync_WithMixedCasePublishingHouse_ReturnsMatchingBooks()
        {
            // Arrange
            var publishingHouse = "Holiday House"; // Part of the publishing house name, mixed case
            var expectedCount = 3; // All books belong to the "Candlewick Press" publishing house

            // Act
            var result = await bookService.FindBooksByPublishingHouseAsync(publishingHouse);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(expectedCount, result.Count());
        }
        [Test]
        public async Task FindBooksByPriceRangeAsync_Should_Return_Books_In_Range()
        {
            // Arrange
            int minPrice = 5; // Minimum price to search for
            int maxPrice = 10; // Maximum price to search for

            // Act
            var result = await bookService.FindBooksByPriceRangeAsync(minPrice, maxPrice);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IEnumerable<BooksViewModel>>(result);

            // Assuming there are books within the specified price range in the seed data
            Assert.IsTrue(result.Any());

            // Assert that all returned books are within the specified price range
            foreach (var book in result)
            {
                Assert.IsTrue(book.Price >= minPrice && book.Price <= maxPrice);
            }
        }

        [Test]
        public async Task FindBooksByPriceRangeAsync_Should_Return_Empty_When_No_Books_In_Range()
        {
            // Arrange
            int minPrice = 50; // Minimum price to search for
            int maxPrice = 100; // Maximum price to search for

            // Act
            var result = await bookService.FindBooksByPriceRangeAsync(minPrice, maxPrice);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<IEnumerable<BooksViewModel>>(result);
            Assert.IsFalse(result.Any());
        }
    }
}




