namespace ZuneSearchClient
{
    internal class Constants
    {
        internal const string SearchUrlFormat = "http://cdn.marketplaceedgeservice.windowsphone.com/v8/catalog/queries?os=8.0.9903.0&zLocale=en-US&cc=US&oc=&lang=en-US&hw=469800450&dm=Virtual&prefix={0}&chunksize=4&includeApplications={1}&includeAlbums={2}&includeArtists={3}&includeTracks={4}&includePodcasts={5}&cf=";
        internal const string ArtistUrlFormat = "http://catalog.zune.net/v3.2/en-US/music/artist/{0}/biography";
        internal const string AlbumUrlFormat = "http://catalog.zune.net/v3.2/en-US/music/album/{0}";
    }
}
