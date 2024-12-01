using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectMVC.Migrations
{
    /// <inheritdoc />
    public partial class aboutusw : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrls",
                table: "AboutUsViewModels",
                newName: "ImagePath");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "AboutUsViewModels",
                newName: "ImageUrls");
        }
    }
}
