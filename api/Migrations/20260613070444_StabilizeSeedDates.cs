using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class StabilizeSeedDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b5a9c24e-7582-3b2a-82d7-4a3c887f3310", "1a8e72d9-3066-4b28-8e79-bfd36a1d7f45", "User", "USER" },
                    { "c3f8b13d-8693-4a3b-93e8-5b4d998a4421", "8b9d4f8b-9a44-4b7e-8d2d-2d4ea2a6f6a1", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b5a9c24e-7582-3b2a-82d7-4a3c887f3310");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3f8b13d-8693-4a3b-93e8-5b4d998a4421");
        }
    }
}
