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
        public async Task DeletePublisherAsync_Should_Delete_Existing_Publisher()
        {
            // Arrange
            var publisherIdToDelete = Guid.Parse("ea3480ae-657b-4bcf-ac44-8e45081b58e6"); // Use a real existing publisher ID from your seed data

            // Act
            await publisherService.DeletePublisherAsync(publisherIdToDelete);

            // Assert
            var deletedPublisher = await dbContext.Publishers.FirstOrDefaultAsync(p => p.Id == publisherIdToDelete);
            Assert.IsNull(deletedPublisher, "Ensure that the publisher is deleted.");
        }
    }
}


