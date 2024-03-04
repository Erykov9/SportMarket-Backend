using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportMarket_Backend.Migrations
{
    /// <inheritdoc />
    public partial class CreateReadandstaticuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RankName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "RankName", "RankPoints", "Username" },
                values: new object[] { new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b"), "szczepanekeryk@gmail.com", null, 0, "Erykov9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e845efaa-1d29-4851-88c3-bf35a48f816b"));

            migrationBuilder.AlterColumn<string>(
                name: "RankName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
