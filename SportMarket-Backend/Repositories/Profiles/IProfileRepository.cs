using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Repositories.Profiles
{
    public interface IProfileRepository
    {
        Task<User?> GetUserByUsernameAsync(string username);
    }
}
