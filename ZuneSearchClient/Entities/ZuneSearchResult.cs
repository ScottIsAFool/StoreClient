using System;

namespace ZuneSearchClient.Entities
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false, ElementName = "feed")]
    public partial class ZuneSearchResults
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
        public ZuneResult[] Entries { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("author")]
        public feedAuthor Author { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false, ElementName = "feedLink")]
    public partial class FeedLink
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
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false, ElementName = "feedLink")]
    public partial class FeedTitle
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false, ElementName = "feedEntry")]
    public partial class ZuneResult
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("updated")]
        public DateTime Updated { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("title")]
        public Title Title { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public string Id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/2008/3", ElementName = "type")]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/2008/3", ElementName = "score")]
        public decimal Score { get; set; }

        internal SearchResult Result
        {
            get { return new SearchResult(this); }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false, ElementName = "feedEntryTitle")]
    public partial class Title
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    public partial class feedAuthor
    {
        /// <remarks/>
        public string name { get; set; }
    }



}
