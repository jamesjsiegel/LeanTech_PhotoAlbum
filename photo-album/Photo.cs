using System.Text.Json.Serialization;

namespace photo_album
{
    public class Photo
    {
        public Photo() { }

        public Photo(
            int albumId,
            int id,
            string title,
            string url,
            string thumbnailUrl)
        {
            AlbumId = albumId;
            Id = id;
            Title = title;
            Url = url;
            ThumbnailUrl = thumbnailUrl;
        }
        
        public int AlbumId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
