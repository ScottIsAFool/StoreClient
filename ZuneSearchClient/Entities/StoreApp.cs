using System;
using System.Collections.Generic;
using System.Linq;
using ZuneSearchClient.Entities.Zune;

namespace ZuneSearchClient.Entities
{
    public class StoreApp
    {
        public StoreApp(){}

        internal StoreApp(ZuneAppSearch.feedEntry item)
        {
            ClientTypes = new List<ClientType>();
            SupportedLanguages = new List<string>();
            ScreenshotIds = new List<string>();
            foreach (var client in item.offers.SelectMany(offer => offer.clientTypes))
            {
                ClientTypes.Add((ClientType)Enum.Parse(typeof(ClientType), client, true));
            }
            Id = item.id.Replace("urn:uuid:", "");
            Name = item.title.Value;
            SortName = item.sortTitle;
            ReleaseDate = item.releaseDate;
            Version = item.version;
            UserRating = item.averageUserRating;
            UserRatingCount = item.userRatingCount;
            ImageId = item.image.id.Replace("urn:uuid:", "");
            HasLiveTile = item.hasLiveTile;
            Category = new Category(item.categories.category);
            Tags = item.tags.tag;
            PublisherName = item.publisher.name;
            
            var purchaseItem = item.offers.First(x => x.licenseRight == "Purchase");
            var trialItem = item.offers.FirstOrDefault(x => x.licenseRight == "Trial");
            HasTrial = trialItem != default(ZuneAppSearch.offersOffer);
            Price = purchaseItem.displayPrice;
            Currency = purchaseItem.priceCurrencyCode;
        }

        internal StoreApp(ZuneApp.feed item)
        {
            ClientTypes = new List<ClientType>();
            SupportedLanguages = new List<string>();
            ScreenshotIds = new List<string>();
            foreach (var client in item.entry.clientTypes)
            {
                ClientTypes.Add((ClientType)Enum.Parse(typeof(ClientType), client, true));
            }
            Id = item.id.Replace("urn:uuid:", "");
            Name = item.title.Value;
            IsBlacklisted = item.entry.isBlacklisted;
            PackageSize = item.entry.packageSize;
            InstallSize = item.entry.installSize;
            if (item.entry.supportedLanguages != null) SupportedLanguages = new List<string>(item.entry.supportedLanguages);
            SortName = item.sortTitle;
            ReleaseDate = item.releaseDate;
            Version = item.entry.version;
            UserRating = item.averageUserRating;
            UserRatingCount = item.userRatingCount;
            ImageId = item.image.id.Replace("urn:uuid:", "");
            Category = new Category(item.categories.category);
            Tags = item.tags.tag;
            PublisherName = item.publisher;

            var purchaseItem = item.offers.offer.First(x => x.licenseRight == "Purchase");
            var trialItem = item.offers.offer.FirstOrDefault(x => x.licenseRight == "Trial");
            HasTrial = trialItem != default(ZuneAppSearch.offersOffer);
            Price = purchaseItem.displayPrice;
            Currency = purchaseItem.priceCurrencyCode;
            ScreenshotIds = item.screenshots.ToList().Select(x => x.id).ToList();
            Content = item.content.Value;
        }

        public string SortName { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string Version { get; set; }
        public bool IsAvailableInCountry { get; set; }
        public bool IsAvailableInStore { get; set; }
        public bool IsBlacklisted { get; set; }
        public string Url { get; set; }
        public uint PackageSize { get; set; }
        public uint InstallSize { get; set; }
        public List<ClientType> ClientTypes { get; set; }
        public string Price { get; set; }
        public string Currency { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal UserRating { get; set; }
        public int UserRatingCount { get; set; }
        public bool HasLiveTile { get; set; }
        public string ImageId { get; set; }
        public string Tags { get; set; }
        public string PublisherName { get; set; }
        public Category Category { get; set; }
        public bool HasTrial { get; set; }
        public List<string> SupportedLanguages { get; set; }
        public List<string> ScreenshotIds { get; set; }
        public string Content { get; set; }
    }
}
