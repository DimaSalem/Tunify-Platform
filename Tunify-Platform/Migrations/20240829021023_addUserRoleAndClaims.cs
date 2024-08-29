using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class addUserRoleAndClaims : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", null, "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 29, 5, 10, 23, 693, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 29, 5, 10, 23, 693, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 29, 5, 10, 23, 693, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 29, 5, 10, 23, 693, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.InsertData(
                table: "AspNetRoleClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "RoleId" },
                values: new object[] { 1, "Permission", "CanEdit", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "2c9ff0db-8008-4eec-8f71-c232725247e2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "2c9ff0db-8008-4eec-8f71-c232725247e2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 24, 6, 15, 18, 24, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 24, 6, 15, 18, 24, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 24, 6, 15, 18, 24, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 24, 6, 15, 18, 24, DateTimeKind.Local).AddTicks(1551));
        }
    }
}
