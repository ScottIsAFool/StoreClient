using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AdvancedREI.Net.Http.Compression;
using StoreClient.Entities;
using StoreClient.Entities.Zune;

namespace StoreClient
{
    public class StoreApiClient
    {
        private const string DefaultLocale = "en-US";
        /// <summary>
        /// Gets the HTTP client.
        /// </summary>
        /// <value>
        /// The HTTP client.
        /// </value>
        public HttpClient HttpClient { get; private set; }
        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        /// <value>
        /// The locale.
        /// </value>
        public string Locale { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreApiClient" /> class.
        /// </summary>
        /// <param name="handler">The handler.</param>
        public StoreApiClient(HttpMessageHandler handler)
        {
            HttpClient = new HttpClient(handler);
            Locale = DefaultLocale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreApiClient" /> class with default HttpHandler using compression
        /// </summary>
        public StoreApiClient()
        {
            HttpClient = new HttpClient(new CompressedHttpClientHandler());
            Locale = DefaultLocale;
        }

        /// <summary>
        /// Searches the async.
        /// </summary>
        /// <param name="searchQuery">The search query.</param>
        /// <param name="locale">sets the locale to do the search on. If null or empty, it uses what's set for Locale</param>
        /// <param name="includeAlbums">if set to <c>true</c> [include albums].</param>
        /// <param name="includeArtists">if set to <c>true</c> [include artists].</param>
        /// <param name="includeTracks">if set to <c>true</c> [include tracks].</param>
        /// <param name="includePodcasts">if set to <c>true</c> [include podcasts].</param>
        /// <param name="includeApps">if set to <c>true</c> [include apps].</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">SearchQuery cannot be null or empty</exception>
        public async Task<SearchResult> SearchAsync(string searchQuery, string locale = null, bool includeAlbums = true, bool includeArtists = true, bool includeTracks = true, bool includePodcasts = true, bool includeApps = true)
        {
            if (string.IsNullOrEmpty(searchQuery))
            {
                throw new NullReferenceException("SearchQuery cannot be null or empty");
            }

            string url;

            locale = string.IsNullOrEmpty(locale) ? Locale : locale;

            var searchResult = new SearchResult();

            if (includeAlbums)
            {
                url = string.Format(Constants.SearchUrlMusicFormatSecondary, locale, "album", searchQuery);
                var alXml = await HttpClient.GetStringAsync(url);
                var alResults = ParseXml<ZuneAlbumSearch.feed>(alXml);
                foreach (var result in alResults.entry)
                {
                    searchResult.Albums.Add(new Album(result));
                }
            }

            if (includeArtists)
            {
                url = string.Format(Constants.SearchUrlMusicFormatSecondary, locale, "artist", searchQuery);
                var arXml = await HttpClient.GetStringAsync(url);
                var arResults = ParseXml<ZuneArtistSearch.feed>(arXml);
                foreach (var result in arResults.entry)
                {
                    searchResult.Artists.Add(new Artist(result));
                }
            }

            if (includeTracks)
            {
                url = string.Format(Constants.SearchUrlMusicFormatSecondary, locale, "track", searchQuery);
                var trXml = await HttpClient.GetStringAsync(url);
                var trResults = ParseXml<ZuneTrack.feed>(trXml);
                foreach (var result in trResults.entry)
                {
                    searchResult.Tracks.Add(new Track(result));
                }
            }

            if (includeApps)
            {
                url = string.Format(Constants.SearchUrlAppFormat, locale, searchQuery);
                var apXml = await HttpClient.GetStringAsync(url);
                var apResults = ParseXml<ZuneAppSearch.feed>(apXml);
                foreach (var result in apResults.entry)
                {
                    searchResult.StoreApps.Add(new StoreApp(result));
                }
            }

            return searchResult;
        }

        /// <summary>
        /// Gets the artist info async.
        /// </summary>
        /// <param name="artistId">The artist id.</param>
        /// <param name="locale">sets the locale to do the search on. If null or empty, it uses what's set for Locale</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Artist Id cannot be null or empty</exception>
        public async Task<Artist> GetArtistInfoAsync(string artistId, string locale = null)
        {
            if (string.IsNullOrEmpty(artistId))
            {
                throw new NullReferenceException("Artist Id cannot be null or empty");
            }

            locale = string.IsNullOrEmpty(locale) ? Locale : locale;

            // Get the main artist information
            var url = string.Format(Constants.ArtistUrlFormat, locale, artistId, "");

            var xml = await HttpClient.GetStringAsync(url);

            var mainInfoResult = ParseXml<ZuneArtistSearch.feedEntry>(xml);

            var result = new Artist(mainInfoResult);

            // Now get the biography information
            url += "biography";

            xml = await HttpClient.GetStringAsync(url);

            var biographyResult = ParseXml<ZuneArtist.entry>(xml);

            result.Content = biographyResult.content.Value;

            return result;
        }

        /// <summary>
        /// Gets the albums for artist async.
        /// </summary>
        /// <param name="artistId">The artist id.</param>
        /// <param name="locale">sets the locale to do the search on. If null or empty, it uses what's set for Locale</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Artist Id cannot be null or empty</exception>
        public async Task<AlbumCollection> GetAlbumsForArtistAsync(string artistId, string locale = null)
        {
            if (string.IsNullOrEmpty(artistId))
            {
                throw new NullReferenceException("Artist Id cannot be null or empty");
            }

            locale = string.IsNullOrEmpty(locale) ? Locale : locale;

            var url = string.Format(Constants.ArtistUrlFormat, locale, artistId, "albums");

            var xml = await HttpClient.GetStringAsync(url);

            var result = ParseXml<ZuneAlbumSearch.albumFeed>(xml);

            var returnList = new AlbumCollection(result.entry.Select(r => new Album(r)).ToList());

            return returnList;
        }

        /// <summary>
        /// Gets the album info async.
        /// </summary>
        /// <param name="albumId">The album id.</param>
        /// <param name="locale">sets the locale to do the search on. If null or empty, it uses what's set for Locale</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Album Id cannot be null or empty</exception>
        public async Task<Album> GetAlbumInfoAsync(string albumId, string locale = null)
        {
            if (string.IsNullOrEmpty(albumId))
            {
                throw new NullReferenceException("Album Id cannot be null or empty");
            }

            locale = string.IsNullOrEmpty(locale) ? Locale : locale;

            var url = string.Format(Constants.AlbumUrlFormat, locale, albumId);

            var xml = await HttpClient.GetStringAsync(url);

            var result = ParseXml<ZuneAlbum.feed>(xml);

            return new Album(result);
        }

        /// <summary>
        /// Gets the apps list async.
        /// </summary>
        /// <param name="searchBy">The search by.</param>
        /// <param name="costType">Type of the cost.</param>
        /// <param name="includeGames">if set to <c>true</c> [include games].</param>
        /// <param name="categoryId">The category id.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="locale">The locale.</param>
        /// <returns></returns>
        public async Task<StoreAppCollection> GetAppsListAsync(SearchBy searchBy = SearchBy.Popular,
                                                               CostType costType = CostType.Free,
                                                               bool includeGames = false,
                                                               string categoryId = null,
                                                               //int maxNumberOfAppsToReturn = 20,
                                                               int pageNumber = 1,
                                                               string locale = null)
        {
            locale = string.IsNullOrEmpty(locale) ? Locale : locale;

            if (costType == CostType.Free || costType == CostType.Paid)
            {
                var url = CreateAppListUrl(searchBy, costType, includeGames, pageNumber, locale, categoryId);

                var xml = await HttpClient.GetStringAsync(url);

                var storeResults = ParseXml<ZuneAppSearch.appListFeed>(xml);

                var results = new StoreAppCollection(storeResults.entry.Select(x => new StoreApp(x)).ToList());
                results.ProcessLinks(storeResults.link);

                return results;
            }
            else
            {
                var url = CreateAppListUrl(searchBy, CostType.Free, includeGames, pageNumber, locale);

                var xml = await HttpClient.GetStringAsync(url);

                var storeResults = ParseXml<ZuneAppSearch.appListFeed>(xml);

                var results = new StoreAppCollection(storeResults.entry.Select(x => new StoreApp(x)).ToList());

                url = CreateAppListUrl(searchBy, CostType.Paid, includeGames, pageNumber, locale);

                xml = await HttpClient.GetStringAsync(url);

                storeResults = ParseXml<ZuneAppSearch.appListFeed>(xml);
                results.AddRange(storeResults.entry.Select(x => new StoreApp(x)));

                return results;
            }
        }

        /// <summary>
        /// Gets the app categories async.
        /// </summary>
        /// <param name="locale">The locale.</param>
        /// <returns></returns>
        public async Task<CategoryCollection> GetAppCategoriesAsync(string locale = null)
        {
            locale = string.IsNullOrEmpty(locale) ? Locale : locale;

            var url = string.Format(Constants.CategoryListUrlFormat, locale);

            var xml = await HttpClient.GetStringAsync(url);

            var results = ParseXml<ZuneCategories.feed>(xml);

            var returnList = new CategoryCollection(results.entry.Select(x => new Category(x)).ToList());

            return returnList;
        }

        /// <summary>
        /// Gets the music genres async.
        /// </summary>
        /// <param name="locale">The locale.</param>
        /// <returns></returns>
        public async Task<CategoryCollection> GetMusicGenresAsync(string locale = null)
        {
            locale = string.IsNullOrEmpty(locale) ? Locale : locale;

            var url = string.Format(Constants.GenreListUrlFormat, locale);

            var xml = await HttpClient.GetStringAsync(url);

            var result = ParseXml<ZuneCategories.feed>(xml);

            var resultList = new CategoryCollection(result.entry.Select(x => new Category(x)).ToList());

            return resultList;
        }

        /// <summary>
        /// Gets the albums by genre.
        /// </summary>
        /// <param name="genreId">The genre id.</param>
        /// <param name="musicSearchBy">The music search by.</param>
        /// <param name="marker">The next/previous marker to get more items</param>
        /// <param name="locale">The locale.</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Genre Id cannot be null or empty</exception>
        public async Task<AlbumCollection> GetAlbumsByGenre(string genreId, MusicSearchBy musicSearchBy = MusicSearchBy.SalesRank, string marker = "afterMarker=CgAAAA%3d%3d", string locale = null)
        {
            if (string.IsNullOrEmpty(genreId))
            {
                throw new NullReferenceException("Genre Id cannot be null or empty");
            }

            //http://catalog.zune.net/v3.2/{0}/music/genre/{1}/{2}?orderby={3}&chunksize=10
            locale = string.IsNullOrEmpty(locale) ? Locale : locale;

            var url = string.Format(Constants.ItemsByGenreUrlFormat, locale, genreId, "albums", musicSearchBy.ToString(), marker);

            var xml = await HttpClient.GetStringAsync(url);

            var result = ParseXml<ZuneAlbumSearch.feed>(xml);

            var resultList = new AlbumCollection(result.entry.Select(x => new Album(x)).ToList());
            resultList.ProcessLinks(result.link);

            return resultList;
        }

        /// <summary>
        /// Gets the artists by genre.
        /// </summary>
        /// <param name="genreId">The genre id.</param>
        /// <param name="musicSearchBy">The music search by.</param>
        /// <param name="marker">The next/previous marker to get next/previous items</param>
        /// <param name="locale">The locale.</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Genre Id cannot be null or empty</exception>
        public async Task<ArtistCollection> GetArtistsByGenre(string genreId, MusicSearchBy musicSearchBy = MusicSearchBy.SalesRank, string marker = "afterMarker=CgAAAA%3d%3d", string locale = null)
        {
            if (string.IsNullOrEmpty(genreId))
            {
                throw new NullReferenceException("Genre Id cannot be null or empty");
            }

            locale = string.IsNullOrEmpty(locale) ? Locale : locale;

            var url = string.Format(Constants.ItemsByGenreUrlFormat, locale, genreId, "artists", musicSearchBy.ToString(), marker);

            var xml = await HttpClient.GetStringAsync(url);

            var result = ParseXml<ZuneArtistSearch.feed>(xml);

            var resultList = new ArtistCollection(result.entry.Select(x => new Artist(x)).ToList());
            resultList.ProcessLinks(result.link);

            return resultList;
        }

        /// <summary>
        /// Gets the app info async.
        /// </summary>
        /// <param name="appId">The app id.</param>
        /// <param name="locale">sets the locale to do the search on. If null or empty, it uses what's set for Locale</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Album Id cannot be null or empty</exception>
        public async Task<StoreApp> GetAppInfoAsync(string appId, string locale = null)
        {
            if (string.IsNullOrEmpty(appId))
            {
                throw new NullReferenceException("Album Id cannot be null or empty");
            }

            locale = string.IsNullOrEmpty(locale) ? Locale : locale;

            var url = string.Format(Constants.AppUrlFormat, appId, locale);

            var xml = await HttpClient.GetStringAsync(url);

            var result = ParseXml<ZuneApp.feed>(xml);

            return new StoreApp(result);
        }

        /// <summary>
        /// Creates the artist's background URL.
        /// </summary>
        /// <param name="artist">The artist.</param>
        /// <param name="screenSize">Size of the screen.</param>
        /// <returns></returns>
        public string CreateArtistBackgroundUrl(Artist artist, ScreenSize screenSize)
        {
            return CreateArtistBackgroundUrl(artist.Id, screenSize);
        }

        /// <summary>
        /// Creates the artist's background URL.
        /// </summary>
        /// <param name="artistId">The artist id.</param>
        /// <param name="screenSize">Size of the screen.</param>
        /// <returns></returns>
        public string CreateArtistBackgroundUrl(string artistId, ScreenSize screenSize)
        {
            return string.Format(Constants.ArtistBackgroundUrlFormat, Locale, artistId, screenSize.ToEnumString());
        }

        /// <summary>
        /// Creates the album art URL.
        /// </summary>
        /// <param name="album">The album.</param>
        /// <returns></returns>
        public string CreateAlbumArtUrl(Album album)
        {
            return CreateAlbumArtUrl(album.ImageId);
        }

        /// <summary>
        /// Creates the album art URL.
        /// </summary>
        /// <param name="albumImageId">The album image id.</param>
        /// <returns></returns>
        public string CreateAlbumArtUrl(string albumImageId)
        {
            return string.Format(Constants.AlbumArtUrlFormat, Locale, albumImageId);
        }

        /// <summary>
        /// Creates the app image URL.
        /// </summary>
        /// <param name="imageId">The image id.</param>
        /// <param name="imageType">The image type.</param>
        /// <returns></returns>
        public string CreateAppImageUrl(string imageId, ImageType imageType)
        {
            var formatType = "";

            switch (imageType)
            {
                case ImageType.IconLarge:
                    formatType = "icon_large";
                    break;
                case ImageType.IconSmall:
                    formatType = "icon_small";
                    break;
                case ImageType.Screenshot:
                    formatType = "screenshot";
                    break;
                case ImageType.ScreenshotThumbnail:
                    formatType = "screenshot_thumbnail";
                    break;
                case ImageType.BackgroundArt:
                    formatType = "background_art";
                    break;
                case ImageType.WindowsPhoneStoreMedium:
                    formatType = "ws_icon_large";
                    break;
                case ImageType.WindowsPhoneStoreSmall:
                    formatType = "ws_icon_small";
                    break;
                case ImageType.WindowsPhoneStoreLarge:
                    formatType = "ws_icon_medium"; // For some reason, the medium image is bigger than the large image. Meh.
                    break;
            }

            return string.Format(Constants.ScreenshotUrlFormat, imageId, formatType);
        }


        private static string CreateAppListUrl(SearchBy searchBy,
                                               CostType costType,
                                               bool includeGames = false,
            //int maxNumberOfAppsToReturn = 20,
                                               int pageNumber = 1,
                                               string locale = null,
                                               string categoryId = null)
        {
            var url = string.Format(Constants.AppListUrlFormat,
                                    pageNumber * 10,
                                    locale,
                                    includeGames ? "" : "windowsphone.games",
                                    searchBy.ToString(),
                                    costType.ToString());

            if (!string.IsNullOrEmpty(categoryId)) url += string.Format("&category={0}", categoryId);

            return url;
        }

        internal static T ParseXml<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xml))
            {
                var result = (T)serializer.Deserialize(reader);
                return result;
            }
        }
    }
}
