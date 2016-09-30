using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicCompany.Api.Controllers;
using MusicCompany.Api.Models.Albums;
using System.Web.Http;
using System.Web.Http.Results;

namespace MusicCompany.Api.Tests.ControllerTests
{
    [TestClass]
    public class AlbumsControllerTests
    {
        private AlbumsController controller;
        private AlbumResponseModel invalidAlbumModel;

        [TestInitialize]
        public void TestInitialize()
        {
            this.controller = new AlbumsController(TestObjectFactory.GetAlbumsService());
            this.controller.Configuration = new HttpConfiguration();
            this.invalidAlbumModel = TestObjectFactory.GetInvalidAlbumModel();
        }

        [TestMethod]
        public void CreateMethodShouldValidateModelState()
        {
            this.controller.Validate(invalidAlbumModel);
            this.controller.Create(invalidAlbumModel);

            Assert.IsFalse(this.controller.ModelState.IsValid);
        }

        [TestMethod]
        public void CreateMethodShouldReturnBadRequestWithInvalidModelState()
        {
            this.controller.Validate(invalidAlbumModel);
            var response = this.controller.Create(invalidAlbumModel);

            Assert.AreEqual(typeof(InvalidModelStateResult), response.GetType());
        }

        [TestMethod]
        public void CreateMethodShouldAddNewAlbum()
        {

        }
    }
}
