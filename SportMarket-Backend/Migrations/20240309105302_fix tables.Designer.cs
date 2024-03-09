﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportMarket_Backend.Data;

#nullable disable

namespace SportMarket_Backend.Migrations
{
    [DbContext(typeof(SportMarketDBContext))]
    [Migration("20240309105302_fix tables")]
    partial class fixtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SportMarket_Backend.Models.DTO.ProductDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("ProductDTO");
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                            CategoryName = "Gym"
                        },
                        new
                        {
                            Id = new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                            CategoryName = "Armwrestling"
                        },
                        new
                        {
                            Id = new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                            CategoryName = "Calisthenics"
                        },
                        new
                        {
                            Id = new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                            CategoryName = "Biking"
                        },
                        new
                        {
                            Id = new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                            CategoryName = "Snowboard"
                        },
                        new
                        {
                            Id = new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                            CategoryName = "Runnig"
                        },
                        new
                        {
                            Id = new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                            CategoryName = "Material Arts"
                        });
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FileDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint");

                    b.Property<string>("FileUsername")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProductDTOId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductDTOId");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ProductPrice")
                        .HasColumnType("float");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6ed860b5-cd90-4e3b-bad4-ce889b520553"),
                            CategoryId = new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                            ProductDescription = "A high-quality, adjustable weight dumbbell set for all your strength training needs.",
                            ProductName = "Professional Dumbbell Set",
                            ProductPrice = 199.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("5b57fc16-f488-4893-a7e2-5c1055429ba6"),
                            CategoryId = new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                            ProductDescription = "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.",
                            ProductName = "Premium Yoga Mat",
                            ProductPrice = 49.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("8e65738b-9723-4dcb-ab88-1d8af22d911e"),
                            CategoryId = new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                            ProductDescription = "Ergonomically designed handle to improve grip strength and arm wrestling techniques.",
                            ProductName = "Armwrestling Training Handle",
                            ProductPrice = 35.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("3a7eb8ce-b0d4-4150-b49b-58354ad7963f"),
                            CategoryId = new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                            ProductDescription = "Competition-grade armwrestling table with adjustable height and padded surfaces.",
                            ProductName = "Professional Armwrestling Table",
                            ProductPrice = 299.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("26788bb7-7423-46fd-98c7-4c881e29107a"),
                            CategoryId = new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                            ProductDescription = "Durable, wall-mounted pull-up bar for various bodyweight exercises.",
                            ProductName = "Calisthenics Pull-Up Bar",
                            ProductPrice = 59.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("6c4fc9e4-00f8-46a8-8e97-0151af484c8a"),
                            CategoryId = new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                            ProductDescription = "Lightweight, yet sturdy parallettes for calisthenics training on the go.",
                            ProductName = "Portable Parallettes",
                            ProductPrice = 44.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("7932c9af-1dc8-4f6e-b15b-fdc9e399e550"),
                            CategoryId = new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                            ProductDescription = "Highly protective and comfortable helmet for mountain biking enthusiasts.",
                            ProductName = "Mountain Bike Helmet",
                            ProductPrice = 89.989999999999995,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("1185c131-f821-4f56-9bb2-81028ab0a25b"),
                            CategoryId = new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                            ProductDescription = "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.",
                            ProductName = "Performance Cycling Gloves",
                            ProductPrice = 29.989999999999998,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("632a1f91-1ce8-4be5-a441-5362a7b51809"),
                            CategoryId = new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                            ProductDescription = "Versatile snowboard designed for all levels of snowboarding, offering stability and control.",
                            ProductName = "All-Mountain Snowboard",
                            ProductPrice = 399.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("ab6d886e-78b1-4ad9-9517-2645d40b19a9"),
                            CategoryId = new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                            ProductDescription = "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.",
                            ProductName = "Thermal Snowboard Jacket",
                            ProductPrice = 159.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("79c0898c-ffdd-4bbc-82da-0b4472c148c6"),
                            CategoryId = new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                            ProductDescription = "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.",
                            ProductName = "High-Performance Running Shoes",
                            ProductPrice = 119.98999999999999,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("61459ff4-9c6c-43ed-bafb-876cb8b59bd6"),
                            CategoryId = new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                            ProductDescription = "High-visibility vest for safe running during early mornings or late evenings.",
                            ProductName = "Reflective Running Vest",
                            ProductPrice = 24.989999999999998,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("6854046c-fe8c-43d1-9359-dc84bcc27522"),
                            CategoryId = new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                            ProductDescription = "Traditional, durable karate uniform made from high-quality fabric for training and competitions.",
                            ProductName = "Karate Gi",
                            ProductPrice = 64.989999999999995,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("13a86834-ec1e-46e3-94ab-dba9edb71005"),
                            CategoryId = new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                            ProductDescription = "Premium leather boxing gloves designed for maximum protection and performance.",
                            ProductName = "Boxing Gloves",
                            ProductPrice = 79.989999999999995,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        });
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.RankName", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RankNames");

                    b.HasData(
                        new
                        {
                            Id = new Guid("52adcc6c-0cef-480e-a102-c8730097e9a4"),
                            Name = "Novice"
                        },
                        new
                        {
                            Id = new Guid("c63a2412-8b0f-412a-af49-602a5bf3817e"),
                            Name = "Beginner"
                        },
                        new
                        {
                            Id = new Guid("5e0f74cc-97ce-45b5-86e5-4bc00b6035ea"),
                            Name = "Intermediate"
                        },
                        new
                        {
                            Id = new Guid("8c8e7caa-ee71-44c9-8020-283d02a30d82"),
                            Name = "Advanced"
                        },
                        new
                        {
                            Id = new Guid("927a6629-d6b2-4833-ac09-acdc07ae39e7"),
                            Name = "Legendary"
                        });
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RankNameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RankPoints")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RankNameId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b"),
                            Email = "szczepanekeryk@gmail.com",
                            RankNameId = new Guid("927a6629-d6b2-4833-ac09-acdc07ae39e7"),
                            RankPoints = 0,
                            Username = "Erykov9"
                        });
                });

            modelBuilder.Entity("SportMarket_Backend.Models.DTO.ProductDTO", b =>
                {
                    b.HasOne("SportMarket_Backend.Models.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportMarket_Backend.Models.Domain.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.Image", b =>
                {
                    b.HasOne("SportMarket_Backend.Models.DTO.ProductDTO", null)
                        .WithMany("Images")
                        .HasForeignKey("ProductDTOId");

                    b.HasOne("SportMarket_Backend.Models.Domain.Product", "Product")
                        .WithMany("Images")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.Product", b =>
                {
                    b.HasOne("SportMarket_Backend.Models.Domain.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportMarket_Backend.Models.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.User", b =>
                {
                    b.HasOne("SportMarket_Backend.Models.Domain.RankName", "RankName")
                        .WithMany()
                        .HasForeignKey("RankNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RankName");
                });

            modelBuilder.Entity("SportMarket_Backend.Models.DTO.ProductDTO", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.Product", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.User", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
