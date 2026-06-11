using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData_second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedOn", "StockId", "Title" },
                values: new object[] { 2, "Google is investing heavily in artificial intelligence.", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Strong AI Business" });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "CompanyName", "Industry", "LastDiv", "MarketCap", "Purchase", "Symbol" },
                values: new object[,]
                {
                    { 3, "Microsoft Corporation", "Technology", 3.00m, 3100000L, 420.75m, "MSFT" },
                    { 4, "Amazon.com Inc.", "E-Commerce", 0m, 1900000L, 185.40m, "AMZN" },
                    { 5, "Tesla Inc.", "Automotive", 0m, 850000L, 240.25m, "TSLA" },
                    { 6, "Meta Platforms Inc.", "Technology", 2.00m, 1300000L, 510.60m, "META" },
                    { 7, "NVIDIA Corporation", "Semiconductors", 0.16m, 3200000L, 890.45m, "NVDA" },
                    { 8, "JPMorgan Chase & Co.", "Banking", 4.20m, 600000L, 210.80m, "JPM" },
                    { 9, "Visa Inc.", "Financial Services", 2.08m, 550000L, 290.15m, "V" },
                    { 10, "The Coca-Cola Company", "Beverages", 1.94m, 270000L, 62.90m, "KO" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedOn", "StockId", "Title" },
                values: new object[,]
                {
                    { 3, "Azure remains a major growth driver for Microsoft.", new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Cloud Leader" },
                    { 4, "Amazon dominates online retail worldwide.", new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "E-commerce Giant" },
                    { 5, "Tesla stock remains highly volatile but promising.", new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Volatile Stock" },
                    { 6, "Meta's advertising business is recovering strongly.", new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Social Media Powerhouse" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
