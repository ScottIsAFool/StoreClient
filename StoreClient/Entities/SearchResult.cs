using System.Collections.Generic;
using PropertyChanged;

namespace StoreClient.Entities
{
    [ImplementPropertyChanged]
    public class SearchResult
    {
        public SearchResult()
        {
            Albums = new List<Album>();
            Tracks = new List<Track>();
            Artists = new List<Artist>();
            StoreApps = new List<StoreApp>();
        }

        public List<Album> Albums { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Artist> Artists { get; set; }
        public List<StoreApp> StoreApps { get; set; }
    }
}
