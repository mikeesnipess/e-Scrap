using Microsoft.EntityFrameworkCore;

namespace e_Scrap.Test.Entities
{
    public class ShopEntityTest
    {
        private async Task<AppSettingsDbContext> GetDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<AppSettingsDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            var databaseContext = new AppSettingsDbContext(options);
            databaseContext.Database.EnsureCreated();
            if (await databaseContext.AltexRefrigerator.CountAsync() <= 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    databaseContext.AltexRefrigerator.Add(
                        new AltexRefrigerator()
                        {
                            Id = Guid.NewGuid(),
                            Name = "Premium Gas Cooker 3000",
                            ProductId = 123456,
                            StandardPrice = 1200.99m,
                            DiscountPrice = 999.99m,
                            DiscountPercentage = 16.67m,
                            ShopId = Guid.NewGuid(),
                            LinkUrl = "https://www.altex.ro/premium-gas-cooker-3000",
                            ProductDescription = "A high-quality gas cooker with advanced safety features and modern design.",
                            CountryId = "RO",
                            ProductType = "GasCooker",
                            ImageSmallUrl = "https://www.altex.ro/images/premium-gas-cooker-3000.jpg",
                            BrandName = "PremiumCook"
                        });
                    await databaseContext.SaveChangesAsync();
                }
            }
            return databaseContext;
        }
        //[Fact]
        //public async void GasCookerEntity_GetGasCooker_ReturnsName()
        //{
        //    var name = "Premium Gas Cooker 3000";
        //    var dbContext = await GetDatabaseContext();
        //    var gasCookerEntity = new AltexRefrigerator(dbContext);
        //}
    }
}
