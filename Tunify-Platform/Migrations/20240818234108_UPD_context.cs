using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class UPD_context : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 19, 1, 51, 12, 515, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 19, 1, 51, 12, 515, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 19, 1, 51, 12, 515, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 19, 1, 51, 12, 515, DateTimeKind.Local).AddTicks(1795));
        }
    }
}
