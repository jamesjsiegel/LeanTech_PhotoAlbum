using System;
using System.Collections.Generic;
using System.Text;

namespace photo_album
{
    public static class ErrorMessages
    {
        public static string ERR_NO_ARGUMENT { get; } = "You must supply an album ID number. Example: photo-album 1";
        public static string ERR_INVALID_ARGUMENT { get; } = "The album ID must be an integer. Example: photo-album 1";
        public static string ERR_HTTP_STATUS_INVALID { get; } = "The photo album service returned an invalid HTTP response.";
        public static string ERR_HTTP_REQUEST_ERROR { get; } = "An error occurred while attempting to contact the photo album service.";
        public static string ERR_NO_PHOTOS { get; } = "The album was not found, or the album did not contain any photos.";
    }
}
