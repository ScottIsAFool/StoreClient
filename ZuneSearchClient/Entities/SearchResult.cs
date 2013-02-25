using System;

namespace ZuneSearchClient.Entities
{
    public class SearchResult
    {
        internal SearchResult(ZuneResult result)
        {
            Updated = result.Updated;
            Name = result.Title.Value;
            Id = result.Id.Replace("urn:uuid:", "");
            Type = result.Type;
            Score = result.Score;
        }

        public SearchResult(){}

        public DateTime Updated { get; private set; }
        public string Name { get; private set; }
        public string Id { get; private set; }
        public string Type { get; private set; }
        public decimal Score { get; private set; }
    }
}
