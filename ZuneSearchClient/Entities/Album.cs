using System;
using System.Collections.Generic;
using ZuneSearchClient.Entities.Zune;

namespace ZuneSearchClient.Entities
{
    public class Album 
    {
        internal Album(ZuneAlbum.feed item)
        {
            Label = item.label;
            LabelOwner = item.labelOwner;
            Updated = item.updated;
            Name = item.title.Value;
            Id = item.id.Replace("urn:uuid:", "");
            SortTitle = item.sortTitle;
            ReleaseDate = item.releaseDate;
            IsExplicit = item.isExplicit.Equals("True");
            ArtistId = item.primaryArtist.id;
            ImageId = item.image.id.Replace("urn:uuid:", "");
            Tracks = new List<Track>();
            if (item.entry != null)
            {
                foreach (var t in item.entry) Tracks.Add(new Track(t));
            }
        }

        internal Album(ZuneAlbumSearch.feedEntry item)
        {
            Label = item.label;
            LabelOwner = item.labelOwner;
            Updated = item.updated;
            Name = item.title.Value;
            Id = item.id.Replace("urn:uuid:", "");
            SortTitle = item.sortTitle;
            ReleaseDate = item.releaseDate;
            IsExplicit = item.isExplicit.Equals("True");
            ArtistId = item.primaryArtist.id;
            ImageId = item.image.id.Replace("urn:uuid:", "");
        }

        public Album(){}

        public string Label { get; set; }
        public DateTime Updated { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string SortTitle { get; set; }
        public string LabelOwner { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsExplicit { get; set; }
        public string ArtistId { get; set; }
        public List<Track> Tracks { get; set; }
        public string ImageId { get; set; }
    }
}
