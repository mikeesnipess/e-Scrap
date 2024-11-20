using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace e.Scrap.Entities.eMag
{
    public class eMagGasCooker
    {
        [Key]
        public Guid Id { get; set; }  // Unique identifier

        public int? ProductId { get; set; }  // Product ID (nullable)

        [Required]
        public string Name { get; set; }  // Name of the refrigerator

        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal StandardPrice { get; set; }  // Standard price

        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountPrice { get; set; }  // Discounted price (nullable)

        public decimal? DiscountPercentage { get; set; }  // Discount percentage (nullable)

        [ForeignKey("Shop")]
        [Required]
        public Guid ShopId { get; set; }  // Shop ID (foreign key from Shops table)

        [Required]
        public string LinkUrl { get; set; }  // URL link to product

        public string ProductDescription { get; set; }  // Product description (nullable)

        [ForeignKey("Country")]
        [Required]
        public string CountryId { get; set; }  // Country ID (foreign key from Countries table)

        public string ProductType { get; set; }  // Type of product (nullable)
        public string ImageSmallUrl { get; set; }
        public string BrandName { get; set; }
    }
}
