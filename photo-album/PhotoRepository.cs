using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace photo_album
{
    public class PhotoRepository : IPhotoRepository
    {
        private HttpClient _photoServiceClient;
        private string _photoServiceUrl;

        public PhotoRepository(HttpClient serviceClient, string serviceUrl)
        {
            _photoServiceClient = serviceClient;
            _photoServiceUrl = serviceUrl;
        }

        public async Task<Photo[]> List(int albumId)
        {
            HttpResponseMessage response = null;
            Photo[] album;
            try
            {                
                var request = new HttpRequestMessage(HttpMethod.Get, $"{_photoServiceUrl}?albumId={albumId}");
                response = await _photoServiceClient.SendAsync(request);
            }
            catch(Exception ex)
            {
                throw new ApplicationException($"{ErrorMessages.ERR_HTTP_REQUEST_ERROR} The error message was: {ex.Message}");
            }

            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                album = await JsonSerializer.DeserializeAsync<Photo[]>(responseStream);
            }
            else
            {
                throw new ApplicationException($"{ErrorMessages.ERR_HTTP_STATUS_INVALID} Response code {response.StatusCode}");
            }

            return album;
        }
    }
}
