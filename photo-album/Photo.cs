using System;
using System.Collections.Generic;
using System.Text;

namespace photo_album
{
    public class Photo
    {
        public int AlbumId { get; }
        public int Id { get; }
        public string Title { get; }
        public string Url { get; }
        public string ThumbnailUrl { get; }
    }
}
