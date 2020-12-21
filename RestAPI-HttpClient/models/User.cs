using System.Collections.Generic;

namespace RestAPI_HttpClient.models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Album> Albums { get; set; }
    }
}