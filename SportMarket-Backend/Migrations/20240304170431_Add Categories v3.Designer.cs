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
    [Migration("20240304170431_Add Categories v3")]
    partial class AddCategoriesv3
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

                    b.Property<string>("ProductCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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