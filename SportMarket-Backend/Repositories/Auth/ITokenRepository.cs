using Microsoft.AspNetCore.Identity;

namespace SportMarket_Backend.Repositories.Auth
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
