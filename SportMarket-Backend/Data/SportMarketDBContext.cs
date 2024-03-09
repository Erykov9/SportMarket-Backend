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

        public DbSet<Category> Categories { get; set; }
        public DbSet<RankName> RankNames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var rankNames = new List<RankName>()
            {
                new RankName()
                {
                    Id = Guid.Parse("52adcc6c-0cef-480e-a102-c8730097e9a4"),
                    Name = "Novice"
                },
                new RankName()
                {
                    Id = Guid.Parse("c63a2412-8b0f-412a-af49-602a5bf3817e"),
                    Name = "Beginner"
                },
                new RankName()
                {
                    Id = Guid.Parse("5e0f74cc-97ce-45b5-86e5-4bc00b6035ea"),
                    Name = "Intermediate"
                },
                new RankName()
                {
                    Id = Guid.Parse("8c8e7caa-ee71-44c9-8020-283d02a30d82"),
                    Name = "Advanced"
                },
                new RankName()
                {
                    Id = Guid.Parse("927a6629-d6b2-4833-ac09-acdc07ae39e7"),
                    Name = "Legendary"
                },
            };

            modelBuilder.Entity<RankName>().HasData(rankNames);

            var user = new User()
            {
                Id = Guid.Parse("e845efaa-1d29-4851-88c3-bf35a48f816b"),
                Username = "Erykov9",
                Email = "szczepanekeryk@gmail.com",
                RankPoints = 0,
                RankNameId = Guid.Parse("927a6629-d6b2-4833-ac09-acdc07ae39e7"),
            };

            modelBuilder.Entity<User>().HasData(user);

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
                    CategoryName = "Runnig"
                },
                new Category()
                {
                    Id = Guid.Parse("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                    CategoryName = "Material Arts"
                }
            };

            modelBuilder.Entity<Category>().HasData(categories);

            var products = new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Professional Dumbbell Set",
                    ProductDescription = "A high-quality, adjustable weight dumbbell set for all your strength training needs.",
                    ProductPrice = 199.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Premium Yoga Mat",
                    ProductDescription = "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.",
                    ProductPrice = 49.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                },

                // Produkty dla kategorii Armwrestling
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Armwrestling Training Handle",
                    ProductDescription = "Ergonomically designed handle to improve grip strength and arm wrestling techniques.",
                    ProductPrice = 35.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Professional Armwrestling Table",
                    ProductDescription = "Competition-grade armwrestling table with adjustable height and padded surfaces.",
                    ProductPrice = 299.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                },

                // Produkty dla kategorii Calisthenics
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Calisthenics Pull-Up Bar",
                    ProductDescription = "Durable, wall-mounted pull-up bar for various bodyweight exercises.",
                    ProductPrice = 59.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Portable Parallettes",
                    ProductDescription = "Lightweight, yet sturdy parallettes for calisthenics training on the go.",
                    ProductPrice = 44.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                },

                // Produkty dla kategorii Biking
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Mountain Bike Helmet",
                    ProductDescription = "Highly protective and comfortable helmet for mountain biking enthusiasts.",
                    ProductPrice = 89.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Performance Cycling Gloves",
                    ProductDescription = "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.",
                    ProductPrice = 29.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                },

                // Produkty dla kategorii Snowboard
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "All-Mountain Snowboard",
                    ProductDescription = "Versatile snowboard designed for all levels of snowboarding, offering stability and control.",
                    ProductPrice = 399.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Thermal Snowboard Jacket",
                    ProductDescription = "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.",
                    ProductPrice = 159.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                },

                // Produkty dla kategorii Running
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "High-Performance Running Shoes",
                    ProductDescription = "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.",
                    ProductPrice = 119.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Reflective Running Vest",
                    ProductDescription = "High-visibility vest for safe running during early mornings or late evenings.",
                    ProductPrice = 24.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                },

                // Produkty dla kategorii Martial Arts
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Karate Gi",
                    ProductDescription = "Traditional, durable karate uniform made from high-quality fabric for training and competitions.",
                    ProductPrice = 64.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Boxing Gloves",
                    ProductDescription = "Premium leather boxing gloves designed for maximum protection and performance.",
                    ProductPrice = 79.99,
                    UserId = Guid.Parse("E845EFAA-1D29-4851-88C3-BF35A48F816B"),
                    CategoryId = Guid.Parse("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                },
            };

            modelBuilder.Entity<Product>().HasData(products);
            
        }
    }
}
