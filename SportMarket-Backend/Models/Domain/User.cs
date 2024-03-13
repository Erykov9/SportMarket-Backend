namespace SportMarket_Backend.Models.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Guid UserId { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
