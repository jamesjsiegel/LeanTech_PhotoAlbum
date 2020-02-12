using System.IO;
using Microsoft.Extensions.Configuration;

namespace photo_album
{
    public class AppSettings
    {
        private static IConfiguration _config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();

        public static string PhotoServiceUri { get; } = _config["photoServiceUrl"];
    }
}