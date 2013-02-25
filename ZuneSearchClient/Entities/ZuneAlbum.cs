using System;

namespace ZuneSearchClient.Entities
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false, ElementName = "feed")]
    public partial class ZuneAlbumResults
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link")]
        public FeedLink Link { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("updated")]
        public DateTime Updated { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public FeedTitle Title { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public string Id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entry")]
        public ZuneAlbum[] Entries { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("author")]
        public feedAuthor Author { get; set; }
    }
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false, ElementName = "feed")]
    public partial class ZuneAlbum
    {
        /// <remarks/>
        public FeedLink link { get; set; }

        /// <remarks/>
        public DateTime updated { get; set; }

        /// <remarks/>
        public Title title { get; set; }

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
        public image image { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public byte playRank { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public uint playCount { get; set; }

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
        public primaryArtist primaryArtist { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public primaryGenre primaryGenre { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10"), System.Xml.Serialization.XmlArrayItemAttribute("right", IsNullable = false)]
        public rightsRight[] rights { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entry")]
        public ZuneTrack[] Tracks { get; set; }

        /// <remarks/>
        public feedAuthor author { get; set; }

        internal Album Result { get { return new Album(this); } }
    }


    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10", IsNullable = false)]
    public partial class image
    {
        /// <remarks/>
        public string id { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10", IsNullable = false)]
    public partial class primaryArtist
    {
        /// <remarks/>
        public string id { get; set; }

        /// <remarks/>
        public string name { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10", IsNullable = false)]
    public partial class primaryGenre
    {
        /// <remarks/>
        public string id { get; set; }

        /// <remarks/>
        public string title { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
    public partial class rightsRight
    {
        /// <remarks/>
        public string mediaInstanceId { get; set; }

        /// <remarks/>
        public string providerCode { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("paymentType", IsNullable = false)]
        public string[] paymentTypes { get; set; }

        /// <remarks/>
        public string offerId { get; set; }

        /// <remarks/>
        public decimal price { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool priceSpecified { get; set; }

        /// <remarks/>
        public string priceCurrencyCode { get; set; }

        /// <remarks/>
        public string licenseRight { get; set; }

        /// <remarks/>
        public string audioEncoding { get; set; }

        /// <remarks/>
        public uint fileSize { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fileSizeSpecified { get; set; }

        /// <remarks/>
        public string displayPrice { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false, ElementName = "feedEntry")]
    public partial class ZuneTrack
    {
        /// <remarks/>
        public DateTime updated { get; set; }

        /// <remarks/>
        public Title title { get; set; }

        /// <remarks/>
        public string id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public string sortTitle { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public string labelOwner { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public DateTime releaseDate { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public album album { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10", DataType = "duration")]
        public string length { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public byte playRank { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public uint playCount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public string isExplicit { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public byte trackNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public byte discNumber { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public primaryArtist primaryArtist { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public albumArtist albumArtist { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public primaryGenre primaryGenre { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10"), System.Xml.Serialization.XmlArrayItemAttribute("right", IsNullable = false)]
        public rightsRight[] rights { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public string musicVideoId { get; set; }

        internal Track Result
        {
            get { return new Track(this); }
        }
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

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10", IsNullable = false)]
    public partial class rights
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("right")]
        public rightsRight[] right { get; set; }
    }


}
