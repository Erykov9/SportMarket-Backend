using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportMarket_Backend.Migrations
{
    /// <inheritdoc />
    public partial class ChangeImageandUserModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileUsername",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileUsername",
                table: "Images");
        }
    }
}
