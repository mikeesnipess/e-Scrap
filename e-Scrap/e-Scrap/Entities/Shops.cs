using System.ComponentModel.DataAnnotations;

namespace e_Scrap.Entities
{
    public class Shops
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
        public Guid CountryId { get; set; }
    }
}
