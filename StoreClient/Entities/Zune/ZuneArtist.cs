using System;

namespace StoreClient.Entities.Zune
{
    public class ZuneArtist
    {
        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
        public partial class entry
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlElement(ElementName = "entryLink")]
            public ZuneCommon.feedLink link { get; set; }

            /// <remarks/>
            public DateTime updated { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlElement(ElementName = "entryTitle")]
            public ZuneCommon.feedEntryTitle title { get; set; }

            /// <remarks/>
            public string id { get; set; }

            /// <remarks/>
            public entryContent content { get; set; }

            /// <remarks/> 
            [System.Xml.Serialization.XmlElement(ElementName = "entryAuthor")]
            public ZuneCommon.feedAuthor author { get; set; }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
        public partial class entryContent
        {
            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type { get; set; }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value { get; set; }
        }
    }
}
