using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SportMarket_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoriesv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("349cec4a-38d7-451b-802b-cef4ce0f2909"), "Runnig" },
                    { new Guid("66eaede8-5121-46cd-896d-e8f76ed1b8c0"), "Snowboard" },
                    { new Guid("9d89386d-8fe2-4b04-9138-c40b5f4b9e0f"), "Armwrestling" },
                    { new Guid("a3067d1f-1870-4afa-b45d-f39f0ed1d91e"), "Gym" },
                    { new Guid("dab3ad41-dd26-4448-9442-e3418c5dc771"), "Biking" },
                    { new Guid("f5956c45-74bc-4e06-8bcc-935c8579d1af"), "Calisthenics" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
