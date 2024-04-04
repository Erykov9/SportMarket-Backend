namespace SportMarket_Backend.Models.DTO
{
    public class ProductPurchaseDetailsDTO
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
    }
}
