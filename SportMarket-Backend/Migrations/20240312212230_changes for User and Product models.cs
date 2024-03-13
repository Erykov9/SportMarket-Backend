using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportMarket_Backend.Migrations
{
    /// <inheritdoc />
    public partial class changesforUserandProductmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("10d981c9-017e-4fdf-98d5-1fcc3d0f2b46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2cc00a29-d697-4723-8522-62ac208c53d7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d734a4b-311e-4a82-8d87-0a862c30c644"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42fbcfe9-4372-4c0e-b84d-d19f9fd709a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a9b092a-baa0-4579-94ec-4591f05a4a0a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b109b81-1a53-4fec-accc-3fc3f4565b2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50f1e82c-320c-445f-98c4-9662a995d7c3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65de2ac7-6fcb-4ca8-9b4c-4627230c32e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6bb67048-012b-4741-a1cd-cf700b94c66c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8967933f-0dfa-4efc-bfa2-766da6c89404"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("89fd7ec6-45d7-4d6c-b348-f545f1518989"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("920bb16e-dfcb-48a2-9da6-cae3a4d387ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("adf41bc1-30f0-4d36-b345-7aad77b57340"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f0cda2dc-3bc0-496b-8fda-9b84e9b1c15e"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductDescription", "ProductName", "ProductPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("01cbbc93-7f13-4052-95f6-7b9fe175af66"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Durable, wall-mounted pull-up bar for various bodyweight exercises.", "Calisthenics Pull-Up Bar", 59.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("3a9439b0-1ee6-4730-a8ee-5304a15c9ab6"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Competition-grade armwrestling table with adjustable height and padded surfaces.", "Professional Armwrestling Table", 299.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("47651f00-cbd9-485b-bd68-c680d84c42b1"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Lightweight, yet sturdy parallettes for calisthenics training on the go.", "Portable Parallettes", 44.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("54af372c-5945-409f-ad19-799b351621fc"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Highly protective and comfortable helmet for mountain biking enthusiasts.", "Mountain Bike Helmet", 89.989999999999995, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("5c50511f-2862-46d9-a213-232b1ffdc647"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Versatile snowboard designed for all levels of snowboarding, offering stability and control.", "All-Mountain Snowboard", 399.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("8723cb05-2f76-4460-a228-530d0274d3eb"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Ergonomically designed handle to improve grip strength and arm wrestling techniques.", "Armwrestling Training Handle", 35.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("9b0aac2f-16b7-495d-a7e0-109670f9c1de"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.", "Premium Yoga Mat", 49.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("a0c32800-9acf-4256-a598-ab74445e4ae1"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "A high-quality, adjustable weight dumbbell set for all your strength training needs.", "Professional Dumbbell Set", 199.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("afc7b3ba-403e-4fcb-9e53-29ce9e9dbeaf"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "High-visibility vest for safe running during early mornings or late evenings.", "Reflective Running Vest", 24.989999999999998, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("c8bf32c4-7f4f-4371-87bd-b387c89f2836"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.", "Performance Cycling Gloves", 29.989999999999998, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("dc907b69-6781-4c39-a98a-2e77c0d4ef35"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.", "Thermal Snowboard Jacket", 159.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("e1dba9db-148c-463b-954f-cfc1ebf2f8e0"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Traditional, durable karate uniform made from high-quality fabric for training and competitions.", "Karate Gi", 64.989999999999995, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("ece4bcd9-eb6c-439f-a79e-91d7bdc335ab"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Premium leather boxing gloves designed for maximum protection and performance.", "Boxing Gloves", 79.989999999999995, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("ffaacbdb-0e6e-478a-9f99-b3bb272d798a"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.", "High-Performance Running Shoes", 119.98999999999999, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01cbbc93-7f13-4052-95f6-7b9fe175af66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a9439b0-1ee6-4730-a8ee-5304a15c9ab6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47651f00-cbd9-485b-bd68-c680d84c42b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("54af372c-5945-409f-ad19-799b351621fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c50511f-2862-46d9-a213-232b1ffdc647"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8723cb05-2f76-4460-a228-530d0274d3eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9b0aac2f-16b7-495d-a7e0-109670f9c1de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0c32800-9acf-4256-a598-ab74445e4ae1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afc7b3ba-403e-4fcb-9e53-29ce9e9dbeaf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8bf32c4-7f4f-4371-87bd-b387c89f2836"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dc907b69-6781-4c39-a98a-2e77c0d4ef35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e1dba9db-148c-463b-954f-cfc1ebf2f8e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ece4bcd9-eb6c-439f-a79e-91d7bdc335ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ffaacbdb-0e6e-478a-9f99-b3bb272d798a"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductDescription", "ProductName", "ProductPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("10d981c9-017e-4fdf-98d5-1fcc3d0f2b46"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.", "Thermal Snowboard Jacket", 159.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("2cc00a29-d697-4723-8522-62ac208c53d7"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Highly protective and comfortable helmet for mountain biking enthusiasts.", "Mountain Bike Helmet", 89.989999999999995, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("3d734a4b-311e-4a82-8d87-0a862c30c644"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Durable, wall-mounted pull-up bar for various bodyweight exercises.", "Calisthenics Pull-Up Bar", 59.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("42fbcfe9-4372-4c0e-b84d-d19f9fd709a1"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Traditional, durable karate uniform made from high-quality fabric for training and competitions.", "Karate Gi", 64.989999999999995, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("4a9b092a-baa0-4579-94ec-4591f05a4a0a"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Lightweight, yet sturdy parallettes for calisthenics training on the go.", "Portable Parallettes", 44.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("4b109b81-1a53-4fec-accc-3fc3f4565b2a"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.", "High-Performance Running Shoes", 119.98999999999999, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("50f1e82c-320c-445f-98c4-9662a995d7c3"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.", "Performance Cycling Gloves", 29.989999999999998, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("65de2ac7-6fcb-4ca8-9b4c-4627230c32e0"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "A high-quality, adjustable weight dumbbell set for all your strength training needs.", "Professional Dumbbell Set", 199.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("6bb67048-012b-4741-a1cd-cf700b94c66c"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.", "Premium Yoga Mat", 49.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("8967933f-0dfa-4efc-bfa2-766da6c89404"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "High-visibility vest for safe running during early mornings or late evenings.", "Reflective Running Vest", 24.989999999999998, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("89fd7ec6-45d7-4d6c-b348-f545f1518989"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Premium leather boxing gloves designed for maximum protection and performance.", "Boxing Gloves", 79.989999999999995, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("920bb16e-dfcb-48a2-9da6-cae3a4d387ef"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Ergonomically designed handle to improve grip strength and arm wrestling techniques.", "Armwrestling Training Handle", 35.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("adf41bc1-30f0-4d36-b345-7aad77b57340"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Competition-grade armwrestling table with adjustable height and padded surfaces.", "Professional Armwrestling Table", 299.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("f0cda2dc-3bc0-496b-8fda-9b84e9b1c15e"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Versatile snowboard designed for all levels of snowboarding, offering stability and control.", "All-Mountain Snowboard", 399.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") }
                });
        }
    }
}
