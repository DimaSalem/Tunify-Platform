using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Models;

namespace Tunify_Platform.Data
{
    public class TunifyDbContext: DbContext
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
        //when overriding any method it has to have the same type of access modifire
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    UserName = "Dima7",
                    Email = "DimaSalem7@gmail.com",
                    Join_Date = new DateTime(2024, 8, 7),
                    Subscription_ID = 1
                }
                );

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Song One",
                    Artist_ID = 1,
                    Album_ID = 1,
                    Duration = "4:00",
                    Gener = "Classic"
                }
                );

            modelBuilder.Entity<Playlist>().HasData(
                new Playlist
                {
                    Id = 1,
                    User_ID = 1, // FK value
                    Playlist_Name = "Classic Playlist",
                    Created_Date = new DateTime(2024, 8, 7)
                }
                );
        }

    }
}
