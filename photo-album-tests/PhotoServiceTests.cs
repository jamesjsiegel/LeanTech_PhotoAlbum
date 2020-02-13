using Microsoft.VisualStudio.TestTools.UnitTesting;
using photo_album;
using System;

namespace photo_album_tests
{
    [TestClass]
    public class PhotoServiceTests
    {
        private PhotoService _photoService;

        public PhotoServiceTests()
        {
            var repository = new MockPhotoRepository();
            _photoService = new PhotoService(repository);
        }

        [TestMethod]
        public void GetAlbum_Success()
        {
            var albumId = "1";
            var photos = _photoService.GetAlbum(albumId);
            Assert.IsTrue(photos.Length > 0);
            Assert.IsTrue(photos[0].AlbumId == 1);
        }

        [TestMethod]
        public void GetAlbum_Empty()
        {
            var albumId = "99999";
            var photos = _photoService.GetAlbum(albumId);
            Assert.IsTrue(photos.Length == 0);
        }

        [TestMethod]
        public void GetAlbum_BadArgument()
        {
            var albumId = "x";
            Assert.ThrowsException<ApplicationException>(() =>
            {
                _photoService.GetAlbum(albumId);
            });
        }
    }
}
