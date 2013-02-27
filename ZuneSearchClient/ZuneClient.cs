using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AdvancedREI.Net.Http.Compression;
using ZuneSearchClient.Entities;
using ZuneSearchClient.Entities.Zune;

namespace ZuneSearchClient
{
    public class ZuneClient
    {
        public HttpClient HttpClient { get; private set; }
        public string Locale { get; set; }

        public ZuneClient(HttpMessageHandler handler)
        {
            HttpClient = new HttpClient(handler);
            Locale = "en-US";
        }

        public ZuneClient()
        {
            HttpClient = new HttpClient(new CompressedHttpClientHandler());
            Locale = "en-US";
        }

        public async Task<SearchResult> SearchAsync(string searchQuery, bool includeAlbums = true, bool includeArtists = true, bool includeTracks = true, bool includePodcasts = true, bool includeApps = true)
        {
            if (string.IsNullOrEmpty(searchQuery))
            {
                throw new NullReferenceException("SearchQuery cannot be null or empty");
            }

            var url = "";

            var searchResult = new SearchResult();

            if (includeAlbums)
            {
                url = string.Format(Constants.SearchUrlMusicFormatSecondary, Locale, "album", searchQuery);
                var alXml = await HttpClient.GetStringAsync(url);
                var alResults = ParseXml<ZuneAlbumSearch.feed>(alXml);
                foreach (var result in alResults.entry)
                {
                    searchResult.Albums.Add(new Album(result));
                }
            }

            if (includeArtists)
            {
                url = string.Format(Constants.SearchUrlMusicFormatSecondary, Locale, "artist", searchQuery);
                var arXml = await HttpClient.GetStringAsync(url);
                var arResults = ParseXml<ZuneArtistSearch.feed>(arXml);
                foreach (var result in arResults.entry)
                {
                    searchResult.Artists.Add(new Artist(result));
                }
            }

            if (includeTracks)
            {
                url = string.Format(Constants.SearchUrlMusicFormatSecondary, Locale, "track", searchQuery);
                var trXml = await HttpClient.GetStringAsync(url);
                var trResults = ParseXml<ZuneTrack.feed>(trXml);
                foreach (var result in trResults.entry)
                {
                    searchResult.Tracks.Add(new Track(result));
                }
            }

            if (includeApps)
            {
                url = string.Format(Constants.SearchUrlAppFormat, Locale, searchQuery);
                var apXml = await HttpClient.GetStringAsync(url);
                var apResults = ParseXml<ZuneAppSearch.feed>(apXml);
                foreach (var result in apResults.entry)
                {
                    searchResult.StoreApps.Add(new StoreApp(result));
                }
            }

            return searchResult;
        }

        public async Task<ZuneArtist> GetArtistInfoAsync(string artistId)
        {
            if (string.IsNullOrEmpty(artistId))
            {
                throw new NullReferenceException("Artist Id cannot be null or empty");
            }

            var url = string.Format(Constants.ArtistUrlFormat, Locale, artistId, "biography");

            var xml = await HttpClient.GetStringAsync(url);

            var result = ParseXml<ZuneArtist>(xml);

            return result;
        }

        public async Task<List<Album>> GetAlbumsForArtistAsync(string artistId)
        {
            if (string.IsNullOrEmpty(artistId))
            {
                throw new NullReferenceException("Artist Id cannot be null or empty");
            }

            var url = string.Format(Constants.ArtistUrlFormat, Locale, artistId, "albums");

            var xml = await HttpClient.GetStringAsync(url);

            var result = ParseXml<ZuneAlbumSearch.albumFeed>(xml);

            var returnList = result.entry.Select(r => new Album(r)).ToList();

            return returnList;
        }

        public async Task<Album> GetAlbumInfoAsync(string albumId)
        {
            if (string.IsNullOrEmpty(albumId))
            {
                throw new NullReferenceException("Album Id cannot be null or empty");
            }

            var url = string.Format(Constants.AlbumUrlFormat, Locale, albumId);

            var xml = await HttpClient.GetStringAsync(url);

            var result = ParseXml<ZuneAlbum.feed>(xml);

            return new Album(result);
        }

        public string CreateArtistBackgroundUrl(Artist artist, ScreenSize screenSize)
        {
            return CreateArtistBackgroundUrl(artist.Id, screenSize);
        }

        public string CreateArtistBackgroundUrl(string artistId, ScreenSize screenSize)
        {
            var height = "480";
            switch (screenSize)
            {
                case ScreenSize.SevenTwentyP:
                    height = "720";
                    break;
                case ScreenSize.Wvga:
                    height = "480";
                    break;
                case ScreenSize.Wxga:
                    height = "768";
                    break;
            }

            return string.Format(Constants.ArtistBackgroundUrlFormat, Locale, artistId, height);
        }

        public string CreateAlbumArtUrl(Album album)
        {
            return CreateAlbumArtUrl(album.ImageId);
        }

        public string CreateAlbumArtUrl(string albumImageId)
        {
            return string.Format(Constants.AlbumArtUrlFormat, Locale, albumImageId);
        }

        private static T ParseXml<T>(string xml)
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
