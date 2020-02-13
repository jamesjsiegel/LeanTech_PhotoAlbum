using System;

namespace photo_album
{
    public class PhotoService
    {
        IPhotoRepository _albumRepository;
        public PhotoService(IPhotoRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public Photo[] GetAlbum(string idParam)
        {
            int albumId;
            var valid = int.TryParse(idParam, out albumId);
            if(!valid)
            {
                throw new ApplicationException(ErrorMessages.ERR_INVALID_ARGUMENT);
            }
            
            var album = _albumRepository.List(albumId).Result;
            return album;
        }
    }
}
