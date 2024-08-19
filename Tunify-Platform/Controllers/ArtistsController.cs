using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tunify_Platform.Data;
using Tunify_Platform.Models;
using Tunify_Platform.Repositories.interfaces;

namespace Tunify_Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IRepository<Artist> _artistRepository;
        private readonly IArtist _artist;

        public ArtistsController(IRepository<Artist> context, IArtist context2)
        {
            _artistRepository = context;
            _artist = context2;
        }

        // GET: api/Artists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Artist>>> Getartist()
        {
            return Ok(await _artistRepository.GetAll());
        }

        // GET: api/Artists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Artist>> GetArtist(int id)
        {
            return Ok(await _artistRepository.GetById(id));
        }

        // PUT: api/Artists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArtist(int id, Artist artist)
        {
            if (id != artist.ID)
            {
                return BadRequest();
            }

            return Ok(await _artistRepository.Update(artist));
        }

        // POST: api/Artists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Artist>> PostArtist(Artist artist)
        {
            var newUser = await _artistRepository.Add(artist);
            return Ok(newUser);
        }

        // DELETE: api/Artists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtist(int id)
        {
            var song = await _artistRepository.GetById(id);
            if (song == null)
            {
                return NotFound();
            }
            await _artistRepository.Delete(id);
            return NoContent();
        }

        // POST api/playlists/{playlistId}/songs/{songId}
        [HttpPost("{playlistId}/songs/{songId}")]
        public async Task<IActionResult> AddPlaylistSong(int artistId, int songId)
        {
            await _artist.AddSongToArtist(artistId, songId);
            return Ok();
        }

        //GET /api/playlists/{playlistId}/songs
        [HttpGet("{playlistId}/songs")]
        public async Task<IActionResult> GetPlaylistSongs(int artistId)
        {
            var songs = await _artist.GetArtistSongs(artistId);
            return Ok(songs);
        }

    }
}
