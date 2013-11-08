using System;
using PropertyChanged;
using StoreClient.Entities.Zune;

namespace StoreClient.Entities
{
    [ImplementPropertyChanged]
    public class Review
    {
        public Review(){}

        internal Review(ZuneReview item)
        {
            Updated = item.updated;
            Id = item.id;
            AuthorName = item.author != null ? item.author.name : string.Empty;
            ReviewContent = item.content != null ? item.content.Value : string.Empty;
            Rating = item.userRating;
            ReviewId = !string.IsNullOrEmpty(item.reviewId) ? new Guid(item.reviewId) : Guid.Empty;
            Device = item.device;
            AppVersion = !string.IsNullOrEmpty(item.productVersion) ? new Version(item.productVersion) : null;
        }

        public DateTime Updated { get; set; }

        public string Id { get; set; }

        public string AuthorName { get; set; }

        public string ReviewContent { get; set; }

        public int Rating { get; set; }

        public Guid ReviewId { get; set; }

        public string Device { get; set; }

        public Version AppVersion { get; set; }
    }
}
