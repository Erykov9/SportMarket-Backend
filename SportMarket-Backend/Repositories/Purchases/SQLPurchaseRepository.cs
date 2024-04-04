using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SportMarket_Backend.Data;
using SportMarket_Backend.Models.Domain;
using SportMarket_Backend.Models.DTO;

namespace SportMarket_Backend.Repositories.Purchases
{
    public class SQLPurchaseRepository : IPurchaseRepository
    {
        private readonly SportMarketDBContext _dbContext;

        public SQLPurchaseRepository(SportMarketDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Purchase?> AddPurchaseAsync(Purchase purchase, IdentityUser user)
        {
            var userToFind = Guid.Parse(user.Id);
            var userToInclude = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == userToFind);

            if (userToInclude == null)
            {
                return null;
            }

            purchase.UserId = userToInclude.Id;

            // payment service 
            purchase.IsPaid = true;
            purchase.PurchaseDate = DateTime.Now;


            await _dbContext.Purchases.AddAsync(purchase);
            await _dbContext.SaveChangesAsync();

            return purchase;
        }

        public async Task<Purchase[]?> GetAllAsync(IdentityUser user)
        {
            var userToFind = Guid.Parse(user.Id);
            var userToInclude = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == userToFind);

            if (userToInclude == null)
            {
                return null;
            }
            var purchases = await _dbContext.Purchases.Include(x => x.User).Include(x => x.Products).Where(x => x.UserId == userToInclude.Id).ToArrayAsync();


            return purchases;

        }
    }
}
