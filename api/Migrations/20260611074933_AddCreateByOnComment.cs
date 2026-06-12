using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddCreateByOnComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Createby",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Createby",
                value: new DateTime(2026, 6, 11, 14, 49, 33, 670, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Createby",
                value: new DateTime(2026, 6, 11, 14, 49, 33, 670, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Createby",
                value: new DateTime(2026, 6, 11, 14, 49, 33, 670, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Createby",
                value: new DateTime(2026, 6, 11, 14, 49, 33, 670, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Createby",
                value: new DateTime(2026, 6, 11, 14, 49, 33, 670, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Createby",
                value: new DateTime(2026, 6, 11, 14, 49, 33, 670, DateTimeKind.Local).AddTicks(2540));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Createby",
                table: "Comments");
        }
    }
}
