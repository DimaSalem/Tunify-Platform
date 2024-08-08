using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "artist",
                columns: new[] { "ID", "Bio", "Name" },
                values: new object[,]
                {
                    { 1, "Bio of Artist One", "Artist One" },
                    { 2, "Bio of Artist Two", "Artist Two" }
                });

            migrationBuilder.InsertData(
                table: "subscription",
                columns: new[] { "Id", "Price", "SubscriptionType" },
                values: new object[,]
                {
                    { 1, 0.0, "Free" },
                    { 2, 9.9900000000000002, "Premium" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "Join_Date", "Subscription_ID", "UserName" },
                values: new object[,]
                {
                    { 1, "user1@example.com", new DateTime(2024, 8, 9, 0, 18, 24, 907, DateTimeKind.Local).AddTicks(649), 2, "user1" },
                    { 2, "user2@example.com", new DateTime(2024, 8, 9, 0, 18, 24, 907, DateTimeKind.Local).AddTicks(667), 1, "user2" }
                });

            migrationBuilder.InsertData(
                table: "album",
                columns: new[] { "ID", "Album_Name", "Artist_ID", "Release_Date" },
                values: new object[,]
                {
                    { 1, "Album One", 1, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Album Two", 2, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "playlist",
                columns: new[] { "Id", "Created_Date", "Playlist_Name", "User_ID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 9, 0, 18, 24, 907, DateTimeKind.Local).AddTicks(679), "User1 Playlist", 1 },
                    { 2, new DateTime(2024, 8, 9, 0, 18, 24, 907, DateTimeKind.Local).AddTicks(680), "User2 Playlist", 2 }
                });

            migrationBuilder.InsertData(
                table: "song",
                columns: new[] { "Id", "Album_ID", "Artist_ID", "Duration", "Gener", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "3:45", "Pop", "Song One" },
                    { 2, 2, 2, "4:05", "Rock", "Song Two" }
                });

            migrationBuilder.InsertData(
                table: "playlistSong",
                columns: new[] { "Id", "Playlist_ID", "Song_ID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "playlistSong",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "playlistSong",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "song",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "song",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "album",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "album",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "artist",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "artist",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "subscription",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "subscription",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
