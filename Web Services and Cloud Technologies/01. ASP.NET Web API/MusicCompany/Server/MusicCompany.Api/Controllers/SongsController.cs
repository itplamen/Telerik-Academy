using MusicCompany.Api.Models.Songs;
using MusicCompany.Services.Data;
using MusicCompany.Services.Data.Contracts;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MusicCompany.Api.Controllers
{
    public class SongsController : ApiController
    {
        private readonly ISongsService songs;

        public SongsController(ISongsService songsService)
        {
            this.songs = songsService;
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(SongResponseModel song)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var addedSongId = this.songs.Add(song.Title, song.ReleaseDate, song.Genre, song.AlbumId);

            return this.Ok(song);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult All()
        {
            var songs = this.songs.All()
                .Select(SongResponseModel.FromSong);

            return this.Ok(songs);
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get(int id)
        {
            var song = this.songs.All()
                .Select(SongResponseModel.FromSong)
                .FirstOrDefault(s => s.Id == id);

            if (song == null)
            {
                return this.NotFound();
            }

            return this.Ok(song);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult ByAlbumId(int id)
        {
            var songs = this.songs.All()
                .Select(SongResponseModel.FromSong)
                .Where(s => s.AlbumId == id);

            if (songs == null)
            {
                return this.NotFound();
            }

            return this.Ok(songs);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Update(int id, SongResponseModel song)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var updatedSongId = this.songs.Update(id, song.Title, song.ReleaseDate, song.Genre, song.AlbumId);

            if (updatedSongId == null)
            {
                return this.NotFound();
            }

            return this.Ok(updatedSongId);
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var deletedSongId = this.songs.Delete(id);

            if (deletedSongId == null)
            {
                return this.NotFound();
            }

            return this.Ok(deletedSongId);
        }
    }
}