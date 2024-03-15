using Microsoft.EntityFrameworkCore;
using SportMarket_Backend.Data;
using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Repositories.Categories
{
    public class SQLCategoryRepository : ICategoryRepository
    {
        private readonly SportMarketDBContext _dBContext;

        public SQLCategoryRepository(SportMarketDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public Task<List<Category>> GetAllAsync()
        {
            var categories = _dBContext.Categories.ToListAsync();

            return categories;
        }
    }
}
