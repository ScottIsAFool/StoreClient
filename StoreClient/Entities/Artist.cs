using PropertyChanged;
using StoreClient.Entities.Zune;

namespace StoreClient.Entities
{
    [ImplementPropertyChanged]
    public class Artist
    {
        internal Artist(ZuneArtist.entry artist)
        {
            Id = artist.id.Replace("urn:uuid:", "");
            Name = artist.title.Value;
            Content = artist.content.Value;
        }

        internal Artist(ZuneArtistSearch.feedEntry artist)
        {
            Id = artist.id.Replace("urn:uuid:", "");
            Name = artist.title.Value;
            ImageId = artist.image.id.Replace("urn:uuid:", "");
            Genre = artist.primaryGenre.title;
            SortName = artist.sortName;
        }

        public Artist(){}

        public string Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string ImageId { get; set; }
        public string Genre { get; set; }
        public string SortName { get; set; }
    }
}
