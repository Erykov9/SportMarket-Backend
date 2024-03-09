using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportMarket_Backend.Migrations
{
    /// <inheritdoc />
    public partial class fixforProductDTOv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductDescription", "ProductName", "ProductPrice", "UserId" },
                values: new object[,]
                {
                    { new Guid("0902afc5-ac35-4c13-861a-f63e442fbf31"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Breathable, shock-absorbing gloves for enhanced grip and comfort during long rides.", "Performance Cycling Gloves", 29.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("0ee98b08-abb3-4c96-baf5-e999bae12112"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Lightweight, yet sturdy parallettes for calisthenics training on the go.", "Portable Parallettes", 44.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("0f71db16-d41c-4b4b-a278-e6e47cc36cb2"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Versatile snowboard designed for all levels of snowboarding, offering stability and control.", "All-Mountain Snowboard", 399.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("20ccba12-b4d0-4c1c-8912-a1143911223d"), new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Durable, wall-mounted pull-up bar for various bodyweight exercises.", "Calisthenics Pull-Up Bar", 59.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("41ca796e-0a86-40d6-b611-06263f320036"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Traditional, durable karate uniform made from high-quality fabric for training and competitions.", "Karate Gi", 64.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("43a2bf49-0467-4962-9209-51236f593b4e"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Ergonomically designed handle to improve grip strength and arm wrestling techniques.", "Armwrestling Training Handle", 35.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("4466130f-d1c2-4caf-bc39-4008c700275a"), new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Waterproof and windproof jacket with thermal insulation to keep you warm on the slopes.", "Thermal Snowboard Jacket", 159.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("4cfedb10-f7e9-48fb-a3ad-1a4844e418b1"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "A high-quality, adjustable weight dumbbell set for all your strength training needs.", "Professional Dumbbell Set", 199.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("829611e6-dc82-47c6-a8b7-95a10853182f"), new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Highly protective and comfortable helmet for mountain biking enthusiasts.", "Mountain Bike Helmet", 89.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("8673e1dc-8b96-4e2b-9bbb-994f4ea86d65"), new Guid("e70f2319-cf3e-4384-bd8e-101e23d9d8c3"), "Premium leather boxing gloves designed for maximum protection and performance.", "Boxing Gloves", 79.989999999999995, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("8ddcffee-c27d-401a-8d07-7ab4c2d4f6b7"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "High-visibility vest for safe running during early mornings or late evenings.", "Reflective Running Vest", 24.989999999999998, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("b4b3c47a-f5d0-43b0-8593-a8d2f0407394"), new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "Eco-friendly, non-slip yoga mat designed for ultimate comfort and stability.", "Premium Yoga Mat", 49.990000000000002, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("e3194912-b598-424b-9d8e-4cea8a9bffcc"), new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "Lightweight, durable running shoes with exceptional cushioning for long-distance runs.", "High-Performance Running Shoes", 119.98999999999999, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") },
                    { new Guid("f28a62d6-7e3f-42fa-9e20-c09438998775"), new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Competition-grade armwrestling table with adjustable height and padded surfaces.", "Professional Armwrestling Table", 299.99000000000001, new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("0902afc5-ac35-4c13-861a-f63e442fbf31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ee98b08-abb3-4c96-baf5-e999bae12112"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0f71db16-d41c-4b4b-a278-e6e47cc36cb2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20ccba12-b4d0-4c1c-8912-a1143911223d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41ca796e-0a86-40d6-b611-06263f320036"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43a2bf49-0467-4962-9209-51236f593b4e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4466130f-d1c2-4caf-bc39-4008c700275a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4cfedb10-f7e9-48fb-a3ad-1a4844e418b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("829611e6-dc82-47c6-a8b7-95a10853182f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8673e1dc-8b96-4e2b-9bbb-994f4ea86d65"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ddcffee-c27d-401a-8d07-7ab4c2d4f6b7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4b3c47a-f5d0-43b0-8593-a8d2f0407394"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3194912-b598-424b-9d8e-4cea8a9bffcc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f28a62d6-7e3f-42fa-9e20-c09438998775"));

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
    }
}
