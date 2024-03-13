using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Models.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
