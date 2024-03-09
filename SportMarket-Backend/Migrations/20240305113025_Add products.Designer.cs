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
    [Migration("20240305113025_Add products")]
    partial class Addproducts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

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

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

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
                            Id = new Guid("76adc8ca-d776-4b79-b5fa-49a8250f47d1"),
                            CategoryId = new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                            ProductDescription = "A high-quality, adjustable weight dumbbell set for all your strength training needs.",
                            ProductName = "Professional Dumbbell Set",
                            ProductPrice = 199.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("2b4ce54b-fc8a-4d11-9fe6-4b623e80c839"),
                            CategoryId = new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"),
                            ProductDescription = "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.",
                            ProductName = "Premium Yoga Mat",
                            ProductPrice = 49.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("05e797df-b0d0-45fa-a463-a82bd44ec964"),
                            CategoryId = new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                            ProductDescription = "Ergonomically designed handle to improve grip strength and arm wrestling techniques.",
                            ProductName = "Armwrestling Training Handle",
                            ProductPrice = 35.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("3dd44b1d-1b48-4a86-aab9-0e6e68b4ed0b"),
                            CategoryId = new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"),
                            ProductDescription = "Competition-grade armwrestling table with adjustable height and padded surfaces.",
                            ProductName = "Professional Armwrestling Table",
                            ProductPrice = 299.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("07f02fe6-d77e-4e40-91cf-f7cb142d7afd"),
                            CategoryId = new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                            ProductDescription = "Durable, wall-mounted pull-up bar for various bodyweight exercises.",
                            ProductName = "Calisthenics Pull-Up Bar",
                            ProductPrice = 59.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("6adb2d66-bd7a-43e9-bff5-255f5f9e8bd2"),
                            CategoryId = new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"),
                            ProductDescription = "Lightweight, yet sturdy parallettes for calisthenics training on the go.",
                            ProductName = "Portable Parallettes",
                            ProductPrice = 44.990000000000002,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("8ac00fed-0f67-41e9-b2cc-87217e0d9371"),
                            CategoryId = new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                            ProductDescription = "Highly protective and comfortable helmet for mountain biking enthusiasts.",
                            ProductName = "Mountain Bike Helmet",
                            ProductPrice = 89.989999999999995,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("7d303261-4609-4902-94e2-64ba338305ef"),
                            CategoryId = new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"),
                            ProductDescription = "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.",
                            ProductName = "Performance Cycling Gloves",
                            ProductPrice = 29.989999999999998,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("07a977da-cdcf-45ea-88c9-ec21d561505c"),
                            CategoryId = new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                            ProductDescription = "Versatile snowboard designed for all levels of snowboarding, offering stability and control.",
                            ProductName = "All-Mountain Snowboard",
                            ProductPrice = 399.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("c29d200f-682c-4b2e-98ea-2db652e82bda"),
                            CategoryId = new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"),
                            ProductDescription = "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.",
                            ProductName = "Thermal Snowboard Jacket",
                            ProductPrice = 159.99000000000001,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("6fc3d917-77c2-4c38-93a3-7242b0076b11"),
                            CategoryId = new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                            ProductDescription = "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.",
                            ProductName = "High-Performance Running Shoes",
                            ProductPrice = 119.98999999999999,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("4da0705c-97ec-44ca-a48b-4a49b5b75fe3"),
                            CategoryId = new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                            ProductDescription = "High-visibility vest for safe running during early mornings or late evenings.",
                            ProductName = "Reflective Running Vest",
                            ProductPrice = 24.989999999999998,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("07d4ba83-8710-4b3b-a410-af005d52f1bc"),
                            CategoryId = new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                            ProductDescription = "Traditional, durable karate uniform made from high-quality fabric for training and competitions.",
                            ProductName = "Karate Gi",
                            ProductPrice = 64.989999999999995,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
                        },
                        new
                        {
                            Id = new Guid("1c142a70-10a4-447d-ab37-feec124d9079"),
                            CategoryId = new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                            ProductDescription = "Premium leather boxing gloves designed for maximum protection and performance.",
                            ProductName = "Boxing Gloves",
                            ProductPrice = 79.989999999999995,
                            UserId = new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b")
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

            modelBuilder.Entity("SportMarket_Backend.Models.Domain.Image", b =>
                {
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
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
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