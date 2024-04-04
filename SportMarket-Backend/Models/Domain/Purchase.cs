using SportMarket_Backend.Models.DTO;
using System.Text.Json.Serialization;

namespace SportMarket_Backend.Models.Domain
{
    public class Purchase
    {
        public Guid Id { get; set; }
        public List<ProductPurchaseDetailsDTO> Products { get; set; } = new List<ProductPurchaseDetailsDTO>();
        public bool IsPaid { get; set; }
        public int TotalPrice { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        public string StreetNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Guid UserId { get; set; }
        [JsonIgnore]
        public User User { get; set; }
    }
}
