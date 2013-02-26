using System;

namespace ZuneSearchClient.Entities.Zune
{
    public class ZuneAlbumSearch
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
        public partial class feed
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("link")]
            public feedLink[] link { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
            public byte startIndex { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
            public byte totalResults { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
            public byte itemsPerPage { get; set; }

            /// <remarks/>
            public DateTime updated { get; set; }

            /// <remarks/>
            public feedTitle title { get; set; }

            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("entry")]
            public feedEntry[] entry { get; set; }

            /// <remarks/>
            public feedAuthor author { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false, ElementName = "feed")]
        public partial class albumFeed
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("link")]
            public feedLink[] link { get; set; }

            /// <remarks/>
            public DateTime updated { get; set; }

            /// <remarks/>
            public feedTitle title { get; set; }

            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("entry")]
            public feedEntry[] entry { get; set; }

            /// <remarks/>
            public feedAuthor author { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedEntry
        {
            /// <remarks/>
            public DateTime updated { get; set; }

            /// <remarks/>
            public feedEntryTitle title { get; set; }

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
            public string isExplicit { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public string isActionable { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public string isPremium { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public primaryArtist primaryArtist { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
            public primaryGenre primaryGenre { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10"), System.Xml.Serialization.XmlArrayItemAttribute("right", IsNullable = false)]
            public rightsRight[] rights { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedLink
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rel { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string href { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedTitle
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value { get; set; }
        }

        /// <remarks/>
        //[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        //public partial class feedEntry
        //{
        //    /// <remarks/>
        //    public DateTime updated { get; set; }

        //    /// <remarks/>
        //    public feedEntryTitle title { get; set; }

        //    /// <remarks/>
        //    public string id { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public string sortTitle { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public string label { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public string labelOwner { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public DateTime releaseDate { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public image image { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public byte playRank { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public ushort playCount { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public string isExplicit { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public string isActionable { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public string isPremium { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public primaryArtist primaryArtist { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        //    public primaryGenre primaryGenre { get; set; }

        //    /// <remarks/>
        //    [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.zune.net/catalog/music/2007/10"), System.Xml.Serialization.XmlArrayItemAttribute("right", IsNullable = false)]
        //    public rightsRight[] rights { get; set; }
        //}

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedEntryTitle
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value { get; set; }
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
            public string providerCode { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("paymentType", IsNullable = false)]
            public string[] paymentTypes { get; set; }

            /// <remarks/>
            public string offerId { get; set; }

            /// <remarks/>
            public decimal price { get; set; }

            /// <remarks/>
            public string priceCurrencyCode { get; set; }

            /// <remarks/>
            public string licenseRight { get; set; }

            /// <remarks/>
            public string audioEncoding { get; set; }

            /// <remarks/>
            public string displayPrice { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedAuthor
        {
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
}
