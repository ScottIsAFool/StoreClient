using System;
using System.Collections.Generic;
using System.Linq;
using PropertyChanged;
using StoreClient.Entities.Zune;

namespace StoreClient.Entities
{
    [ImplementPropertyChanged]
    public class StoreApp
    {

        public string BackgroundImageId { get; set; }
        public List<Capability> Capabilities { get; set; }
        public Category Category { get; set; }
        public List<ClientType> ClientTypes { get; set; }
        public string Content { get; set; }
        public string Currency { get; set; }
        public bool HasLiveTile { get; set; }
        public bool HasTrial { get; set; }
        public string Id { get; set; }
        public string ImageId { get; set; }
        public uint InstallSize { get; set; }
        public bool IsAvailableInCountry { get; set; }
        public bool IsAvailableInStore { get; set; }
        public bool IsBlacklisted { get; set; }
        public string Name { get; set; }
        public uint PackageSize { get; set; }
        public string Price { get; set; }
        public string PublisherName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<string> ScreenshotIds { get; set; }
        public string SortName { get; set; }
        public List<string> SupportedLanguages { get; set; }
        public string Tags { get; set; }
        public string Url { get; set; }
        public decimal UserRating { get; set; }
        public int UserRatingCount { get; set; }
        public string Version { get; set; }


        public StoreApp()
        {
            ClientTypes = new List<ClientType>();
            ScreenshotIds = new List<string>();
            SupportedLanguages = new List<string>();
        }

        internal StoreApp(ZuneAppSearch.feedEntry item) : this()
        {
            var purchaseItem = item.offers.First(x => x.licenseRight == "Purchase");
            var trialItem = item.offers.FirstOrDefault(x => x.licenseRight == "Trial");

            Category = new Category(item.categories.category);
            foreach (var client in item.offers.SelectMany(offer => offer.clientTypes))
            {
                ClientTypes.Add((ClientType)Enum.Parse(typeof(ClientType), client, true));
            }
            Currency = purchaseItem.priceCurrencyCode;
            HasLiveTile = item.hasLiveTile;
            HasTrial = trialItem != default(ZuneAppSearch.offersOffer);
            Id = item.id.Replace("urn:uuid:", "");
            ImageId = item.image.id.Replace("urn:uuid:", "");
            Name = item.title.Value;
            Price = purchaseItem.displayPrice;
            PublisherName = item.publisher.name;
            ReleaseDate = item.releaseDate;
            SortName = item.sortTitle;
            Tags = item.tags.tag;
            UserRating = item.averageUserRating;
            UserRatingCount = item.userRatingCount;
            Version = item.version;
        }

        internal StoreApp(ZuneApp.feed item) : this()
        {
            var purchaseItem = item.offers.offer.First(x => x.licenseRight == "Purchase");
            var trialItem = item.offers.offer.FirstOrDefault(x => x.licenseRight == "Trial");

            BackgroundImageId = string.IsNullOrEmpty(item.backgroundImage.id) ? string.Empty : item.backgroundImage.id.Replace("urn:uuid:", "");
            Capabilities = ParseCapabilities(item.entry.deviceCapabilities);
            Category = new Category(item.categories.category);
            foreach (var client in item.entry.clientTypes)
            {
                ClientTypes.Add((ClientType)Enum.Parse(typeof(ClientType), client, true));
            }
            Content = item.content.Value;
            Currency = purchaseItem.priceCurrencyCode;
            //HasLiveTile = ???
            HasTrial = trialItem != default(ZuneAppSearch.offersOffer);
            Id = item.id.Replace("urn:uuid:", "");
            ImageId = item.image.id.Replace("urn:uuid:", "");
            InstallSize = item.entry.installSize;
            IsAvailableInCountry = item.entry.isAvailableInCountry;
            IsAvailableInStore = item.entry.isAvailableInStore;
            IsBlacklisted = item.entry.isBlacklisted;
            Name = item.title.Value;
            PackageSize = item.entry.packageSize;
            Price = purchaseItem.displayPrice;
            PublisherName = item.publisher;
            ReleaseDate = item.releaseDate;
            ScreenshotIds = item.screenshots.ToList().Select(x => x.id).ToList();
            SortName = item.sortTitle;
            SupportedLanguages = item.entry.supportedLanguages != null
                ? new List<string>(item.entry.supportedLanguages)
                : new List<string>();
            Tags = item.tags.tag;
            Url = item.entry.url;
            UserRating = item.averageUserRating;
            UserRatingCount = item.userRatingCount;
            Version = item.entry.version;
        }

        private static List<Capability> ParseCapabilities(string xml)
        {
            var fixedXml = Uri.UnescapeDataString(xml);

            fixedXml = string.Format("<capabilities>{0}</capabilities>", fixedXml);

            var caps = StoreApiClient.ParseXml<ZuneApp.capabilities>(fixedXml);

            var result = caps.capability.Select(cap => new Capability(cap)).ToList();
            result.AddRange(caps.hwCapability.Select(cap => new Capability(cap)));

            return result;
        }

    }

}
