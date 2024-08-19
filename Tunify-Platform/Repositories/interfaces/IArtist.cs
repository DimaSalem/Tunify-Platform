using Tunify_Platform.Models;

namespace Tunify_Platform.Repositories.interfaces
{
    public interface IArtist
    {
        Task AddSongToArtist(int ArtistId, int SongId);
        Task<IEnumerable<Song>> GetArtistSongs(int ArtistId);
    }
}
