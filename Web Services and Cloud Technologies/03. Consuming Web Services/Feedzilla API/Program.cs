// Write a console application, which searches for news articles by given a query string and a
// count of articles to retrieve. The application should ask the user for input and print the 
// Titles and URLs of the articles. For news articles search use the FeedzillaAPI and use one of 
// WebClient, HttpWebRequest or HttpClient.

namespace Feedzilla_API
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;

    using Newtonsoft.Json;
    
    public class Program
    {
        private const string URL = @"http://jsonplaceholder.typicode.com/photos/";

        public static void Main()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(URL);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string title = "aut";
            int count = 5;

            var photoAlbums = GetPhotoAlbums(httpClient, title, count);

            foreach (var item in photoAlbums)
            {
                Console.WriteLine("AlbumId: {0} \nPhotoId: {1} \nTitle: {2} \nUrl: {3}, \nThumbnailUrl: {4} \n",
                    item.AlbumId, item.PhotoId, item.Title, item.Url, item.ThumbnailUrl);
            }
        }

        private static ICollection<PhotoAlbumModel> GetPhotoAlbums(HttpClient httpClient, string title, int count)
        {
            var response = httpClient.GetAsync(string.Empty).Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new InvalidOperationException("Invalid status code!");
            }

            var albums = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<ICollection<PhotoAlbumModel>>(albums)
                .Where(a => a.Title.Contains(title))
                .Take(count)
                .ToList();
        }
    }
}
