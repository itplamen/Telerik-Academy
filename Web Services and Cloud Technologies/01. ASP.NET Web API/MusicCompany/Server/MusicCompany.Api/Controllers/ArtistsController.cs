using MusicCompany.Api.Models.Artists;
using MusicCompany.Models;
using MusicCompany.Services.Data;
using MusicCompany.Services.Data.Contracts;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MusicCompany.Api.Controllers
{
    public class ArtistsController : ApiController
    {
        private IArtistsService artists;

        public ArtistsController(IArtistsService artistsService)
        {
            this.artists = artistsService;
        }

        [HttpPost]
        [Authorize]
        public IHttpActionResult Create(ArtistResponseModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var addedArtistId = this.artists.Add(artist.FullName, artist.Country, artist.DateOfBirth);

            return this.Ok(addedArtistId);
        }

        [HttpGet]
        [EnableCors("*", "*", "*")]
        public IHttpActionResult All()
        {
            var artists = this.artists.All()
                .Select(ArtistResponseModel.FromArtist);

            return this.Ok(artists);
        }

        [EnableCors("*", "*", "*")]
        public IHttpActionResult Get(int id)
        {
            var artist = this.artists.All()
                .Select(ArtistResponseModel.FromArtist)
                .First(a => a.Id == id);

            if (artist == null)
            {
                return this.NotFound();
            }

            return this.Ok(artist);
        }

        [HttpPut]
        [Authorize]
        public IHttpActionResult Update(int id, ArtistResponseModel artist)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var updatedArtistId = this.artists.Update(id, artist.FullName, artist.Country, artist.DateOfBirth);

            if (updatedArtistId == null)
            {
                return this.NotFound();
            }
            
            return this.Ok(updatedArtistId);
        }

        [HttpDelete]
        [Authorize]
        public IHttpActionResult Delete(int id)
        {
            var deletedArtistId = this.artists.Delete(id);

            if (deletedArtistId == null)
            {
                return this.NotFound();
            }

            return this.Ok(deletedArtistId);
        }
    }
}