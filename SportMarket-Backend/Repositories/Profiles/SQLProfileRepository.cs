using Microsoft.EntityFrameworkCore;
using SportMarket_Backend.Data;
using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Repositories.Profiles
{
    public class SQLProfileRepository : IProfileRepository
    {
        private readonly SportMarketDBContext _dbContext;

        public SQLProfileRepository(SportMarketDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User?> GetUserByUsernameAsync(string username)
        {
            var user = await _dbContext.Users.Include(u => u.Products).FirstOrDefaultAsync(x => x.Username == username);
            
            if (user == null) {
                return null;
            }

            return user;
        }
    }
}
