using System.ComponentModel.DataAnnotations;

namespace SportMarket_Backend.Models.DTO
{
    public class AddProductRequestDTO
    {
        [Required]
        [MinLength(6, ErrorMessage = "Product name should have at least 6 characters.")]
        [MaxLength(36, ErrorMessage = "Product name has to be maximum of 36 characters.")]
        public string ProductName { get; set; }

        [Required]
        [MinLength(20, ErrorMessage = "Product description should have at least 20 characters.")]
        [MaxLength(1000, ErrorMessage = "Product description has to be maximum of 1000 characters.")]
        public string ProductDescription { get; set; }

        [Required]
        public string ProductCategory { get; set; }

        [Required]
        [Range(1, 100000)]
        public double ProductPrice { get; set; }

        [Required]
        public Guid UserId { get; set; }
    }
}
