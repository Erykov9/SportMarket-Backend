using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Models.DTO
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public double ProductPrice { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<Image> Images { get; } = new List<Image>();
    }
}
