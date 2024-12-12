using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eScrap.Entities.eMag.GasCooker
{
    public class eMagGasCookerEmbedded
    {
        [Key]
        public Guid Id { get; set; }

        public int? ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal StandardPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountPrice { get; set; }

        public decimal DiscountPercentage { get; set; }

        [ForeignKey("Shop")]
        [Required]
        public Guid ShopId { get; set; }

        [Required]
        public string LinkUrl { get; set; }
        public string ProductDescription { get; set; }

        [ForeignKey("Country")]
        [Required]
        public string CountryId { get; set; }

        public string ProductType { get; set; }
        public string? ImageSmallUrl { get; set; }
        public string BrandName { get; set; }
    }
}
