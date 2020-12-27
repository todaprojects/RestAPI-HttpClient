using System.Collections.Generic;

namespace RestAPI_HttpClient.Models
{
    public class Album
    {
        public int Id { get; set; }

        public List<Photo> Photos { get; set; }
    }
}