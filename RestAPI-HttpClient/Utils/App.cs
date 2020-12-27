using System.Linq;
using System.Threading.Tasks;
using RestAPI_HttpClient.Config;
using RestAPI_HttpClient.Models;

namespace RestAPI_HttpClient.Utils
{
    public static class App
    {
        public static async Task<User> GetUserAsync(string username)
        {
            var users = await JsonConverter.Get<User>();
            
            var user = users.First(u => u.Name == username);

            ResourceApi.UserId = user.Id;
            user.Albums = await JsonConverter.Get<Album>();

            foreach (var album in user.Albums)
            {
                ResourceApi.AlbumId = album.Id;
                album.Photos = await JsonConverter.Get<Photo>();
            }

            return user;
        }
    }
}