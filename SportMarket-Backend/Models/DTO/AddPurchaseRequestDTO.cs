using SportMarket_Backend.Models.Domain;
using System.ComponentModel.DataAnnotations;

namespace SportMarket_Backend.Models.DTO
{
    public class AddPurchaseRequestDTO
    {
        [Required]
        public int TotalPrice { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string StreetNumber { get; set; }
        [Required]
        public List<ProductPurchaseDetailsDTO> Products { get; set; } = new List<ProductPurchaseDetailsDTO>();
    }
}
