using Microsoft.EntityFrameworkCore;
using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Data
{
    public class SportMarketDBContext: DbContext
    {
        public SportMarketDBContext(DbContextOptions<SportMarketDBContext> dbContextOptions): base(dbContextOptions) {}

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var user = new User()
            {
                Id = Guid.Parse("e845efaa-1d29-4851-88c3-bf35a48f816b"),
                Username = "Erykov9",
                Email = "szczepanekeryk@gmail.com",
                RankPoints = 0,
            };

            modelBuilder.Entity<User>().HasData(user);
            
        }
    }
}
