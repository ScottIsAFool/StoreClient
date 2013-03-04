using System.Threading.Tasks;
using StoreClient.Entities;

namespace StoreClient
{
    public interface IStoreApiClient
    {
        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        /// <value>
        /// The locale.
        /// </value>
        string Locale { get; set; }

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
        Task<SearchResult> SearchAsync(string searchQuery, string locale = null, bool includeAlbums = true, bool includeArtists = true, bool includeTracks = true, bool includePodcasts = true, bool includeApps = true);

        /// <summary>
        /// Gets the artist info async.
        /// </summary>
        /// <param name="artistId">The artist id.</param>
        /// <param name="locale">sets the locale to do the search on. If null or empty, it uses what's set for Locale</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Artist Id cannot be null or empty</exception>
        Task<Artist> GetArtistInfoAsync(string artistId, string locale = null);

        /// <summary>
        /// Gets the albums for artist async.
        /// </summary>
        /// <param name="artistId">The artist id.</param>
        /// <param name="locale">sets the locale to do the search on. If null or empty, it uses what's set for Locale</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Artist Id cannot be null or empty</exception>
        Task<AlbumCollection> GetAlbumsForArtistAsync(string artistId, string locale = null);

        /// <summary>
        /// Gets the album info async.
        /// </summary>
        /// <param name="albumId">The album id.</param>
        /// <param name="locale">sets the locale to do the search on. If null or empty, it uses what's set for Locale</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Album Id cannot be null or empty</exception>
        Task<Album> GetAlbumInfoAsync(string albumId, string locale = null);

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
        Task<StoreAppCollection> GetAppsListAsync(SearchBy searchBy = SearchBy.Popular,
                                                  CostType costType = CostType.Free,
                                                  bool includeGames = false,
                                                  string categoryId = null,
                                                  //int maxNumberOfAppsToReturn = 20,
                                                  int pageNumber = 1,
                                                  string locale = null);

        /// <summary>
        /// Gets the app categories async.
        /// </summary>
        /// <param name="locale">The locale.</param>
        /// <returns></returns>
        Task<CategoryCollection> GetAppCategoriesAsync(string locale = null);

        /// <summary>
        /// Gets the music genres async.
        /// </summary>
        /// <param name="locale">The locale.</param>
        /// <returns></returns>
        Task<CategoryCollection> GetMusicGenresAsync(string locale = null);

        /// <summary>
        /// Gets the albums by genre.
        /// </summary>
        /// <param name="genreId">The genre id.</param>
        /// <param name="musicSearchBy">The music search by.</param>
        /// <param name="marker">The next/previous marker to get more items</param>
        /// <param name="locale">The locale.</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Genre Id cannot be null or empty</exception>
        Task<AlbumCollection> GetAlbumsByGenreAsync(string genreId, MusicSearchBy musicSearchBy = MusicSearchBy.SalesRank, string marker = "afterMarker=CgAAAA%3d%3d", string locale = null);

        /// <summary>
        /// Gets the artists by genre.
        /// </summary>
        /// <param name="genreId">The genre id.</param>
        /// <param name="musicSearchBy">The music search by.</param>
        /// <param name="marker">The next/previous marker to get next/previous items</param>
        /// <param name="locale">The locale.</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Genre Id cannot be null or empty</exception>
        Task<ArtistCollection> GetArtistsByGenreAsync(string genreId, MusicSearchBy musicSearchBy = MusicSearchBy.SalesRank, string marker = "afterMarker=CgAAAA%3d%3d", string locale = null);

        /// <summary>
        /// Gets the tracks by genre.
        /// </summary>
        /// <param name="genreId">The genre id.</param>
        /// <param name="musicSearchBy">The music search by.</param>
        /// <param name="marker">The next/previous marker to get next/previous items</param>
        /// <param name="locale">The locale.</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Genre Id cannot be null or empty</exception>
        Task<TrackCollection> GetTracksByGenreAsync(string genreId, MusicSearchBy musicSearchBy = MusicSearchBy.SalesRank, string marker = "afterMarker=CgAAAA%3d%3d", string locale = null);

        /// <summary>
        /// Gets the app info async.
        /// </summary>
        /// <param name="appId">The app id.</param>
        /// <param name="locale">sets the locale to do the search on. If null or empty, it uses what's set for Locale</param>
        /// <returns></returns>
        /// <exception cref="System.NullReferenceException">Album Id cannot be null or empty</exception>
        Task<StoreApp> GetAppInfoAsync(string appId, string locale = null);

        /// <summary>
        /// Creates the artist's background URL.
        /// </summary>
        /// <param name="artist">The artist.</param>
        /// <param name="screenSize">Size of the screen.</param>
        /// <returns></returns>
        string CreateArtistBackgroundUrl(Artist artist, ScreenSize screenSize);

        /// <summary>
        /// Creates the artist's background URL.
        /// </summary>
        /// <param name="artistId">The artist id.</param>
        /// <param name="screenSize">Size of the screen.</param>
        /// <returns></returns>
        string CreateArtistBackgroundUrl(string artistId, ScreenSize screenSize);

        /// <summary>
        /// Creates the album art URL.
        /// </summary>
        /// <param name="album">The album.</param>
        /// <returns></returns>
        string CreateAlbumArtUrl(Album album);

        /// <summary>
        /// Creates the album art URL.
        /// </summary>
        /// <param name="albumImageId">The album image id.</param>
        /// <returns></returns>
        string CreateAlbumArtUrl(string albumImageId);

        /// <summary>
        /// Creates the app image URL.
        /// </summary>
        /// <param name="imageId">The image id.</param>
        /// <param name="imageType">The image type.</param>
        /// <returns></returns>
        string CreateAppImageUrl(string imageId, ImageType imageType);
    }
}