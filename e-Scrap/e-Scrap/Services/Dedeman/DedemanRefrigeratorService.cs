﻿using Microsoft.EntityFrameworkCore;
using Models.Common.Refrigerator;

namespace e.Services.Altex
{
    public class DedemanRefrigeratorService
    {
        private readonly AppSettingsDbContext _context;

        public DedemanRefrigeratorService(AppSettingsDbContext context)
        {
            _context = context;
        }

        public async Task<List<RefrigeratorModel>> GetAltexRefrigerator()
        {
            var resultProducts = await _context.DedemanRefrigerator
                .Select(r => new RefrigeratorModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    StandardPrice = r.StandardPrice,
                    DiscountPrice = r.DiscountPrice,
                    DiscountPercentage = r.DiscountPercentage,
                    ShopId = r.ShopId,
                    LinkUrl = r.LinkUrl,
                    ProductDescription = r.ProductDescription,
                    CountryId = r.CountryId,
                    ProductType = r.ProductType,
                    ImageSmallUrl = r.ImageSmallUrl,
                    BrandName = r.BrandName,

                })
                .ToListAsync();

            return resultProducts;
        }
    }
}