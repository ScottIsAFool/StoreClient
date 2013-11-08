using System.Collections.Generic;

namespace StoreClient.Entities
{
    public class AlbumCollection : BaseCollection<Album>
    {
        public AlbumCollection(IEnumerable<Album> list)
        {
            AddRange(list);
        }
    }

    public class ArtistCollection: BaseCollection<Artist>
    {
        public ArtistCollection(IEnumerable<Artist> list)
        {
            AddRange(list);
        }
    }

    public class TrackCollection : BaseCollection<Track>
    {
        public TrackCollection(IEnumerable<Track> list)
        {
            AddRange(list);
        }
    }

    public class StoreAppCollection : BaseCollection<StoreApp>
    {
        public StoreAppCollection(IEnumerable<StoreApp> list)
        {
            AddRange(list);
        }
    }

    public class CategoryCollection: BaseCollection<Category>
    {
        public CategoryCollection(IEnumerable<Category> list)
        {
            AddRange(list);
        }
    }

    public class ReviewCollection : BaseCollection<Review>
    {
        public ReviewCollection(IEnumerable<Review> list)
        {
            this.AddRange(list);
        }
    }
}