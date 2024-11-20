using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Models.Altex
{
    public class AltexProductsModel
    {
        [Key]
        public Guid Id { get; set; }  // Guid

        [Required]
        public string Name { get; set; }  // string

        [Column(TypeName = "decimal(18,2)")]
        public decimal StandardPrice { get; set; }  // decimal

        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountPrice { get; set; }  // decimal

        [Required]
        public decimal DiscountPercentage { get; set; } // decimal 

        [ForeignKey("Shop")]
        public Guid ShopId { get; set; }  // Guid (foreign key from Shops table)

        [Required]
        public string LinkUrl { get; set; }  // string

        [Required]
        public string ProductDescription { get; set; }  // string

        [ForeignKey("Country")]
        public string CountryId { get; set; }  // AlphaCode (foreign key from Countries table)

        [Required]
        public string ProductType { get; set; }  // string
        public string ImageSmallUrl { get; set; }
        public string BrandName { get; set; }

    }
}
