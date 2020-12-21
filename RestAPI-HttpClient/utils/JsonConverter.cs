using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestAPI_HttpClient.config;

namespace RestAPI_HttpClient.utils
{
    public static class JsonConverter
    {
        public static async Task<List<T>> Get<T>()
        {
            var httpClient = HttpClientHandler.GetInstance();

            var sourceUri = ResourceApi.GetUrl(typeof(T).Name);

            var response = await httpClient.GetAsync(sourceUri);
            var responseBody = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<List<T>>(responseBody);
        }
    }
}