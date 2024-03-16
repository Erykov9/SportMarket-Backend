using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportMarket_Backend.Migrations
{
    /// <inheritdoc />
    public partial class renamedcategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                column: "CategoryName",
                value: "Running");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                column: "CategoryName",
                value: "Martial Arts");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductDescription", "ProductName", "ProductPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("1ff5f573-bd44-48dc-b2c8-99178357a9d8"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Competition-grade armwrestling table with adjustable height and padded surfaces.", "Professional Armwrestling Table", 299.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("3d52da27-0a9b-4ed0-bbe3-de26c1f2a211"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Traditional, durable karate uniform made from high-quality fabric for training and competitions.", "Karate Gi", 64.989999999999995, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("57d8fcc3-9021-473c-b8b8-681bbddadadf"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Durable, wall-mounted pull-up bar for various bodyweight exercises.", "Calisthenics Pull-Up Bar", 59.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("64047414-0510-41ff-b83f-06a2042d63dd"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.", "Thermal Snowboard Jacket", 159.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("65508d80-22e9-43ec-9972-0a280de3c090"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "High-visibility vest for safe running during early mornings or late evenings.", "Reflective Running Vest", 24.989999999999998, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("766c50df-cbf3-45fd-a916-77450ab94ef6"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Premium leather boxing gloves designed for maximum protection and performance.", "Boxing Gloves", 79.989999999999995, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("856e1bac-44ed-4ebe-b3be-a09ac4696d7e"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Versatile snowboard designed for all levels of snowboarding, offering stability and control.", "All-Mountain Snowboard", 399.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("98fe818f-c3a7-40f5-851e-7ccb815c749f"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Lightweight, yet sturdy parallettes for calisthenics training on the go.", "Portable Parallettes", 44.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("9a031a56-0979-433e-a3ad-2177c84391da"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Ergonomically designed handle to improve grip strength and arm wrestling techniques.", "Armwrestling Training Handle", 35.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("b0cd24d3-f2f3-44b7-af02-9991cd7ded27"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "A high-quality, adjustable weight dumbbell set for all your strength training needs.", "Professional Dumbbell Set", 199.99000000000001, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("bbf25cf1-11a8-4228-bc02-591a9a044f0b"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.", "Premium Yoga Mat", 49.990000000000002, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("cec57a73-dc83-4fdf-b4ee-4d372c7bcffe"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.", "Performance Cycling Gloves", 29.989999999999998, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("d19f633e-f444-4a76-a8e2-bc04cc81af7f"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Highly protective and comfortable helmet for mountain biking enthusiasts.", "Mountain Bike Helmet", 89.989999999999995, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("de042e94-16fd-49d3-814d-18f72aae2f23"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.", "High-Performance Running Shoes", 119.98999999999999, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1ff5f573-bd44-48dc-b2c8-99178357a9d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d52da27-0a9b-4ed0-bbe3-de26c1f2a211"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("57d8fcc3-9021-473c-b8b8-681bbddadadf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("64047414-0510-41ff-b83f-06a2042d63dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("65508d80-22e9-43ec-9972-0a280de3c090"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("766c50df-cbf3-45fd-a916-77450ab94ef6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("856e1bac-44ed-4ebe-b3be-a09ac4696d7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98fe818f-c3a7-40f5-851e-7ccb815c749f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a031a56-0979-433e-a3ad-2177c84391da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0cd24d3-f2f3-44b7-af02-9991cd7ded27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bbf25cf1-11a8-4228-bc02-591a9a044f0b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cec57a73-dc83-4fdf-b4ee-4d372c7bcffe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d19f633e-f444-4a76-a8e2-bc04cc81af7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de042e94-16fd-49d3-814d-18f72aae2f23"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"),
                column: "CategoryName",
                value: "Runnig");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"),
                column: "CategoryName",
                value: "Material Arts");

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
    }
}
