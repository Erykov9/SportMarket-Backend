using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportMarket_Backend.Migrations
{
    /// <inheritdoc />
    public partial class addnewkeystoproductMODEL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Location", "ProductDescription", "ProductName", "ProductPrice", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("01796196-33a1-4909-8663-a6bb4a14b228"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piotrków Trybunalski", "Durable, wall-mounted pull-up bar for various bodyweight exercises.", "Calisthenics Pull-Up Bar", 59.990000000000002, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("1266c2c7-cb82-4076-aa57-4cbd1a870709"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrocław", "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.", "Thermal Snowboard Jacket", 159.99000000000001, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("15541d2c-0df0-412f-b5d3-8c76069562ec"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrocław", "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.", "Premium Yoga Mat", 49.990000000000002, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("2e178aea-e8d0-4143-91e1-b7fde755fb63"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrocław", "High-visibility vest for safe running during early mornings or late evenings.", "Reflective Running Vest", 24.989999999999998, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("2ff5ddaa-4fb3-4628-b7db-201de29868c2"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrocław", "Traditional, durable karate uniform made from high-quality fabric for training and competitions.", "Karate Gi", 64.989999999999995, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("3803a535-4ba2-453a-8707-b957588e515c"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrocław", "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.", "High-Performance Running Shoes", 119.98999999999999, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("4a1fafcc-c989-4c16-97a2-a035c835d654"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), new DateTime(2024, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kalisz", "Highly protective and comfortable helmet for mountain biking enthusiasts.", "Mountain Bike Helmet", 89.989999999999995, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("5a62377a-6553-4c65-a68e-db97b177976e"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Legnica", "Competition-grade armwrestling table with adjustable height and padded surfaces.", "Professional Armwrestling Table", 299.99000000000001, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("5ac022b8-7b0c-4a8a-9c33-1b05c218aad1"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrocław", "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.", "Performance Cycling Gloves", 29.989999999999998, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("5b156077-066b-4ee9-aec6-920d602589d6"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrocław", "A high-quality, adjustable weight dumbbell set for all your strength training needs.", "Professional Dumbbell Set", 199.99000000000001, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("8138d1df-8b6f-4b57-8819-f2a0e0494fcb"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kraków", "Ergonomically designed handle to improve grip strength and arm wrestling techniques.", "Armwrestling Training Handle", 35.990000000000002, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("98d6fb83-b19c-4555-82f4-bb15de4e2dcc"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrocław", "Premium leather boxing gloves designed for maximum protection and performance.", "Boxing Gloves", 79.989999999999995, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("ae0df983-bd2f-4499-9a23-e1a3499122b3"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), new DateTime(2024, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piotrków Trybunalski", "Lightweight, yet sturdy parallettes for calisthenics training on the go.", "Portable Parallettes", 44.990000000000002, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") },
                    { new Guid("f257f422-3b60-4555-b960-03edb082fab1"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), new DateTime(2024, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wrocław", "Versatile snowboard designed for all levels of snowboarding, offering stability and control.", "All-Mountain Snowboard", 399.99000000000001, null, new Guid("a3067d1f-1870-4afa-b45d-a39f0ed1d91e") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01796196-33a1-4909-8663-a6bb4a14b228"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1266c2c7-cb82-4076-aa57-4cbd1a870709"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("15541d2c-0df0-412f-b5d3-8c76069562ec"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2e178aea-e8d0-4143-91e1-b7fde755fb63"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ff5ddaa-4fb3-4628-b7db-201de29868c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3803a535-4ba2-453a-8707-b957588e515c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a1fafcc-c989-4c16-97a2-a035c835d654"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5a62377a-6553-4c65-a68e-db97b177976e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5ac022b8-7b0c-4a8a-9c33-1b05c218aad1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b156077-066b-4ee9-aec6-920d602589d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8138d1df-8b6f-4b57-8819-f2a0e0494fcb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98d6fb83-b19c-4555-82f4-bb15de4e2dcc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ae0df983-bd2f-4499-9a23-e1a3499122b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f257f422-3b60-4555-b960-03edb082fab1"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Products");

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
    }
}
