using Microsoft.EntityFrameworkCore;
using Moq;
using Tunify_Platform.Data;
using Tunify_Platform.Models;
using Tunify_Platform.Repositories.Services;


namespace TunifyTests
{
    public class PlaylistServiceTests
    {
        [Fact]
        public async Task GetSongsInPlaylistAsync_ShouldReturnCorrectSongs()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<TunifyDbContext>()
                .UseInMemoryDatabase(databaseName: "TunifyTestDatabase")
                .Options;

            using (var context = new TunifyDbContext(options))
            {
                context.playlist.Add(new Playlist
                {
                    Id = 1,
                    Playlist_Name = "My Playlist",
                    PlaylistSongs = new List<PlaylistSong>
                {
                    new PlaylistSong
                    {
                        Song = new Song
                        {
                            Id = 1,
                            Title = "Song 1",
                            Artist = new Artist
                            {
                                ID = 1,
                                Name = "Artist 1",
                                Bio = "Bio of Artist 1", // Ensure Bio is set
                            },
                            Album = new Album
                            {
                                ID = 1,
                                Album_Name = "Album 1"
                            },
                            Duration = new TimeSpan(0, 3, 45).ToString(),
                            Gener = "Pop"
                        }
                    },
                    new PlaylistSong
                    {
                        Song = new Song
                        {
                            Id = 2,
                            Title = "Song 2",
                            Artist = new Artist
                            {
                                ID = 2,
                                Name = "Artist 2",
                                Bio = "Bio of Artist 2", // Ensure Bio is set
                            },
                            Album = new Album
                            {
                                ID = 2,
                                Album_Name = "Album 2"
                            },
                            Duration = new TimeSpan(0, 4, 20).ToString(),
                            Gener = "Rock"
                        }
                    }
                }
                });

                await context.SaveChangesAsync();
            }

            using (var context1 = new TunifyDbContext(options))
            {
                var service = new PlaylistService(context1);

                // Act
                var songs = await service.GetPLaylistSongs(1);

                // Assert
                Assert.Equal(2, songs.Count());
                Assert.Contains(songs, s => s.Title == "Song 1");
                Assert.Contains(songs, s => s.Title == "Song 2");
            }
        }
    }
}