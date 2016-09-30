using MusicCompany.Api.Models.Albums;
using MusicCompany.Models;
using MusicCompany.Services.Data;
using MusicCompany.Services.Data.Contracts;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MusicCompany.Api.Controllers
{
    public class AlbumsController : ApiController
    {
        private IAlbumsService albums;

        public AlbumsController(IAlbumsService albumsService)
        {
            this.albums = albumsService;
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(AlbumResponseModel album)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var addedAlbumId = this.albums.Add(album.Title, album.ReleaseDate, album.Producer);

            return this.Ok(addedAlbumId);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult All()
        {
            var albums = this.albums.All()
                .Select(AlbumResponseModel.FromAlbum);

            return this.Ok(albums);
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get(int id)
        {
            var album = this.albums.All()
                .Select(AlbumResponseModel.FromAlbum)
                .FirstOrDefault(a => a.Id == id);

            return this.Ok(album);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Update(int id, AlbumResponseModel album)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var existingAlbumId = this.albums.Update(id, album.Title, album.ReleaseDate, album.Producer);

            if (existingAlbumId == null)
            {
                return this.NotFound();
            }

            return this.Ok(existingAlbumId);
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var deletedAlbumId = this.albums.Delete(id);

            if (deletedAlbumId == null)
            {
                return this.NotFound();
            }

            return this.Ok(deletedAlbumId);
        }
    }
}