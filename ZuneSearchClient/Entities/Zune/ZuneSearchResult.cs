using System;

namespace ZuneSearchClient.Entities.Zune
{
    public class ZuneSearchResults
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
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/2008/3")]
            public string type { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://schemas.zune.net/catalog/2008/3")]
            public decimal score { get; set; }
        }
    }
}
