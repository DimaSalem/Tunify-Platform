using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class testmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 22, 22, 7, 14, 635, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 22, 22, 7, 14, 635, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 22, 22, 7, 14, 635, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 22, 22, 7, 14, 635, DateTimeKind.Local).AddTicks(9413));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 19, 2, 41, 7, 910, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 19, 2, 41, 7, 910, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 19, 2, 41, 7, 910, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 19, 2, 41, 7, 910, DateTimeKind.Local).AddTicks(636));
        }
    }
}
