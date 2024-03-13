using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Models.DTO
{
    public class ProfileDTO
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public ICollection<ProfileProductsDTO> Products { get; set; } = new List<ProfileProductsDTO>();
    }
}
