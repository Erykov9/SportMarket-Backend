namespace SportMarket_Backend.Models.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int RankPoints { get; set; }
        public string? RankName { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
