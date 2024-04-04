using System.Text.Json.Serialization;

namespace SportMarket_Backend.Models.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Location { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        [JsonIgnore]
        public User User { get; set; }
        public Guid UserId { get; set; }
        public ICollection<Image> Images { get; } = new List<Image>();

    }
}
