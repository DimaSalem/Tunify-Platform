using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Data;
using Tunify_Platform.Models;
using Tunify_Platform.Repositories.interfaces;

namespace Tunify_Platform.Repositories.Services
{
    public class ArtistService : IArtist
    {
        private readonly IRepository<Song> _songRepository;
        private readonly IRepository<Artist> _artistRepository;
        private readonly TunifyDbContext _context;

        public ArtistService(TunifyDbContext context, IRepository<Song> songRepository,
           IRepository<Artist> artistRepository)
        {
            _context = context;
            _songRepository = songRepository;
            _artistRepository = artistRepository;
        }
        public async Task AddSongToArtist(int ArtistId, int SongId)
        {
            var Artist = await _artistRepository.GetById(ArtistId);
            if (Artist == null)
            {
                throw new Exception("Artist not found");
            }

            var song = await _songRepository.GetById(SongId);
            if (song == null)
            {
                throw new Exception("Song not found");
            }

            Artist.Songs.Add(song);
            await _artistRepository.Update(Artist);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Song>> GetArtistSongs(int ArtistId)
        {
            var Artist = await _context.artist.Include(a => a.Songs).FirstOrDefaultAsync(a => a.ID == ArtistId);
            if (Artist == null)
            {
                throw new Exception("Artist not found");
            }

            return Artist.Songs;
        }
    }
}
