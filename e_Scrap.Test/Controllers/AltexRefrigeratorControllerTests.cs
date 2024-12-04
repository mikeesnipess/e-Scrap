using Controllers.Altex;
using e.Services.Altex;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models.Common.Refrigerator;

namespace e_Scrap.Test.Controllers
{
    public class AltexRefrigeratorControllerTests
    {
        private readonly IAltexRefrigeratorService _service;
        private readonly IAppSettingsDbContext _context;

        public AltexRefrigeratorControllerTests()
        {
            _service = A.Fake<IAltexRefrigeratorService>();
            _context = A.Fake<IAppSettingsDbContext>();
        }

        [Fact]
        public void AltexRefrigeratorController_GetRefrigerators_ReturnOk()
        {
            AppSettingsDbContext databaseContext = UseDatabase();
            var refrigerators = A.Fake<List<RefrigeratorModel>>();
            A.CallTo(() => _service.GetAltexRefrigerator()).Returns(refrigerators);
            var contorller = new AltexRefrigeratorController(_service, databaseContext);

            var result = contorller.ScrapeRefrigeratorProducts();

            result.Should().NotBeNull();
            //result.Result.Should().BeOfType<NotFoundObjectResult>();
        }


        [Fact]
        public async Task AltexRefrigeratorController_GetRefrigerators_ReturnsDataFromDatabase()
        {
            // Arrange
            AppSettingsDbContext databaseContext = UseDatabase();

            // Seed data
            databaseContext.AltexRefrigerator.Add(new AltexRefrigerator
            {
                Id = Guid.NewGuid(),
                Name = "Test Refrigerator",
                StandardPrice = 1000,
                DiscountPrice = 800,
                DiscountPercentage = 20,
                ShopId = Guid.Parse("9B78E718-E0F5-42D9-9211-487C170C6E99"),
                LinkUrl = "https://example.com",
                ProductDescription = "Test Description",
                CountryId = "RO",
                ProductType = "Type1",
                ImageSmallUrl = "https://example.com/image.jpg",
                BrandName = "BrandX"
            });
            await databaseContext.SaveChangesAsync();

            var service = new AltexRefrigeratorService(databaseContext);
            var controller = new AltexRefrigeratorController(service, databaseContext);

            // Act
            var result = await controller.ScrapeRefrigeratorProducts();

            // Assert
            result.Should().NotBeNull();
            result.Result.Should().BeOfType<OkObjectResult>();
            var okResult = result.Result as OkObjectResult;
            var products = okResult.Value as List<RefrigeratorModel>;
            products.Should().HaveCount(1);
            products.First().Name.Should().Be("Test Refrigerator");
        }

        private static AppSettingsDbContext UseDatabase()
        {
            var options = new DbContextOptionsBuilder<AppSettingsDbContext>()
                            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                            .Options;
            var databaseContext = new AppSettingsDbContext(options);
            databaseContext.Database.EnsureCreated();
            return databaseContext;
        }
    }
}