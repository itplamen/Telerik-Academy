using MusicCompany.Services.Data.Contracts;
using Moq;
using System;
using MusicCompany.Api.Models.Albums;

namespace MusicCompany.Api.Tests
{
    public static class TestObjectFactory
    {
        public static IAlbumsService GetAlbumsService()
        {
            var albumsService = new Mock<IAlbumsService>();
            albumsService.Setup(a => a.Add(It.IsAny<string>(), It.IsAny<DateTime?>(), It.IsAny<string>())).Returns(1);

            return albumsService.Object;
        }

        public static AlbumResponseModel GetInvalidAlbumModel()
        {
            return new AlbumResponseModel
            {
                Title = "Some title"
            };
        }
    }
}
