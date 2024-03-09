namespace SportMarket_Backend.Models.DTO
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public int RankPoints { get; set; }
        public string? RankName { get; set; }
    }
}
