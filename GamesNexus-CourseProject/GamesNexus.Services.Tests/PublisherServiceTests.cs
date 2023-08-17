namespace GamesNexus.Services.Tests
{
    using GamesNexus.Data;
    using GamesNexus.Data.Common;
    using GamesNexus.Services.Data;
    using GamesNexus.Services.Data.Interfaces;
    using Microsoft.EntityFrameworkCore;

    using static DatabaseSeeder;

    public class PublisherServiceTest
    {
        private  DbContextOptions<GamesNexusDbContext> dbOptions;
        private  GamesNexusDbContext dbContext;

        private IPublisherService publisherService;
        private IRepository  repository;

        


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<GamesNexusDbContext>().UseInMemoryDatabase("GamesNexusInMemory" + Guid.NewGuid().ToString()).Options;
            this.dbContext = new GamesNexusDbContext(this.dbOptions);

            dbContext.Database.EnsureCreated();

            SeedDatabase(this.dbContext); // Call the SeedDatabase method to populate sample data

            this.repository = new Repository(this.dbContext);
            this.publisherService = new PublisherServices(this.repository);
        }

        [TearDown]
        public void TearDown()
        {
            dbContext.Database.EnsureDeleted();
        }

        [Test]
        public async Task PublisherExistsByBusinessEmailAsync_ShouldReturnFalseIfEmailDoesNotExist()
        {
            // Arrange
            var email = "nonexistent@example.com";

            // Act
            var result = await this.publisherService.PublisherExistsByBusinessEmailAsync(email);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task PublisherExistsByBusinessEmailAsync_ShouldReturnTrueIfEmailExist()
        {
            // Arrange
            var email = Publisher.BusinessEmail;

            // Act
            var result = await this.publisherService.PublisherExistsByBusinessEmailAsync(email);

            // Assert
            Assert.That(result);
        }

        [Test]
        public async Task AgentExistsByUserIdAsyncShouldReturnTrueWhenExists()
        {
            string existingAgentUserId = PublisherUser.Id.ToString();

            bool result = await this.publisherService.PublisherExistsByUserId(existingAgentUserId);

            Assert.IsTrue(result);
        }


        [Test]
        public async Task PublisherExistsByBusinessEmailAsync_ShouldReturnFalssIfIdDoesntExists()
        {
            // Arrange
            var id = "df7ed73b-08d6-4eff-8aa5-ca218759d360";

            // Act
            var result = await this.publisherService.PublisherExistsByUserId(id);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task PublisherExistsByCompanyNameAsync_ShouldReturnTrueCompanyNameExists()
        {
            // Arrange
            var companyName = Publisher.CompanyName;

            // Act
            var result = await this.publisherService.PublisherExistsByCompanyNameAsync(companyName);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public async Task PublisherExistsByCompanyNameAsync_ShouldReturnFalseIfCompanyNameDoesnNotExists()
        {
            // Arrange
            var companyName = "ABV";

            // Act
            var result = await this.publisherService.PublisherExistsByCompanyNameAsync(companyName);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public async Task GetPublisherIdByUserIdAsync_ShouldReturnCorrectCorrectPublisherId()
        {
            // Arrange
            var userId = PublisherUser.Id.ToString();

            // Act
            var result = await this.publisherService.GetPublisherIdByUserIdAsync(userId);

            // Assert
            Assert.That(Publisher.Id.ToString().ToUpper(), Is.EqualTo("DAE07E76-9F5D-4BFB-800B-C0DFB0EFEC5B"));
        }
    }
}