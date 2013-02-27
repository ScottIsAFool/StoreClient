using StoreClient.Entities.Zune;

namespace StoreClient.Entities
{
    public class Category
    {
        internal Category(ZuneCommon.categoriesCategory item)
        {
            Id = item.id;
            Title = item.title;
        }
        public string Id { get; set; }
        public string Title { get; set; }
    }
}