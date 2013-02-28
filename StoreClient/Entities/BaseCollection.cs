using System;
using System.Collections.Generic;
using StoreClient.Entities.Zune;

namespace StoreClient.Entities
{
    public class BaseCollection<T> : List<T>
    {
        public string PreviousPageMarker { get; set; }
        public string NextPageMarker { get; set; }

        internal void ProcessLinks(ZuneCommon.feedLink[] links)
        {
            foreach (var link in links)
            {
                var uri = new Uri("http://something.com" + Uri.UnescapeDataString(link.href));
                var queries = ParseQueryString(uri.Query);
                if (link.rel == "prev")
                {
                    PreviousPageMarker = "beforeMarker=" + queries["beforeMarker"];
                }
                else if (link.rel == "next")
                {
                    PreviousPageMarker = "afterMarker=" + queries["afterMarker"];
                }
            }
        }

        private static Dictionary<string, string> ParseQueryString(string queryString)
        {
            var nameValueCollection = new Dictionary<string, string>();
            var items = queryString.Split('&');

            foreach (var item in items)
            {
                if (item.Contains("="))
                {
                    string[] nameValue = item.Split('=');
                    if (nameValue[0].Contains("?"))
                        nameValue[0] = nameValue[0].Replace("?", "");
                    nameValueCollection.Add(nameValue[0], (nameValue[1]));
                }
            }

            return nameValueCollection;
        }
    }
}
