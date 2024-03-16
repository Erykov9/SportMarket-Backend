using Microsoft.AspNetCore.Identity;
using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Repositories.Products
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync(
            string? filterOn = null, string? filterQuery = null,
            string? sortBy = null, string? filterCategory = null, bool isAscending = true,
            int pageNumber = 1, int pageSize = 10);
        Task<Product?> GetByIdAsync(Guid id);
        Task<Product> CreateAsync(Product product, IdentityUser user);
        Task<Product?> DeleteAsync(Guid id);
        Task<Product?> UpdateAsync(Guid id, Product product);

    }
}
