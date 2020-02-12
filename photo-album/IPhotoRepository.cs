using System.Threading.Tasks;

namespace photo_album
{
    public interface IPhotoRepository
    {
        public Task<Photo[]> List(int albumId);
    }
}
