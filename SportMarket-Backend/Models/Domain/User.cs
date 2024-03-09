

using SportMarket_Backend.Models.DTO;

namespace SportMarket_Backend.Models.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int RankPoints { get; set; }
        public Guid RankNameId { get; set; }
        public RankName RankName { get; set; }
        public ICollection<ProductDTO> Products { get; set; } = new List<ProductDTO>();

    }
}
