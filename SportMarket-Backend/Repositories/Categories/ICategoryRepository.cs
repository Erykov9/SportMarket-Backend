using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Repositories.Categories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
    }
}
