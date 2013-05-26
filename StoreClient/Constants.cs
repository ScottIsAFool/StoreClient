namespace StoreClient
{
    internal class Constants
    {
        internal const string SearchUrlMusicFormatSecondary = "http://catalog.zune.net/v3.2/{0}/music/{1}/?chunksize=20&isActionable=true&q={2}";
        internal const string SearchUrlAppFormat = "http://marketplaceedgeservice.windowsphone.com/v8/catalog/apps?os=8.0.9903.0&cc=US&oc=&lang={0}&hw=469838850&dm=Virtual&oemId=Microsoft&moId=&chunkSize=50&q={1}&cf=";
        internal const string SearchUrlAppFormat7 = "http://marketplaceedgeservice.windowsphone.com/v3.2/{1}/apps/?q={0}&chunkSize=50&clientType=WinMobile%207.1&store=Zest&store=O2OGB&store=Samsung&os=7.10.8862.144&hw=268458498&dm=OMNIA7";
        internal const string ArtistUrlFormat = "http://catalog.zune.net/v3.2/{0}/music/artist/{1}/{2}";
        internal const string AlbumUrlFormat = "http://catalog.zune.net/v3.2/{0}/music/album/{1}";
        internal const string AppUrlFormat = "http://marketplaceedgeservice.windowsphone.com/v8/catalog/apps/{0}?os=8.0.9903.0&cc=US&oc=&lang={1}&hw=469838850&dm=Virtual&oemId=Microsoft&moId=&cf=";

        internal const string AppUrlFormat7 = "http://marketplaceedgeservice.windowsphone.com/v3.2/{1}/apps/{0}?clientType=WinMobile%207.1&store=Zest&store=O2OGB&store=Samsung&os=7.10.8862.144&hw=268458498&dm=OMNIA7";
        internal const string AlbumArtUrlFormat = "http://image.catalog.zune.net/v3.2/{0}/image/{1}?width=320&height=320&resize=true&contenttype=image/jpeg";
        internal const string ArtistBackgroundUrlFormat = "http://image.catalog.zune.net/v3.2/{0}/music/artist/{1}/primaryimage?height={2}&contenttype=image/jpeg&resize=true";
        internal const string ScreenshotUrlFormat = "http://cdn.marketplaceimages.windowsphone.com/v8/images/{0}?hw=469838850&imagetype={1}";
        internal const string AppListUrlFormat = "http://marketplaceedgeservice.windowsphone.com/v8/catalog/apps?startIndex={0}&chunkSize=10&pagingToken=10%7c10&os=8.0.9903.0&cc=US&oc=&lang={1}&hw=469838850&dm=Virtual&excludeCategory={2}&oemId=Microsoft&moId=&orderBy={3}&cost={4}&cf=";
        internal const string AppListUrlFormat7 = "http://marketplaceedgeservice.windowsphone.com/v3.2/{1}/apps?afterMarker=CgAAAA%3d%3d&chunkSize=10&pagingToken=10%7c10&orderBy={3}&cost={4}&excludeCategory={2}&clientType=WinMobile+7.1&store=Zest&store=O2OGB&os=7.10.8862.144&hw=268458498&dm=OMNIA7";
        internal const string CategoryListUrlFormat = "http://cdn.marketplaceedgeservice.windowsphone.com/v8/catalog/appCategories?os=8.0.9903.0&cc=US&oc=&lang={0}&hw=469838850&dm=Virtual&cf=";
        internal const string CategoryListUrlFormat7 = "http://cdn.marketplaceedgeservice.windowsphone.com/v3.2/{0}/appCategories?clientType=WinMobile%207.1&store=Zest&store=O2OGB&store=Samsung&os=7.10.8862.144&hw=268458498&dm=OMNIA7";
        internal const string GenreListUrlFormat = "http://catalog.zune.net/v3.2/{0}/music/genre";
        internal const string ItemsByGenreUrlFormat = "http://catalog.zune.net/v3.2/{0}/music/genre/{1}/{2}?orderby={3}&chunksize=10{4}";

    }
}
