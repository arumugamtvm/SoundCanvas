using System.Collections.Generic;

namespace API.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<ArtistAlbumBridge> Artists { get; set; }
    }
}
