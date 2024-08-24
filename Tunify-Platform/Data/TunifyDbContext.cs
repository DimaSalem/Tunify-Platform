using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Models;

namespace Tunify_Platform.Data
{
    public class TunifyDbContext : IdentityDbContext<IdentityUser>
    {
        public TunifyDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Subscription> subscription { get; set; }
        public DbSet<Song> song { get; set; }
        public DbSet<PlaylistSong> playlistSong { get; set; }
        public DbSet<Playlist> playlist { get; set; }
        public DbSet<Artist> artist { get; set; }
        public DbSet<Album> album { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlaylistSong>().HasKey(ps => new { ps.Playlist_ID, ps.Song_ID });

            modelBuilder.Entity<User>()
                .HasOne(u => u.Subscription)
                .WithOne(s => s.User)
                .HasForeignKey<User>(u => u.Subscription_ID)
                .OnDelete(DeleteBehavior.Restrict); // No cascading delete for Users

            modelBuilder.Entity<Song>()
                .HasOne(s => s.Artist)
                .WithMany(a => a.Songs)
                .HasForeignKey(s => s.Artist_ID)
                .OnDelete(DeleteBehavior.Restrict); // No cascading delete for Songs

            modelBuilder.Entity<Song>()
                .HasOne(s => s.Album)
                .WithMany(a => a.Songs)
                .HasForeignKey(s => s.Album_ID)
                .OnDelete(DeleteBehavior.Restrict); // No cascading delete for Songs

            modelBuilder.Entity<PlaylistSong>()
                .HasOne(ps => ps.Playlist)
                .WithMany(p => p.PlaylistSongs)
                .HasForeignKey(ps => ps.Playlist_ID)
                .OnDelete(DeleteBehavior.Restrict); // No cascading delete for PlaylistSongs

            modelBuilder.Entity<PlaylistSong>()
                .HasOne(ps => ps.Song)
                .WithMany(s => s.PlaylistSongs)
                .HasForeignKey(ps => ps.Song_ID)
                .OnDelete(DeleteBehavior.Restrict); // No cascading delete for PlaylistSongs

            modelBuilder.Entity<Playlist>()
                .HasOne(p => p.User)
                .WithMany(u => u.Playlists)
                .HasForeignKey(p => p.User_ID)
                .OnDelete(DeleteBehavior.Restrict); // No cascading delete for Playlists

            modelBuilder.Entity<Album>()
                .HasOne(a => a.Artist)
                .WithMany(ar => ar.Albums)
                .HasForeignKey(a => a.Artist_ID)
                .OnDelete(DeleteBehavior.Restrict); // No cascading delete for Albums



            // Seed data for Subscription
            modelBuilder.Entity<Subscription>().HasData(
                new Subscription { Id = 1, SubscriptionType = "Free", Price = 0.00 },
                new Subscription { Id = 2, SubscriptionType = "Premium", Price = 9.99 }
            );

            // Seed data for Artist
            modelBuilder.Entity<Artist>().HasData(
                new Artist { ID = 1, Name = "Artist One", Bio = "Bio of Artist One" },
                new Artist { ID = 2, Name = "Artist Two", Bio = "Bio of Artist Two" }
            );

            // Seed data for Album
            modelBuilder.Entity<Album>().HasData(
                new Album { ID = 1, Album_Name = "Album One", Release_Date = new DateTime(2023, 1, 1), Artist_ID = 1 },
                new Album { ID = 2, Album_Name = "Album Two", Release_Date = new DateTime(2023, 2, 1), Artist_ID = 2 }
            );

            // Seed data for Song
            modelBuilder.Entity<Song>().HasData(
                new Song { Id = 1, Title = "Song One", Artist_ID = 1, Album_ID = 1, Duration = "3:45", Gener = "Pop" },
                new Song { Id = 2, Title = "Song Two", Artist_ID = 2, Album_ID = 2, Duration = "4:05", Gener = "Rock" }
               // new Song { Id = 3, Title = "Song three", Artist_ID = 1, Album_ID = 1, Duration = "3:45", Gener = "Pop" },
                //new Song { Id = 4, Title = "Song four", Artist_ID = 2, Album_ID = 2, Duration = "4:05", Gener = "Rock" }
            );

            // Seed data for User
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "user1", Email = "user1@example.com", Join_Date = DateTime.Now, Subscription_ID = 2 },
                new User { Id = 2, UserName = "user2", Email = "user2@example.com", Join_Date = DateTime.Now, Subscription_ID = 1 }
            );

            // Seed data for Playlist
            modelBuilder.Entity<Playlist>().HasData(
                new Playlist { Id = 1, User_ID = 1, Playlist_Name = "User1 Playlist", Created_Date = DateTime.Now },
                new Playlist { Id = 2, User_ID = 2, Playlist_Name = "User2 Playlist", Created_Date = DateTime.Now }
            );

            // Seed data for PlaylistSong
            modelBuilder.Entity<PlaylistSong>().HasData(
                new PlaylistSong { Playlist_ID = 1, Song_ID = 1 },
                new PlaylistSong { Playlist_ID = 2, Song_ID = 2 }
            );
           

            base.OnModelCreating(modelBuilder);

        }
    }

}
