namespace StoreClient
{
    internal class Constants
    {
        internal const string SearchUrlFormat = "http://cdn.marketplaceedgeservice.windowsphone.com/v8/catalog/queries?os={0}&zLocale={1}&cc=US&oc=&lang={2}&hw=469800450&dm=Virtual&prefix={3}&chunksize=4&includeApplications={4}&includeAlbums={5}&includeArtists={6}&includeTracks={7}&includePodcasts={8}&cf=";
        internal const string SearchUrlMusicFormatSecondary = "http://catalog.zune.net/v3.2/{0}/music/{1}/?chunksize=20&isActionable=true&q={2}";
        internal const string SearchUrlAppFormat = "http://marketplaceedgeservice.windowsphone.com/v8/catalog/apps?os=8.0.9903.0&cc=US&oc=&lang={0}&hw=469838850&dm=Virtual&oemId=Microsoft&moId=&chunkSize=50&q={1}&cf=";
        internal const string ArtistUrlFormat = "http://catalog.zune.net/v3.2/{0}/music/artist/{1}/{2}";
        internal const string AlbumUrlFormat = "http://catalog.zune.net/v3.2/{0}/music/album/{1}";
        internal const string AppUrlFormat = "http://marketplaceedgeservice.windowsphone.com/v8/catalog/apps/{0}?os=8.0.9903.0&cc=US&oc=&lang={1}&hw=469838850&dm=Virtual&oemId=Microsoft&moId=&cf=";
        internal const string AlbumArtUrlFormat = "http://image.catalog.zune.net/v3.2/{0}/image/{1}?width=320&height=320&resize=true&contenttype=image/jpeg";
        internal const string ArtistBackgroundUrlFormat = "http://image.catalog.zune.net/v3.2/{0}/music/artist/{1}/primaryimage?height={2}&contenttype=image/jpeg&resize=true";
        internal const string ScreenshotUrlFormat = "http://cdn.marketplaceimages.windowsphone.com/v8/images/{0}?hw=469838850&imagetype={1}";
        internal const string AppListUrlFormat =
            "http://marketplaceedgeservice.windowsphone.com/v8/catalog/apps?startIndex={0}&chunkSize=10&pagingToken=10%7c10&os=8.0.9903.0&cc=US&oc=&lang={1}&hw=469838850&dm=Virtual&excludeCategory={2}&oemId=Microsoft&moId=&orderBy={3}&cost={4}&cf=";
        internal const string CategoryListUrlFormat = "http://cdn.marketplaceedgeservice.windowsphone.com/v8/catalog/appCategories?os=8.0.9903.0&cc=US&oc=&lang={0}&hw=469838850&dm=Virtual&cf=";
        internal const string GenreListUrlFormat = "http://catalog.zune.net/v3.2/{0}/music/genre";
        internal const string ItemsByGenreUrlFormat = "http://catalog.zune.net/v3.2/{0}/music/genre/{1}/{2}?orderby={3}&chunksize=10";

    }
}
