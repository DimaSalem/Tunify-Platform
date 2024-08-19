using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class update_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Subscription_ID",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_playlistSong",
                table: "playlistSong");

            migrationBuilder.DropIndex(
                name: "IX_playlistSong_Playlist_ID",
                table: "playlistSong");

            migrationBuilder.DeleteData(
                table: "playlistSong",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "playlistSong",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "playlistSong");

            migrationBuilder.AddPrimaryKey(
                name: "PK_playlistSong",
                table: "playlistSong",
                columns: new[] { "Playlist_ID", "Song_ID" });

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

            migrationBuilder.InsertData(
                table: "playlistSong",
                columns: new[] { "Playlist_ID", "Song_ID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Subscription_ID",
                table: "User",
                column: "Subscription_ID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Subscription_ID",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_playlistSong",
                table: "playlistSong");

            migrationBuilder.DeleteData(
                table: "playlistSong",
                keyColumns: new[] { "Playlist_ID", "Song_ID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "playlistSong",
                keyColumns: new[] { "Playlist_ID", "Song_ID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "playlistSong",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_playlistSong",
                table: "playlistSong",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                column: "Join_Date",
                value: new DateTime(2024, 8, 9, 0, 18, 24, 907, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                column: "Join_Date",
                value: new DateTime(2024, 8, 9, 0, 18, 24, 907, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created_Date",
                value: new DateTime(2024, 8, 9, 0, 18, 24, 907, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "playlist",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created_Date",
                value: new DateTime(2024, 8, 9, 0, 18, 24, 907, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.InsertData(
                table: "playlistSong",
                columns: new[] { "Id", "Playlist_ID", "Song_ID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_Subscription_ID",
                table: "User",
                column: "Subscription_ID");

            migrationBuilder.CreateIndex(
                name: "IX_playlistSong_Playlist_ID",
                table: "playlistSong",
                column: "Playlist_ID");
        }
    }
}
