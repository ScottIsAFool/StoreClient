using ZuneSearchClient.Entities.Zune;

namespace ZuneSearchClient.Entities
{
    public class Artist
    {
        internal Artist(ZuneArtist.feedEntry artist)
        {
            Id = artist.id.Replace("urn:uuid:", "");
            Name = artist.title.Value;
        }

        internal Artist(ZuneArtistSearch.feedEntry artist)
        {
            Id = artist.id.Replace("urn:uuid:", "");
            Name = artist.title.Value;
        }

        public Artist(){}

        public string Id { get; set; }
        public string Name { get; set; }
        public string ImageId { get; set; }
    }
}
