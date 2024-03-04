using Microsoft.EntityFrameworkCore;
using SportMarket_Backend.Data;
using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Repositories.Products
{
    public class SQLProductRepository : IProductRepository
    {
        private readonly SportMarketDBContext _dBContext;

        public SQLProductRepository(SportMarketDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await _dBContext.Products.AddAsync(product);
            await _dBContext.SaveChangesAsync();

            return product;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            var products = await _dBContext.Products.ToListAsync();

            return products;
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            var product = await _dBContext.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null) 
            {
                return null;
            }

            return product;
        }


    }
}
