﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportMarket_Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangeProductDTO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("05e797df-b0d0-45fa-a463-a82bd44ec964"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07a977da-cdcf-45ea-88c9-ec21d561505c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07d4ba83-8710-4b3b-a410-af005d52f1bc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("07f02fe6-d77e-4e40-91cf-f7cb142d7afd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c142a70-10a4-447d-ab37-feec124d9079"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b4ce54b-fc8a-4d11-9fe6-4b623e80c839"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dd44b1d-1b48-4a86-aab9-0e6e68b4ed0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4da0705c-97ec-44ca-a48b-4a49b5b75fe3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6adb2d66-bd7a-43e9-bff5-255f5f9e8bd2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fc3d917-77c2-4c38-93a3-7242b0076b11"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76adc8ca-d776-4b79-b5fa-49a8250f47d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d303261-4609-4902-94e2-64ba338305ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ac00fed-0f67-41e9-b2cc-87217e0d9371"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c29d200f-682c-4b2e-98ea-2db652e82bda"));

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductDescription", "ProductName", "ProductPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("126c2097-35b2-45f5-810b-936707ee9fa9"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.", "Performance Cycling Gloves", 29.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("1c970ab2-917d-45a9-bfbc-d39e41486722"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Durable, wall-mounted pull-up bar for various bodyweight exercises.", "Calisthenics Pull-Up Bar", 59.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("243ee5d3-0c97-410e-952b-2dc230edfb10"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.", "Premium Yoga Mat", 49.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("25ab06d9-cb93-4f8a-9bfc-46a73d85bb36"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "A high-quality, adjustable weight dumbbell set for all your strength training needs.", "Professional Dumbbell Set", 199.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("303b4bea-398c-4d93-a39e-23631bfb4dcb"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "High-visibility vest for safe running during early mornings or late evenings.", "Reflective Running Vest", 24.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("43bc5700-9d19-4ba1-bb0f-696a49847537"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.", "Thermal Snowboard Jacket", 159.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("444293ed-d113-4050-9154-10d175c22105"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Ergonomically designed handle to improve grip strength and arm wrestling techniques.", "Armwrestling Training Handle", 35.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("4678ea64-2fa3-47d4-a72d-73caa7080b28"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Traditional, durable karate uniform made from high-quality fabric for training and competitions.", "Karate Gi", 64.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("59431c77-47d5-4a0e-81c0-75e41fa168d2"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Highly protective and comfortable helmet for mountain biking enthusiasts.", "Mountain Bike Helmet", 89.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("75435026-a2a8-48c9-a2ad-ceb8d5f4ec5b"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Lightweight, yet sturdy parallettes for calisthenics training on the go.", "Portable Parallettes", 44.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("abb36b55-9ced-4ce0-83ca-0d4ce13c7894"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Competition-grade armwrestling table with adjustable height and padded surfaces.", "Professional Armwrestling Table", 299.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("b8c6fd38-f5fe-4973-b89b-83495bdfe28d"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.", "High-Performance Running Shoes", 119.98999999999999, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("db5d5790-19de-4d7e-a4e9-ed5443021069"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Versatile snowboard designed for all levels of snowboarding, offering stability and control.", "All-Mountain Snowboard", 399.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("eac2b4b0-c3c9-4e2c-aa09-0bf1b7b9284d"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Premium leather boxing gloves designed for maximum protection and performance.", "Boxing Gloves", 79.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("126c2097-35b2-45f5-810b-936707ee9fa9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c970ab2-917d-45a9-bfbc-d39e41486722"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("243ee5d3-0c97-410e-952b-2dc230edfb10"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25ab06d9-cb93-4f8a-9bfc-46a73d85bb36"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("303b4bea-398c-4d93-a39e-23631bfb4dcb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43bc5700-9d19-4ba1-bb0f-696a49847537"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("444293ed-d113-4050-9154-10d175c22105"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4678ea64-2fa3-47d4-a72d-73caa7080b28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59431c77-47d5-4a0e-81c0-75e41fa168d2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("75435026-a2a8-48c9-a2ad-ceb8d5f4ec5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("abb36b55-9ced-4ce0-83ca-0d4ce13c7894"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8c6fd38-f5fe-4973-b89b-83495bdfe28d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db5d5790-19de-4d7e-a4e9-ed5443021069"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eac2b4b0-c3c9-4e2c-aa09-0bf1b7b9284d"));

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductDescription", "ProductName", "ProductPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("05e797df-b0d0-45fa-a463-a82bd44ec964"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Ergonomically designed handle to improve grip strength and arm wrestling techniques.", "Armwrestling Training Handle", 35.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("07a977da-cdcf-45ea-88c9-ec21d561505c"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Versatile snowboard designed for all levels of snowboarding, offering stability and control.", "All-Mountain Snowboard", 399.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("07d4ba83-8710-4b3b-a410-af005d52f1bc"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Traditional, durable karate uniform made from high-quality fabric for training and competitions.", "Karate Gi", 64.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("07f02fe6-d77e-4e40-91cf-f7cb142d7afd"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Durable, wall-mounted pull-up bar for various bodyweight exercises.", "Calisthenics Pull-Up Bar", 59.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("1c142a70-10a4-447d-ab37-feec124d9079"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Premium leather boxing gloves designed for maximum protection and performance.", "Boxing Gloves", 79.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("2b4ce54b-fc8a-4d11-9fe6-4b623e80c839"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.", "Premium Yoga Mat", 49.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("3dd44b1d-1b48-4a86-aab9-0e6e68b4ed0b"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Competition-grade armwrestling table with adjustable height and padded surfaces.", "Professional Armwrestling Table", 299.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("4da0705c-97ec-44ca-a48b-4a49b5b75fe3"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "High-visibility vest for safe running during early mornings or late evenings.", "Reflective Running Vest", 24.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("6adb2d66-bd7a-43e9-bff5-255f5f9e8bd2"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Lightweight, yet sturdy parallettes for calisthenics training on the go.", "Portable Parallettes", 44.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("6fc3d917-77c2-4c38-93a3-7242b0076b11"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.", "High-Performance Running Shoes", 119.98999999999999, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("76adc8ca-d776-4b79-b5fa-49a8250f47d1"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "A high-quality, adjustable weight dumbbell set for all your strength training needs.", "Professional Dumbbell Set", 199.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("7d303261-4609-4902-94e2-64ba338305ef"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.", "Performance Cycling Gloves", 29.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("8ac00fed-0f67-41e9-b2cc-87217e0d9371"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Highly protective and comfortable helmet for mountain biking enthusiasts.", "Mountain Bike Helmet", 89.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("c29d200f-682c-4b2e-98ea-2db652e82bda"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.", "Thermal Snowboard Jacket", 159.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
