using System;
using System.Threading.Tasks;
using photo_album;

namespace photo_album_tests
{
    public class MockPhotoRepository : IPhotoRepository
    {
        public Task<Photo[]> List(int albumId)
        {
            Task<Photo[]> result;
            if(albumId == 1)
            {
                result = Task<Photo[]>.Run(() =>
                {
                    return new Photo[3]
                    {
                        new Photo(albumId, 1, "Photo 1", "http://fake.url.123/photo1/600", "http://fake.url.123/photo1/150"),
                        new Photo(albumId, 2, "Photo 2", "http://fake.url.123/photo2/600", "http://fake.url.123/photo2/150"),
                        new Photo(albumId, 3, "Photo 3", "http://fake.url.123/photo3/600", "http://fake.url.123/photo3/150"),
                    };
                });
            }
            else
            {
                result = Task<Photo[]>.Run(() =>
                {
                    return new Photo[0];
                });
            }

            return result;
        }
    }
}
