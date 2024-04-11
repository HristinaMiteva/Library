using Library.Data;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using Library.Contracts;
using Library.Services;
using static Testing.DataBaseSeeder;
using Moq;
using Library.Models.PublisherViewModels;

namespace Testing
{
    [TestFixture]
    public class PublisherServiceTests
    {
        private DbContextOptions<LibraryDbContext> dbOptions;
        private LibraryDbContext dbContext;
        private IPublisherServices publisherService;


        [SetUp]
        public void SetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<LibraryDbContext>()
                    .UseInMemoryDatabase("LibraryInMemoryDb" + Guid.NewGuid().ToString())
                    .Options;

            this.dbContext = new LibraryDbContext(this.dbOptions, false);
            this.dbContext.Database.EnsureCreated();
            SeedDatabase(this.dbContext);


            this.publisherService = new PublisherServices(dbContext);

        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task GetAllAsync_Returns_AllPublishers()
        {
            // Arrange

            // Act
            var result = await publisherService.GetAllAsync();

            // Assert
            Assert.AreEqual(3, result.Count());
        }

        [Test]
        public async Task GetAllAsync_Returns_CorrectPublisherNames()
        {
            // Arrange
            var expectedNames = new List<string> { "Holiday House", "Candlewick Press", "Arbordale Publishing" };

            // Act
            var result = await publisherService.GetAllAsync();

            // Assert
            CollectionAssert.AreEqual(expectedNames, result.Select(p => p.Name));
        }

        [Test]
        public async Task GetAllAsync_Returns_CorrectNumberOfPublishers()
        {
            // Arrange

            // Act
            var result = await publisherService.GetAllAsync();

            // Assert
            Assert.AreEqual(3, result.Count());
        }

        [Test]
        public async Task GetAllAsync_Returns_PublisherIds()
        {
            // Arrange
            var expectedIds = new List<Guid>
        {
            Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6"),
            Guid.Parse("b2b63af9-18b0-48f4-9078-30836e6f54f7"),
            Guid.Parse("36bda0c2-9ea8-4c67-a86f-f81486343f12")
        };

            // Act
            var result = await publisherService.GetAllAsync();

            // Assert
            CollectionAssert.AreEqual(expectedIds, result.Select(p => p.Id));
        }

        [Test]
        public async Task GetAllAsync_Returns_EmptyList_WhenNoPublishers()
        {
            // Arrange
            dbContext.Publishers.RemoveRange(dbContext.Publishers);
            await dbContext.SaveChangesAsync();

            // Act
            var result = await publisherService.GetAllAsync();

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public async Task GetAllAsync_Returns_WithNames_AllPublishers()
        {
            // Arrange
            var expectedPublishers = new List<PublishersViewModel>
            {
                new PublishersViewModel { Id = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6"), Name = "Holiday House" },
                new PublishersViewModel { Id = Guid.Parse("b2b63af9-18b0-48f4-9078-30836e6f54f7"), Name = "Candlewick Press" },
                new PublishersViewModel { Id = Guid.Parse("36bda0c2-9ea8-4c67-a86f-f81486343f12"), Name = "Arbordale Publishing" }
            };

            // Act
            var result = await publisherService.GetAllAsync();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedPublishers.Count, result.Count());
            foreach (var expectedPublisher in expectedPublishers)
            {
                Assert.IsTrue(result.Any(p => p.Id == expectedPublisher.Id && p.Name == expectedPublisher.Name));
            }
        }


        [Test]
        public async Task AddPublisherAsync_Should_Add_New_Publisher()
        {
            // Arrange
            var model = new AddPublisherViewModel { Name = "New Publisher" };

            // Act
            await publisherService.AddPublisherAsync(model);

            // Assert
            var addedPublisher = await dbContext.Publishers.FirstOrDefaultAsync(p => p.Name == "New Publisher");
            Assert.IsNotNull(addedPublisher);
        }
        [Test]
        public async Task DeletePublisherAsync_RemovesPublisherFromDatabase()
        {
            // Arrange
            var publisherId = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6");

            // Act
            await publisherService.DeletePublisherAsync(publisherId);

            // Assert
            var deletedPublisher = await dbContext.Publishers.FindAsync(publisherId);
            Assert.IsNull(deletedPublisher);
        }

        [Test]
        public void DeletePublisherAsync_ThrowsException_WhenIdNotFound()
        {
            // Arrange
            var nonExistentId = Guid.NewGuid();

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await publisherService.DeletePublisherAsync(nonExistentId));
        }

        [Test]
        public async Task DeletePublisherAsync_RemovesAssociatedBooks()
        {
            // Arrange
            var publisherId = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6");

            // Act
            await publisherService.DeletePublisherAsync(publisherId);

            // Assert
            var books = await dbContext.Books.Where(b => b.PublisherId == publisherId).ToListAsync();
            Assert.IsEmpty(books);
        }

        [Test]
        public async Task DeletePublisherAsync_ThrowsException_WhenIdIsEmptyGuid()
        {
            // Arrange
            var emptyGuid = Guid.Empty;

            // Act & Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await publisherService.DeletePublisherAsync(emptyGuid));
        }

        [Test]
        public async Task DeletePublisherAsync_DoesNotRemoveOtherPublishers()
        {
            // Arrange
            var publisherId = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6");
            var remainingPublisherId = Guid.Parse("b2b63af9-18b0-48f4-9078-30836e6f54f7");

            // Act
            await publisherService.DeletePublisherAsync(publisherId);

            // Assert
            var remainingPublisher = await dbContext.Publishers.FindAsync(remainingPublisherId);
            Assert.IsNotNull(remainingPublisher);
        }

        [Test]
        public async Task DeletePublisherAsync_ThrowsException_WhenIdIsInvalid()
        {
            // Arrange
            var invalidId = "InvalidId";

            // Act & Assert
            Assert.ThrowsAsync<FormatException>(async () => await publisherService.DeletePublisherAsync(Guid.Parse(invalidId)));
        }
    }
}


