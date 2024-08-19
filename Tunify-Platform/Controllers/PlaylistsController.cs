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
    public class PlaylistsController : ControllerBase
    {
        private readonly IRepository<Playlist> _playlistRepository;
        private readonly IPlaylist _playlist;
        public PlaylistsController(IRepository<Playlist> context, IPlaylist context2)
        {
            _playlistRepository = context;
            _playlist = context2;
        }

        // GET: api/Playlists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Playlist>>> Getplaylist()
        {
            return Ok(await _playlistRepository.GetAll());

        }

        // GET: api/Playlists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Playlist>> GetPlaylist(int id)
        {
            return Ok(await _playlistRepository.GetById(id));
        }

        // PUT: api/Playlists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlaylist(int id, Playlist playlist)
        {
            if (id != playlist.Id)
            {
                return BadRequest();
            }

            return Ok(await _playlistRepository.Update(playlist));
        }

        // POST: api/Playlists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Playlist>> PostPlaylist(Playlist playlist)
        {
            var newUser = await _playlistRepository.Add(playlist);
            return Ok(newUser);
        }

        // DELETE: api/Playlists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlaylist(int id)
        {
            var song = await _playlistRepository.GetById(id);
            if (song == null)
            {
                return NotFound();
            }
            await _playlistRepository.Delete(id);
            return NoContent();
        }

        // POST api/playlists/{playlistId}/songs/{songId}
        [HttpPost("{playlistId}/songs/{songId}")]
        public async Task<IActionResult> AddPlaylistSong(int playlistID, int songId)
        {
            await _playlist.AddPlaylistSong(playlistID, songId);
            return Ok();
        }

        //GET /api/playlists/{playlistId}/songs
        [HttpGet("{playlistId}/songs")]
        public async Task<IActionResult> GetPlaylistSongs(int playlistId)
        {
            var songs= await _playlist.GetPLaylistSongs(playlistId);
            return Ok(songs);
        }

    }
}
