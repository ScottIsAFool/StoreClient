using System;

namespace StoreClient.Entities.Zune
{
    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
    public partial class ZuneReviewResults
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("link")]
        public ZuneCommon.feedLink[] link { get; set; }

        /// <remarks/>
        public DateTime updated { get; set; }

        /// <remarks/>
        public ZuneCommon.feedTitle title { get; set; }

        /// <remarks/>
        public string id { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("entry")]
        public ZuneReview[] entry { get; set; }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
    public partial class ZuneReview
    {
        /// <remarks/>
        public DateTime updated { get; set; }

        /// <remarks/>
        public string id { get; set; }

        /// <remarks/>
        public ZuneCommon.feedAuthor author { get; set; }

        /// <remarks/>
        public ZuneCommon.feedEntryTitle content { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        public byte userRating { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        public string reviewId { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        public string device { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        public string productVersion { get; set; }
    }
}
