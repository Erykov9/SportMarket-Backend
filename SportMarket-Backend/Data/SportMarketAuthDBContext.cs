using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SportMarket_Backend.Data
{
    public class SportMarketAuthDBContext : IdentityDbContext
    {
        public SportMarketAuthDBContext(DbContextOptions<SportMarketAuthDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var basicUserId = "96c9ae63-938d-4435-8531-37c4919decde";
            var adminUserId = "41e8a963-fc56-4d60-b56d-f717e26f4015";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {
                    Id = basicUserId,
                    ConcurrencyStamp = basicUserId,
                    Name = "User",
                    NormalizedName = "User".ToUpper(),
                },
                new IdentityRole
                {
                    Id = adminUserId,
                    ConcurrencyStamp = adminUserId,
                    Name = "Admin",
                    NormalizedName = "Admin".ToUpper()
                }
            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
