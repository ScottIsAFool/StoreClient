using System.Xml.Serialization;

namespace StoreClient.Entities.Zune
{
    public class ZuneCommon
    {
        /// <remarks/>
        [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedLink
        {
            /// <remarks/>
            [XmlAttribute()]
            public string rel { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [XmlAttribute()]
            public string href { get; set; }
        }

        /// <remarks/>
        [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedTitle
        {
            /// <remarks/>
            [XmlAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [XmlText()]
            public string Value { get; set; }
        }

        /// <remarks/>
        [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedEntryTitle
        {
            /// <remarks/>
            [XmlAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [XmlText()]
            public string Value { get; set; }
        }

        public partial class image
        {
            /// <remarks/>
            public string id { get; set; }
        }

        /// <remarks/>
        [XmlType(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        [XmlRoot(Namespace = "http://schemas.zune.net/catalog/music/2007/10", IsNullable = false)]
        public partial class primaryArtist
        {
            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            public string name { get; set; }
        }

        /// <remarks/>
        [XmlType(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        [XmlRoot(Namespace = "http://schemas.zune.net/catalog/music/2007/10", IsNullable = false)]
        public partial class primaryGenre
        {
            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            public string title { get; set; }
        }

        /// <remarks/>
        [XmlType(AnonymousType = true, Namespace = "http://schemas.zune.net/catalog/music/2007/10")]
        public partial class rightsRight
        {
            /// <remarks/>
            public string providerCode { get; set; }

            /// <remarks/>
            [XmlArrayItem("paymentType", IsNullable = false)]
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
        [XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class feedAuthor
        {
            /// <remarks/>
            public string name { get; set; }
        }
        
        public partial class rights
        {
            /// <remarks/>
            [XmlElement("right")]
            public rightsRight[] right { get; set; }
        }
        
        public partial class categories
        {
            /// <remarks/>
            public categoriesCategory category { get; set; }
        }

        public partial class categoriesCategory
        {
            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            public string title { get; set; }

            /// <remarks/>
            public string isRoot { get; set; }
        }
    }
}
