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

        public async Task<Product?> DeleteAsync(Guid id)
        {
            var product = await _dBContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return null;
            }

            _dBContext.Products.Remove(product);
            await _dBContext.SaveChangesAsync();

            return product;
        }

        public async Task<List<Product>> GetAllAsync(
            string? filterOn, string? filterQuery,
            string? sortBy, bool isAscending)
        {

            var products = _dBContext.Products.Include(x => x.Category).Include(p => p.User).AsQueryable();
            
            if(!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                if(filterOn.Equals("ProductName", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.Where(x => x.ProductName.Contains(filterQuery));
                }
                else if(filterOn.Equals("ProductDescription", StringComparison.OrdinalIgnoreCase))
                {
                    products = products.Where(x => x.ProductDescription.Contains(filterQuery));
                }
             
            }

            if(!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("ProductName", StringComparison.OrdinalIgnoreCase))
                {
                    products = isAscending ? products.OrderBy(x => x.ProductName) : products.OrderByDescending(x => x.ProductName);
                }
                else if(sortBy.Equals("ProductPrice", StringComparison.OrdinalIgnoreCase))
                {
                    products = isAscending ? products.OrderBy(x => x.ProductPrice) : products.OrderByDescending(x => x.ProductPrice);
                }
                else if(sortBy.Equals("ProductCategory", StringComparison.OrdinalIgnoreCase))
                {
                    products = isAscending ? products.OrderBy(x => x.Category.CategoryName) : products.OrderByDescending(x => x.Category.CategoryName);
                }
            }

            return await products.ToListAsync();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            var product = await _dBContext.Products.Include(x => x.Category).Include(p => p.User).FirstOrDefaultAsync(p => p.Id == id);

            if (product == null) 
            {
                return null;
            }

            return product;
        }

        public async Task<Product?> UpdateAsync(Guid id, Product product)
        {
            var existingProduct = await _dBContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (existingProduct == null) 
            {
                return null;
            }

            existingProduct.ProductName = product.ProductName;
            existingProduct.ProductDescription = product.ProductDescription;
            existingProduct.ProductPrice = product.ProductPrice;
            existingProduct.CategoryId = product.CategoryId;
            existingProduct.UserId = product.UserId;

            await _dBContext.SaveChangesAsync();
            return existingProduct;
        }
    }
}
