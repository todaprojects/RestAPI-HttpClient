using System.Net.Http;

namespace RestAPI_HttpClient.utils
{
    public static class HttpClientHandler
    {
        private static HttpClient _httpClientInstance;

        public static HttpClient GetInstance()
        {
            return _httpClientInstance ??= new HttpClient();
        }
    }
}