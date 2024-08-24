using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Data;
using Tunify_Platform.Models;
using Tunify_Platform.Repositories.interfaces;

namespace Tunify_Platform.Repositories.Services
{
    public class PlaylistService : IPlaylist
    {
        private readonly IRepository<Song> _songRepository;
        private readonly IRepository<Playlist> _playlistRepository;
        private readonly TunifyDbContext _context;

        public PlaylistService(TunifyDbContext context)
        {
            _context = context;
            _songRepository = new Repository<Song>(context);
            _playlistRepository = new Repository<Playlist>(context); ;
        }

        public async Task AddPlaylistSong(int PlaylistId, int SongId)
        {
            //var playlist= await _playlistRepository.GetById(PlaylistId);
            var playlist = _context.playlist.FirstOrDefault(x => x.Id == PlaylistId);
            if (playlist == null)
            {
                throw new Exception("Playlist not found");
            }

            var song= await _songRepository.GetById(SongId);
            if (song == null)
            {
                throw new Exception("Song not found");
            }

            playlist.PlaylistSongs.Add(new PlaylistSong { Playlist_ID = PlaylistId, Song_ID = SongId });
            //await _playlistRepository.Update(playlist);
            _context.Entry(playlist).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Song>> GetPLaylistSongs(int PlaylistId)
        {
            
            var playlist = await _context.playlist.Include(x => x.PlaylistSongs).ThenInclude(p => p.Song).FirstOrDefaultAsync(p => p.Id == PlaylistId);
            if (playlist == null)
            {
                throw new Exception("Playlist not found");
            }

            return playlist.PlaylistSongs.Select(ps => ps.Song);
        }
    }
    
}
