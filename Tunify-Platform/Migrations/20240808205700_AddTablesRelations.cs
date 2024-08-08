using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tunify_Platform.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_User_Subscription_ID",
                table: "User",
                column: "Subscription_ID");

            migrationBuilder.CreateIndex(
                name: "IX_song_Album_ID",
                table: "song",
                column: "Album_ID");

            migrationBuilder.CreateIndex(
                name: "IX_song_Artist_ID",
                table: "song",
                column: "Artist_ID");

            migrationBuilder.CreateIndex(
                name: "IX_playlistSong_Playlist_ID",
                table: "playlistSong",
                column: "Playlist_ID");

            migrationBuilder.CreateIndex(
                name: "IX_playlistSong_Song_ID",
                table: "playlistSong",
                column: "Song_ID");

            migrationBuilder.CreateIndex(
                name: "IX_playlist_User_ID",
                table: "playlist",
                column: "User_ID");

            migrationBuilder.CreateIndex(
                name: "IX_album_Artist_ID",
                table: "album",
                column: "Artist_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_album_artist_Artist_ID",
                table: "album",
                column: "Artist_ID",
                principalTable: "artist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_playlist_User_User_ID",
                table: "playlist",
                column: "User_ID",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_playlistSong_playlist_Playlist_ID",
                table: "playlistSong",
                column: "Playlist_ID",
                principalTable: "playlist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_playlistSong_song_Song_ID",
                table: "playlistSong",
                column: "Song_ID",
                principalTable: "song",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_song_album_Album_ID",
                table: "song",
                column: "Album_ID",
                principalTable: "album",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_song_artist_Artist_ID",
                table: "song",
                column: "Artist_ID",
                principalTable: "artist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_subscription_Subscription_ID",
                table: "User",
                column: "Subscription_ID",
                principalTable: "subscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_album_artist_Artist_ID",
                table: "album");

            migrationBuilder.DropForeignKey(
                name: "FK_playlist_User_User_ID",
                table: "playlist");

            migrationBuilder.DropForeignKey(
                name: "FK_playlistSong_playlist_Playlist_ID",
                table: "playlistSong");

            migrationBuilder.DropForeignKey(
                name: "FK_playlistSong_song_Song_ID",
                table: "playlistSong");

            migrationBuilder.DropForeignKey(
                name: "FK_song_album_Album_ID",
                table: "song");

            migrationBuilder.DropForeignKey(
                name: "FK_song_artist_Artist_ID",
                table: "song");

            migrationBuilder.DropForeignKey(
                name: "FK_User_subscription_Subscription_ID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_Subscription_ID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_song_Album_ID",
                table: "song");

            migrationBuilder.DropIndex(
                name: "IX_song_Artist_ID",
                table: "song");

            migrationBuilder.DropIndex(
                name: "IX_playlistSong_Playlist_ID",
                table: "playlistSong");

            migrationBuilder.DropIndex(
                name: "IX_playlistSong_Song_ID",
                table: "playlistSong");

            migrationBuilder.DropIndex(
                name: "IX_playlist_User_ID",
                table: "playlist");

            migrationBuilder.DropIndex(
                name: "IX_album_Artist_ID",
                table: "album");

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
    }
}
