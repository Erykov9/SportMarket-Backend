using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Models.DTO
{
    public class ProfileProductsDTO
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public Category Category { get; set; }

        public ICollection<Image> Images { get; } = new List<Image>();
    }
}
