using System;

namespace StoreClient.Entities.Zune
{
    public class ZuneAppSearch
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
        public partial class feed
        {
            /// <remarks/>
            public ZuneCommon.feedLink link { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
            public int startIndex { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
            public int totalResults { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://a9.com/-/spec/opensearch/1.1/")]
            public int itemsPerPage { get; set; }

            /// <remarks/>
            public DateTime updated { get; set; }

            /// <remarks/>
            public ZuneCommon.feedTitle title { get; set; }

            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string impressionId { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("entry")]
            public feedEntry[] entry { get; set; }

            /// <remarks/>
            public ZuneCommon.feedAuthor author { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false, ElementName = "feed")]
        public partial class appListFeed
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
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string pagingToken { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string impressionId { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("entry")]
            public feedEntry[] entry { get; set; }

            /// <remarks/>
            public ZuneCommon.feedAuthor author { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedEntry  
        {
            /// <remarks/>
            public DateTime updated { get; set; }

            /// <remarks/>
            public ZuneCommon.feedEntryTitle title { get; set; }

            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public bool isHardwareCompatible { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string sortTitle { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public DateTime releaseDate { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string version { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public decimal averageUserRating { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public int userRatingCount { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public ZuneCommon.image image { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public bool hasLiveTile { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public ZuneCommon.categories categories { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public tags tags { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02"), System.Xml.Serialization.XmlArrayItemAttribute("offer", IsNullable = false)]
            public offersOffer[] offers { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public publisher publisher { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string impressionId { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public int k { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02", IsNullable = false)]
        public partial class tags
        {
            /// <remarks/>
            public string tag { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        public partial class offersOffer
        {
            /// <remarks/>
            public string offerId { get; set; }

            /// <remarks/>
            public string mediaInstanceId { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("clientType", IsNullable = false)]
            public string[] clientTypes { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("paymentType", IsNullable = false)]
            public string[] paymentTypes { get; set; }

            /// <remarks/>
            public string store { get; set; }

            /// <remarks/>
            public decimal price { get; set; }

            /// <remarks/>
            public string displayPrice { get; set; }

            /// <remarks/>
            public string priceCurrencyCode { get; set; }

            /// <remarks/>
            public string licenseRight { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02", IsNullable = false)]
        public partial class publisher
        {
            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            public string name { get; set; }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02", IsNullable = false)]
        public partial class offers
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("offer")]
            public offersOffer[] offer { get; set; }
        }
    }
}
