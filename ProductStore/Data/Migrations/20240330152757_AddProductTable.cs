﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(8, 2)", nullable: false),
                    Category = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Name", "Price" },
                values: new object[,]
                {
                    { 1L, "Watersports", "Kayak", 275m },
                    { 2L, "Watersports", "Lifejacket", 48.95m },
                    { 3L, "Soccer", "Soccer Ball", 19.50m },
                    { 4L, "Soccer", "Corner Flags", 34.95m },
                    { 5L, "Soccer", "Stadium", 79500m },
                    { 6L, "Chess", "Thinking Cap", 16m },
                    { 7L, "Chess", "Unsteady Chair", 29.95m },
                    { 8L, "Chess", "Human Chess Board", 75m },
                    { 9L, "Chess", "Bling-Bling King", 1200m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
