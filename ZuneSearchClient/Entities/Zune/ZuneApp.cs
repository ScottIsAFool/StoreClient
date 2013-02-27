using System;

namespace ZuneSearchClient.Entities.Zune
{
    public class ZuneApp
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
            public feedContent content { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public sbyte iapCount { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string sortTitle { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public DateTime releaseDate { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string visibilityStatus { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string publisher { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public decimal averageUserRating { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public byte userRatingCount { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public ZuneCommon.image image { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02"), System.Xml.Serialization.XmlArrayItemAttribute("screenshot", IsNullable = false)]
            public screenshotsScreenshot[] screenshots { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public ZuneCommon.categories categories { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public ZuneAppSearch.tags tags { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public ZuneAppSearch.offers offers { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string taxString { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public object backgroundImage { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string publisherId { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string publisherGuid { get; set; }

            /// <remarks/>
            public feedEntry entry { get; set; }

            /// <remarks/>
            public ZuneCommon.feedAuthor author { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedContent
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        public partial class screenshotsScreenshot
        {
            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            public byte orientation { get; set; }
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
            public string version { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string payloadId { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string skuId { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public DateTime skuLastUpdated { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public bool isAvailableInCountry { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public bool isAvailableInStore { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public bool isClientTypeCompatible { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public bool isHardwareCompatible { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public bool isBlacklisted { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string url { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public uint packageSize { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public uint installSize { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02"), System.Xml.Serialization.XmlArrayItemAttribute("clientType", IsNullable = false)]
            public clientTypes[] clientTypes { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02"), System.Xml.Serialization.XmlArrayItemAttribute("supportedLanguage", IsNullable = false)]
            public supportedLanguages[] supportedLanguages { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
            public string deviceCapabilities { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02", IsNullable = false)]
        public partial class screenshots
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("screenshot")]
            public screenshotsScreenshot[] screenshot { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02", IsNullable = false)]
        public partial class clientTypes
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("clientType")]
            public string[] clientType { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/apps/2008/02")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.zune.net/catalog/apps/2008/02", IsNullable = false)]
        public partial class supportedLanguages
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("supportedLanguage")]
            public string[] supportedLanguage { get; set; }
        }


    }
}
