using System.Collections.Generic;

namespace StoreClient.Entities
{
    public class AlbumCollection : BaseCollection<Album>
    {
        public AlbumCollection(IEnumerable<Album> list)
        {
            this.AddRange(list);
        }
    }

    public class ArtistCollection: BaseCollection<Artist>
    {
        public ArtistCollection(IEnumerable<Artist> list)
        {
            this.AddRange(list);
        }
    }

    public class TrackCollection : BaseCollection<Track>
    {
        public TrackCollection(IEnumerable<Track> list)
        {
            this.AddRange(list);
        }
    }

    public class StoreAppCollection : BaseCollection<StoreApp>
    {
        public StoreAppCollection(IEnumerable<StoreApp> list)
        {
            this.AddRange(list);
        }
    }

    public class CategoryCollection: BaseCollection<Category>
    {
        public CategoryCollection(IEnumerable<Category> list)
        {
            this.AddRange(list);
        }
    }
}