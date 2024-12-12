using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace eScrap.Entities.MediaGalaxy.GasCooker
{
    public class MediaGalaxyOvenEmbedded
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int? ProductId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal StandardPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal DiscountPrice { get; set; }

        [Required]
        public decimal DiscountPercentage { get; set; }

        [ForeignKey("Shop")]
        public Guid ShopId { get; set; }

        [Required]
        public string LinkUrl { get; set; }

        [Required]
        public string ProductDescription { get; set; }

        [ForeignKey("Country")]
        public string CountryId { get; set; }

        [Required]
        public string ProductType { get; set; }
        public string ImageSmallUrl { get; set; }
        public string BrandName { get; set; }
    }
}
