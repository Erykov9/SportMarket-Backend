using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportMarket_Backend.Migrations
{
    /// <inheritdoc />
    public partial class fixforProductDTOtabledatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_ProductDTO_ProductDTOId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "ProductDTO");

            migrationBuilder.DropIndex(
                name: "IX_Images_ProductDTOId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1185c131-f821-4f56-9bb2-81028ab0a25b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13a86834-ec1e-46e3-94ab-dba9edb71005"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26788bb7-7423-46fd-98c7-4c881e29107a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a7eb8ce-b0d4-4150-b49b-58354ad7963f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5b57fc16-f488-4893-a7e2-5c1055429ba6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61459ff4-9c6c-43ed-bafb-876cb8b59bd6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("632a1f91-1ce8-4be5-a441-5362a7b51809"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6854046c-fe8c-43d1-9359-dc84bcc27522"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c4fc9e4-00f8-46a8-8e97-0151af484c8a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6ed860b5-cd90-4e3b-bad4-ce889b520553"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7932c9af-1dc8-4f6e-b15b-fdc9e399e550"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79c0898c-ffdd-4bbc-82da-0b4472c148c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8e65738b-9723-4dcb-ab88-1d8af22d911e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ab6d886e-78b1-4ad9-9517-2645d40b19a9"));

            migrationBuilder.DropColumn(
                name: "ProductDTOId",
                table: "Images");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductDescription", "ProductName", "ProductPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("19680a44-48cb-450d-84d3-2145aded821f"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.", "High-Performance Running Shoes", 119.98999999999999, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("1c84d6f3-275c-422d-a260-5226c1323012"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Competition-grade armwrestling table with adjustable height and padded surfaces.", "Professional Armwrestling Table", 299.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("1cd74496-81c9-4c81-8117-9bf880872691"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.", "Thermal Snowboard Jacket", 159.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("433812a6-1fcc-47d2-9c72-6bd11896d1fd"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Highly protective and comfortable helmet for mountain biking enthusiasts.", "Mountain Bike Helmet", 89.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("462b0019-bc8a-47d6-845c-8d4a9d41ff6d"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Durable, wall-mounted pull-up bar for various bodyweight exercises.", "Calisthenics Pull-Up Bar", 59.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("4dda5a63-bdc0-465c-b610-65beed9d90f5"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Premium leather boxing gloves designed for maximum protection and performance.", "Boxing Gloves", 79.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("6949af1c-b1d7-4a5e-be13-ff22923b4474"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Ergonomically designed handle to improve grip strength and arm wrestling techniques.", "Armwrestling Training Handle", 35.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("6edde677-a5ae-481f-b860-3ee3f306197a"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Lightweight, yet sturdy parallettes for calisthenics training on the go.", "Portable Parallettes", 44.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("9cc436b0-99b0-4b84-9193-0771f513f4a0"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "A high-quality, adjustable weight dumbbell set for all your strength training needs.", "Professional Dumbbell Set", 199.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("c68f3fd0-3a4b-40ad-b3ff-910fabc7f227"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Traditional, durable karate uniform made from high-quality fabric for training and competitions.", "Karate Gi", 64.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("da31e21c-a34f-48b8-9bfb-851f58959d7b"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Versatile snowboard designed for all levels of snowboarding, offering stability and control.", "All-Mountain Snowboard", 399.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("e72ca759-6db0-4869-885e-1654f079ef49"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.", "Performance Cycling Gloves", 29.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("f25dd779-e4d5-46f8-8c7a-4ac15cdda5a5"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.", "Premium Yoga Mat", 49.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("f5aab8ab-e1ee-451f-9769-70cce87d67e9"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "High-visibility vest for safe running during early mornings or late evenings.", "Reflective Running Vest", 24.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("19680a44-48cb-450d-84d3-2145aded821f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1c84d6f3-275c-422d-a260-5226c1323012"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1cd74496-81c9-4c81-8117-9bf880872691"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("433812a6-1fcc-47d2-9c72-6bd11896d1fd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("462b0019-bc8a-47d6-845c-8d4a9d41ff6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4dda5a63-bdc0-465c-b610-65beed9d90f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6949af1c-b1d7-4a5e-be13-ff22923b4474"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6edde677-a5ae-481f-b860-3ee3f306197a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9cc436b0-99b0-4b84-9193-0771f513f4a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c68f3fd0-3a4b-40ad-b3ff-910fabc7f227"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da31e21c-a34f-48b8-9bfb-851f58959d7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e72ca759-6db0-4869-885e-1654f079ef49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f25dd779-e4d5-46f8-8c7a-4ac15cdda5a5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5aab8ab-e1ee-451f-9769-70cce87d67e9"));

            migrationBuilder.AddColumn<Guid>(
                name: "ProductDTOId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductDTO",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDTO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDTO_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDTO_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductDescription", "ProductName", "ProductPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("1185c131-f821-4f56-9bb2-81028ab0a25b"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.", "Performance Cycling Gloves", 29.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("13a86834-ec1e-46e3-94ab-dba9edb71005"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Premium leather boxing gloves designed for maximum protection and performance.", "Boxing Gloves", 79.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("26788bb7-7423-46fd-98c7-4c881e29107a"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Durable, wall-mounted pull-up bar for various bodyweight exercises.", "Calisthenics Pull-Up Bar", 59.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("3a7eb8ce-b0d4-4150-b49b-58354ad7963f"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Competition-grade armwrestling table with adjustable height and padded surfaces.", "Professional Armwrestling Table", 299.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("5b57fc16-f488-4893-a7e2-5c1055429ba6"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.", "Premium Yoga Mat", 49.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("61459ff4-9c6c-43ed-bafb-876cb8b59bd6"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "High-visibility vest for safe running during early mornings or late evenings.", "Reflective Running Vest", 24.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("632a1f91-1ce8-4be5-a441-5362a7b51809"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Versatile snowboard designed for all levels of snowboarding, offering stability and control.", "All-Mountain Snowboard", 399.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("6854046c-fe8c-43d1-9359-dc84bcc27522"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Traditional, durable karate uniform made from high-quality fabric for training and competitions.", "Karate Gi", 64.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("6c4fc9e4-00f8-46a8-8e97-0151af484c8a"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Lightweight, yet sturdy parallettes for calisthenics training on the go.", "Portable Parallettes", 44.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("6ed860b5-cd90-4e3b-bad4-ce889b520553"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "A high-quality, adjustable weight dumbbell set for all your strength training needs.", "Professional Dumbbell Set", 199.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("7932c9af-1dc8-4f6e-b15b-fdc9e399e550"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Highly protective and comfortable helmet for mountain biking enthusiasts.", "Mountain Bike Helmet", 89.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("79c0898c-ffdd-4bbc-82da-0b4472c148c6"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.", "High-Performance Running Shoes", 119.98999999999999, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("8e65738b-9723-4dcb-ab88-1d8af22d911e"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Ergonomically designed handle to improve grip strength and arm wrestling techniques.", "Armwrestling Training Handle", 35.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("ab6d886e-78b1-4ad9-9517-2645d40b19a9"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.", "Thermal Snowboard Jacket", 159.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductDTOId",
                table: "Images",
                column: "ProductDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDTO_CategoryId",
                table: "ProductDTO",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDTO_UserId",
                table: "ProductDTO",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_ProductDTO_ProductDTOId",
                table: "Images",
                column: "ProductDTOId",
                principalTable: "ProductDTO",
                principalColumn: "Id");
        }
    }
}
