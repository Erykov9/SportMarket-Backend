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
                    CategoryId = Guid.Parse("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Premium Yoga Mat",
                    ProductDescription = "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.",
                    ProductPrice = 49.99,
                    CategoryId = Guid.Parse("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                },

                // Produkty dla kategorii Armwrestling
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Armwrestling Training Handle",
                    ProductDescription = "Ergonomically designed handle to improve grip strength and arm wrestling techniques.",
                    ProductPrice = 35.99,
                    CategoryId = Guid.Parse("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Professional Armwrestling Table",
                    ProductDescription = "Competition-grade armwrestling table with adjustable height and padded surfaces.",
                    ProductPrice = 299.99,
                    CategoryId = Guid.Parse("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                },

                // Produkty dla kategorii Calisthenics
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Calisthenics Pull-Up Bar",
                    ProductDescription = "Durable, wall-mounted pull-up bar for various bodyweight exercises.",
                    ProductPrice = 59.99,
                    CategoryId = Guid.Parse("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Portable Parallettes",
                    ProductDescription = "Lightweight, yet sturdy parallettes for calisthenics training on the go.",
                    ProductPrice = 44.99,
                    CategoryId = Guid.Parse("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                },

                // Produkty dla kategorii Biking
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Mountain Bike Helmet",
                    ProductDescription = "Highly protective and comfortable helmet for mountain biking enthusiasts.",
                    ProductPrice = 89.99,
                    CategoryId = Guid.Parse("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Performance Cycling Gloves",
                    ProductDescription = "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.",
                    ProductPrice = 29.99,
                    CategoryId = Guid.Parse("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                },

                // Produkty dla kategorii Snowboard
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "All-Mountain Snowboard",
                    ProductDescription = "Versatile snowboard designed for all levels of snowboarding, offering stability and control.",
                    ProductPrice = 399.99,
                    CategoryId = Guid.Parse("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Thermal Snowboard Jacket",
                    ProductDescription = "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.",
                    ProductPrice = 159.99,
                    CategoryId = Guid.Parse("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                },

                // Produkty dla kategorii Running
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "High-Performance Running Shoes",
                    ProductDescription = "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.",
                    ProductPrice = 119.99,
                    CategoryId = Guid.Parse("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Reflective Running Vest",
                    ProductDescription = "High-visibility vest for safe running during early mornings or late evenings.",
                    ProductPrice = 24.99,
                    CategoryId = Guid.Parse("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                },

                // Produkty dla kategorii Martial Arts
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Karate Gi",
                    ProductDescription = "Traditional, durable karate uniform made from high-quality fabric for training and competitions.",
                    ProductPrice = 64.99,
                    CategoryId = Guid.Parse("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Boxing Gloves",
                    ProductDescription = "Premium leather boxing gloves designed for maximum protection and performance.",
                    ProductPrice = 79.99,
                    CategoryId = Guid.Parse("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                },
            };

            modelBuilder.Entity<Product>().HasData(products);
            
        }
    }
}
