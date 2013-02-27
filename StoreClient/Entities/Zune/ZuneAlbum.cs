using System;

namespace StoreClient.Entities.Zune
{
    public partial class ZuneAlbum
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
        public partial class feed
        {
            /// <remarks/>
            public ZuneCommon.feedLink link { get; set; }

            /// <remarks/>
            public DateTime updated { get; set; }

            /// <remarks/>
            public ZuneCommon.feedTitle title { get; set; }

            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public string sortTitle { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public string label { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public string labelOwner { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public DateTime releaseDate { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public ZuneCommon.image image { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public byte playRank { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public byte playCount { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public byte favoriteCount { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public byte sendCount { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public string isExplicit { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public string isActionable { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public string isPremium { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public DateTime startDate { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public ZuneCommon.primaryArtist primaryArtist { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public ZuneCommon.primaryGenre primaryGenre { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("entry")]
            public ZuneTrack.feedEntry[] entry { get; set; }

            /// <remarks/>
            public ZuneCommon.feedAuthor author { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10", IsNullable = false)]
        public partial class album
        {
            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            public string title { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10", IsNullable = false)]
        public partial class albumArtist
        {
            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            public string name { get; set; }
        }
    }
}
