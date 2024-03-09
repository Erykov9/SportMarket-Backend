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
    [Migration("20240305124404_Change Yser Model v4")]
    partial class ChangeYserModelv4
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
                            Id = new Guid("0a89ce86-2bf7-483c-9b30-bceb3d618e31"),
                            CategoryId = new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                            ProductDescription = "A high-quality, adjustable weight dumbbell set for all your strength training needs.",
                            ProductName = "Professional Dumbbell Set",
                            ProductPrice = 199.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("51e20156-133e-4093-8c03-2f598988988a"),
                            CategoryId = new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                            ProductDescription = "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.",
                            ProductName = "Premium Yoga Mat",
                            ProductPrice = 49.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("e9fbc5b9-c9b7-4dba-9d8a-4912c8b9be44"),
                            CategoryId = new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                            ProductDescription = "Ergonomically designed handle to improve grip strength and arm wrestling techniques.",
                            ProductName = "Armwrestling Training Handle",
                            ProductPrice = 35.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("9eb0eee1-bf66-48fa-ac1a-7a353bd10899"),
                            CategoryId = new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                            ProductDescription = "Competition-grade armwrestling table with adjustable height and padded surfaces.",
                            ProductName = "Professional Armwrestling Table",
                            ProductPrice = 299.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("3751400b-aaf2-43b5-8e36-c56d1244d2b5"),
                            CategoryId = new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                            ProductDescription = "Durable, wall-mounted pull-up bar for various bodyweight exercises.",
                            ProductName = "Calisthenics Pull-Up Bar",
                            ProductPrice = 59.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("1552ac25-91e9-48bf-ac1b-558c90633f0f"),
                            CategoryId = new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                            ProductDescription = "Lightweight, yet sturdy parallettes for calisthenics training on the go.",
                            ProductName = "Portable Parallettes",
                            ProductPrice = 44.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("5ba8e98b-c421-4fca-8d40-b2d1e3619a6f"),
                            CategoryId = new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                            ProductDescription = "Highly protective and comfortable helmet for mountain biking enthusiasts.",
                            ProductName = "Mountain Bike Helmet",
                            ProductPrice = 89.989999999999995,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("da64f150-ce2a-4370-8488-b780ece659be"),
                            CategoryId = new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                            ProductDescription = "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.",
                            ProductName = "Performance Cycling Gloves",
                            ProductPrice = 29.989999999999998,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("00fc85c0-5149-4946-a087-282a77761b59"),
                            CategoryId = new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                            ProductDescription = "Versatile snowboard designed for all levels of snowboarding, offering stability and control.",
                            ProductName = "All-Mountain Snowboard",
                            ProductPrice = 399.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("445e8abd-125d-4fe0-8153-2678e3a5ceb5"),
                            CategoryId = new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                            ProductDescription = "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.",
                            ProductName = "Thermal Snowboard Jacket",
                            ProductPrice = 159.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("c50d08fb-17d8-46ad-b2a4-e9dd679d08db"),
                            CategoryId = new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                            ProductDescription = "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.",
                            ProductName = "High-Performance Running Shoes",
                            ProductPrice = 119.98999999999999,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("8ae6944e-c7f8-4b31-8ff8-a3ac41e3b287"),
                            CategoryId = new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                            ProductDescription = "High-visibility vest for safe running during early mornings or late evenings.",
                            ProductName = "Reflective Running Vest",
                            ProductPrice = 24.989999999999998,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("d38c36ce-fa48-4f0d-90b5-8803667c9bf6"),
                            CategoryId = new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                            ProductDescription = "Traditional, durable karate uniform made from high-quality fabric for training and competitions.",
                            ProductName = "Karate Gi",
                            ProductPrice = 64.989999999999995,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("c2a049f2-bd31-4b36-b10e-09388d6f6210"),
                            CategoryId = new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                            ProductDescription = "Premium leather boxing gloves designed for maximum protection and performance.",
                            ProductName = "Boxing Gloves",
                            ProductPrice = 79.989999999999995,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        });
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.UserDTO", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RankPoints")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b"),
                            Email = "szczepanekeryk@gmail.com",
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

                    b.HasOne("SportMarket_Backend.Models.Domain.UserDTO", "User")
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

                    b.HasOne("SportMarket_Backend.Models.Domain.UserDTO", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportMarket_Backend.Models.DTO.ProductDTO", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.Product", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.UserDTO", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
