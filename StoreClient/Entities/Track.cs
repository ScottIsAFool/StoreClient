using System;
using StoreClient.Entities.Zune;

namespace StoreClient.Entities
{
    public class Track
    {
        internal Track(ZuneTrack.feedEntry item)
        {
            LabelOwner = item.labelOwner;
            Updated = item.updated;
            Name = item.title.Value;
            Id = item.id.Replace("urn:uuid:", "");
            SortTitle = item.sortTitle;
            ReleaseDate = item.releaseDate;
            IsExplicit = item.isExplicit.Equals("True");
            ArtistId = item.primaryArtist.id;
            AlbumArtistId = item.albumArtist.id;
            AlbumId = item.album.id;
            
        }

        public Track(){}

        public int TrackNumber { get; set; }
        public int DiscNumber { get; set; }
        public string AlbumId { get; set; }
        public DateTime Updated { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string SortTitle { get; set; }
        public string LabelOwner { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsExplicit { get; set; }
        public string ArtistId { get; set; }
        public string AlbumArtistId { get; set; }
    }
}