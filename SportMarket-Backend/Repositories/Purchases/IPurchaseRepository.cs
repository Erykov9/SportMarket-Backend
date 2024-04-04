using Microsoft.AspNetCore.Identity;
using SportMarket_Backend.Models.Domain;
using SportMarket_Backend.Models.DTO;

namespace SportMarket_Backend.Repositories.Purchases
{
    public interface IPurchaseRepository
    {
        Task<Purchase?> AddPurchaseAsync(Purchase purchase, IdentityUser user);
        Task<Purchase[]?> GetAllAsync(IdentityUser user);
    }
}
