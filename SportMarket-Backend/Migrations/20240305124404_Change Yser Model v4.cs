using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportMarket_Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangeYserModelv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1117e6e7-3c30-4ea7-a5de-6307d4f4ae48"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("17f361d3-f60c-46e7-8db5-ba7bfd803cc8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24a34411-7d4e-4a8c-afcf-a157f768c633"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("38f6e5d9-d44c-4a8d-ac65-e84a624092fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e7e2b4e-72a7-438d-85d9-b4c81c92aaf9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91764069-5a93-4f5e-9dd2-c5613f90baf4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("964507d3-9191-4320-9721-1142ca60c8ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9d45b4a7-ce92-40c1-a5ac-3ccff42dff77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b424f888-bbd7-4828-958b-231329a421ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2357f63-1ec8-4738-980d-e1eeb9c2820d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db185ed6-6381-49ba-9c02-7b5b4e4134e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e18b7c36-8a24-4ddf-93a6-3f27a7ccded0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e4e34604-1ace-485e-b37b-120a8a6d3f70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f555dbc8-b6f1-4299-80c0-70c57c7dded8"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductDescription", "ProductName", "ProductPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("00fc85c0-5149-4946-a087-282a77761b59"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Versatile snowboard designed for all levels of snowboarding, offering stability and control.", "All-Mountain Snowboard", 399.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("0a89ce86-2bf7-483c-9b30-bceb3d618e31"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "A high-quality, adjustable weight dumbbell set for all your strength training needs.", "Professional Dumbbell Set", 199.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("1552ac25-91e9-48bf-ac1b-558c90633f0f"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Lightweight, yet sturdy parallettes for calisthenics training on the go.", "Portable Parallettes", 44.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("3751400b-aaf2-43b5-8e36-c56d1244d2b5"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Durable, wall-mounted pull-up bar for various bodyweight exercises.", "Calisthenics Pull-Up Bar", 59.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("445e8abd-125d-4fe0-8153-2678e3a5ceb5"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.", "Thermal Snowboard Jacket", 159.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("51e20156-133e-4093-8c03-2f598988988a"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.", "Premium Yoga Mat", 49.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("5ba8e98b-c421-4fca-8d40-b2d1e3619a6f"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Highly protective and comfortable helmet for mountain biking enthusiasts.", "Mountain Bike Helmet", 89.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("8ae6944e-c7f8-4b31-8ff8-a3ac41e3b287"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "High-visibility vest for safe running during early mornings or late evenings.", "Reflective Running Vest", 24.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("9eb0eee1-bf66-48fa-ac1a-7a353bd10899"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Competition-grade armwrestling table with adjustable height and padded surfaces.", "Professional Armwrestling Table", 299.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("c2a049f2-bd31-4b36-b10e-09388d6f6210"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Premium leather boxing gloves designed for maximum protection and performance.", "Boxing Gloves", 79.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("c50d08fb-17d8-46ad-b2a4-e9dd679d08db"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.", "High-Performance Running Shoes", 119.98999999999999, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("d38c36ce-fa48-4f0d-90b5-8803667c9bf6"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Traditional, durable karate uniform made from high-quality fabric for training and competitions.", "Karate Gi", 64.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("da64f150-ce2a-4370-8488-b780ece659be"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.", "Performance Cycling Gloves", 29.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("e9fbc5b9-c9b7-4dba-9d8a-4912c8b9be44"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Ergonomically designed handle to improve grip strength and arm wrestling techniques.", "Armwrestling Training Handle", 35.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("00fc85c0-5149-4946-a087-282a77761b59"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a89ce86-2bf7-483c-9b30-bceb3d618e31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1552ac25-91e9-48bf-ac1b-558c90633f0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3751400b-aaf2-43b5-8e36-c56d1244d2b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("445e8abd-125d-4fe0-8153-2678e3a5ceb5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51e20156-133e-4093-8c03-2f598988988a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ba8e98b-c421-4fca-8d40-b2d1e3619a6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ae6944e-c7f8-4b31-8ff8-a3ac41e3b287"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9eb0eee1-bf66-48fa-ac1a-7a353bd10899"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c2a049f2-bd31-4b36-b10e-09388d6f6210"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c50d08fb-17d8-46ad-b2a4-e9dd679d08db"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d38c36ce-fa48-4f0d-90b5-8803667c9bf6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da64f150-ce2a-4370-8488-b780ece659be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e9fbc5b9-c9b7-4dba-9d8a-4912c8b9be44"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductDescription", "ProductName", "ProductPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("1117e6e7-3c30-4ea7-a5de-6307d4f4ae48"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Competition-grade armwrestling table with adjustable height and padded surfaces.", "Professional Armwrestling Table", 299.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("17f361d3-f60c-46e7-8db5-ba7bfd803cc8"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "High-visibility vest for safe running during early mornings or late evenings.", "Reflective Running Vest", 24.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("24a34411-7d4e-4a8c-afcf-a157f768c633"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Durable, wall-mounted pull-up bar for various bodyweight exercises.", "Calisthenics Pull-Up Bar", 59.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("38f6e5d9-d44c-4a8d-ac65-e84a624092fd"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.", "Premium Yoga Mat", 49.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("7e7e2b4e-72a7-438d-85d9-b4c81c92aaf9"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.", "High-Performance Running Shoes", 119.98999999999999, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("91764069-5a93-4f5e-9dd2-c5613f90baf4"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Ergonomically designed handle to improve grip strength and arm wrestling techniques.", "Armwrestling Training Handle", 35.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("964507d3-9191-4320-9721-1142ca60c8ec"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Highly protective and comfortable helmet for mountain biking enthusiasts.", "Mountain Bike Helmet", 89.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("9d45b4a7-ce92-40c1-a5ac-3ccff42dff77"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.", "Thermal Snowboard Jacket", 159.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("b424f888-bbd7-4828-958b-231329a421ce"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Premium leather boxing gloves designed for maximum protection and performance.", "Boxing Gloves", 79.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("d2357f63-1ec8-4738-980d-e1eeb9c2820d"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Lightweight, yet sturdy parallettes for calisthenics training on the go.", "Portable Parallettes", 44.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("db185ed6-6381-49ba-9c02-7b5b4e4134e6"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.", "Performance Cycling Gloves", 29.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("e18b7c36-8a24-4ddf-93a6-3f27a7ccded0"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "A high-quality, adjustable weight dumbbell set for all your strength training needs.", "Professional Dumbbell Set", 199.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("e4e34604-1ace-485e-b37b-120a8a6d3f70"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Versatile snowboard designed for all levels of snowboarding, offering stability and control.", "All-Mountain Snowboard", 399.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("f555dbc8-b6f1-4299-80c0-70c57c7dded8"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Traditional, durable karate uniform made from high-quality fabric for training and competitions.", "Karate Gi", 64.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") }
                });
        }
    }
}
