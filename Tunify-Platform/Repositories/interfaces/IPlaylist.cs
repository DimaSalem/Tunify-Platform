using Tunify_Platform.Models;

namespace Tunify_Platform.Repositories.interfaces
{
    public interface IPlaylist
    {
        Task AddPlaylistSong(int PlaylistId, int SongId);
        Task<IEnumerable<Song>> GetPLaylistSongs(int PlaylistId);

    }
}
