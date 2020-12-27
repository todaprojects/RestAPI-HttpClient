using System;

namespace RestAPI_HttpClient.Config
{
    public static class ResourceApi
    {
        public static int UserId { get; set; }
        
        public static int AlbumId { get; set; }

        private const string UsersUri = "https://jsonplaceholder.typicode.com/users";

        private static string UserAlbumsUri => $"https://jsonplaceholder.typicode.com/users/{UserId}/albums";

        private static string AlbumPhotosUri => $"https://jsonplaceholder.typicode.com/albums/{AlbumId}/photos";

        public static string GetUrl(string str)
        {
            return str switch
            {
                "User" => UsersUri,
                "Album" => UserAlbumsUri,
                "Photo" => AlbumPhotosUri,
                _ => throw new Exception("Undefined argument passed to ResourceApi.GetUrl()")
            };
        }
    }
}