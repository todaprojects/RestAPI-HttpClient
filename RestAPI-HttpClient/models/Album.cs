using System.Collections.Generic;

namespace RestAPI_HttpClient.models
{
    public class Album
    {
        public int Id { get; set; }

        public List<Photo> Photos { get; set; }
    }
}