using System;
using System.Linq;
using System.Threading.Tasks;
using RestAPI_HttpClient.utils;

namespace RestAPI_HttpClient
{
    class Program
    {
        private const string UserName = "Mrs. Dennis Schulist";

        private static async Task Main(string[] args)
        {
            try
            {
                var user = await App.GetUserAsync(UserName);

                foreach (var photo in user.Albums.SelectMany(album => album.Photos))
                {
                    Console.WriteLine(photo.Url);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}