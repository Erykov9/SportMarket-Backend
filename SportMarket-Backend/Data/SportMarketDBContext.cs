using Microsoft.EntityFrameworkCore;
using SportMarket_Backend.Models.Domain;

namespace SportMarket_Backend.Data
{
    public class SportMarketDBContext: DbContext
    {
        public SportMarketDBContext(DbContextOptions<SportMarketDBContext> dbContextOptions): base(dbContextOptions) {}

        public DbSet<Product> Products { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categories = new List<Category>()
            {
                new Category()
                {
                    Id = Guid.Parse("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                    CategoryName = "Gym",
                },
                new Category()
                {
                    Id = Guid.Parse("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                    CategoryName = "Armwrestling"
                },
                new Category()
                {
                    Id = Guid.Parse("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                    CategoryName = "Calisthenics"
                },
                new Category()
                {
                    Id = Guid.Parse("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                    CategoryName = "Biking"
                },
                new Category()
                {
                    Id = Guid.Parse("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                    CategoryName = "Snowboard"
                },
                new Category()
                {
                    Id = Guid.Parse("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                    CategoryName = "Running"
                },
                new Category()
                {
                    Id = Guid.Parse("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                    CategoryName = "Martial Arts"
                }
            };

            modelBuilder.Entity<Category>().HasData(categories);
            
        }
    }
}
