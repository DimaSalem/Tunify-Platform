﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tunify_Platform.Data;

#nullable disable

namespace Tunify_Platform.Migrations
{
    [DbContext(typeof(TunifyDbContext))]
    [Migration("20240818225112_update_model")]
    partial class update_model
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Tunify_Platform.Models.Album", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Album_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Artist_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Release_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("Artist_ID");

                    b.ToTable("album");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Album_Name = "Album One",
                            Artist_ID = 1,
                            Release_Date = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ID = 2,
                            Album_Name = "Album Two",
                            Artist_ID = 2,
                            Release_Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Models.Artist", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("artist");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Bio = "Bio of Artist One",
                            Name = "Artist One"
                        },
                        new
                        {
                            ID = 2,
                            Bio = "Bio of Artist Two",
                            Name = "Artist Two"
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Models.Playlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Playlist_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("playlist");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created_Date = new DateTime(2024, 8, 19, 1, 51, 12, 515, DateTimeKind.Local).AddTicks(1793),
                            Playlist_Name = "User1 Playlist",
                            User_ID = 1
                        },
                        new
                        {
                            Id = 2,
                            Created_Date = new DateTime(2024, 8, 19, 1, 51, 12, 515, DateTimeKind.Local).AddTicks(1795),
                            Playlist_Name = "User2 Playlist",
                            User_ID = 2
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Models.PlaylistSong", b =>
                {
                    b.Property<int>("Playlist_ID")
                        .HasColumnType("int");

                    b.Property<int>("Song_ID")
                        .HasColumnType("int");

                    b.HasKey("Playlist_ID", "Song_ID");

                    b.HasIndex("Song_ID");

                    b.ToTable("playlistSong");

                    b.HasData(
                        new
                        {
                            Playlist_ID = 1,
                            Song_ID = 1
                        },
                        new
                        {
                            Playlist_ID = 2,
                            Song_ID = 2
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Album_ID")
                        .HasColumnType("int");

                    b.Property<int>("Artist_ID")
                        .HasColumnType("int");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gener")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Album_ID");

                    b.HasIndex("Artist_ID");

                    b.ToTable("song");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album_ID = 1,
                            Artist_ID = 1,
                            Duration = "3:45",
                            Gener = "Pop",
                            Title = "Song One"
                        },
                        new
                        {
                            Id = 2,
                            Album_ID = 2,
                            Artist_ID = 2,
                            Duration = "4:05",
                            Gener = "Rock",
                            Title = "Song Two"
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Models.Subscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("SubscriptionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("subscription");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 0.0,
                            SubscriptionType = "Free"
                        },
                        new
                        {
                            Id = 2,
                            Price = 9.9900000000000002,
                            SubscriptionType = "Premium"
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Join_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Subscription_ID")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Subscription_ID")
                        .IsUnique();

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "user1@example.com",
                            Join_Date = new DateTime(2024, 8, 19, 1, 51, 12, 515, DateTimeKind.Local).AddTicks(1761),
                            Subscription_ID = 2,
                            UserName = "user1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "user2@example.com",
                            Join_Date = new DateTime(2024, 8, 19, 1, 51, 12, 515, DateTimeKind.Local).AddTicks(1775),
                            Subscription_ID = 1,
                            UserName = "user2"
                        });
                });

            modelBuilder.Entity("Tunify_Platform.Models.Album", b =>
                {
                    b.HasOne("Tunify_Platform.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("Artist_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("Tunify_Platform.Models.Playlist", b =>
                {
                    b.HasOne("Tunify_Platform.Models.User", "User")
                        .WithMany("Playlists")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Tunify_Platform.Models.PlaylistSong", b =>
                {
                    b.HasOne("Tunify_Platform.Models.Playlist", "Playlist")
                        .WithMany("PlaylistSongs")
                        .HasForeignKey("Playlist_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Tunify_Platform.Models.Song", "Song")
                        .WithMany("PlaylistSongs")
                        .HasForeignKey("Song_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Playlist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Tunify_Platform.Models.Song", b =>
                {
                    b.HasOne("Tunify_Platform.Models.Album", "Album")
                        .WithMany("Songs")
                        .HasForeignKey("Album_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Tunify_Platform.Models.Artist", "Artist")
                        .WithMany("Songs")
                        .HasForeignKey("Artist_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("Tunify_Platform.Models.User", b =>
                {
                    b.HasOne("Tunify_Platform.Models.Subscription", "Subscription")
                        .WithOne("User")
                        .HasForeignKey("Tunify_Platform.Models.User", "Subscription_ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("Tunify_Platform.Models.Album", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Tunify_Platform.Models.Artist", b =>
                {
                    b.Navigation("Albums");

                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Tunify_Platform.Models.Playlist", b =>
                {
                    b.Navigation("PlaylistSongs");
                });

            modelBuilder.Entity("Tunify_Platform.Models.Song", b =>
                {
                    b.Navigation("PlaylistSongs");
                });

            modelBuilder.Entity("Tunify_Platform.Models.Subscription", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });

            modelBuilder.Entity("Tunify_Platform.Models.User", b =>
                {
                    b.Navigation("Playlists");
                });
#pragma warning restore 612, 618
        }
    }
}
