﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectMVC.Migrations
{
    /// <inheritdoc />
    public partial class homeprevieww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSelected",
                table: "HomePreviews",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSelected",
                table: "HomePreviews");
        }
    }
}
