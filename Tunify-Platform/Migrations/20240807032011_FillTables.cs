using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class FillTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Join_Date", "Subscription_ID", "UserName" },
                values: new object[] { 1, "DimaSalem7@gmail.com", new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Dima7" });

            migrationBuilder.InsertData(
                table: "playlist",
                columns: new[] { "Id", "Created_Date", "Playlist_Name", "User_ID" },
                values: new object[] { 1, new DateTime(2024, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Classic Playlist", 1 });

            migrationBuilder.InsertData(
                table: "song",
                columns: new[] { "Id", "Album_ID", "Artist_ID", "Duration", "Gener", "Title" },
                values: new object[] { 1, 1, 1, "4:00", "Classic", "Song One" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "song",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
