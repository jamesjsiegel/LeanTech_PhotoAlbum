﻿using System;
using System.Collections.Generic;
using System.Net.Http;

namespace photo_album
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine(ErrorMessages.ERR_NO_ARGUMENT);
            }
            else
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        var repository = new PhotoRepository(client);
                        var service = new PhotoService(repository);
                        var album = service.GetAlbum(args[0]);
                        DisplayPhotos(album);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        static void DisplayPhotos(Photo[] album)
        {
            if(album.Length == 0)
            {
                Console.WriteLine(ErrorMessages.ERR_NO_PHOTOS);
            }
            foreach(var photo in album)
            {
                Console.WriteLine($"[{photo.Id}] {photo.Title}\n");
            }
        }
    }
}
