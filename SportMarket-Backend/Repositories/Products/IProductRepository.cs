using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Repositories.Products
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(Guid id);
        Task<Product> CreateAsync(Product product);
    }
}
