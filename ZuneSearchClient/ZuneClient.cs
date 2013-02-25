using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AdvancedREI.Net.Http.Compression;
using ZuneSearchClient.Entities;

namespace ZuneSearchClient
{
    public class ZuneClient
    {
        public HttpClient HttpClient { get; private set; }

        public ZuneClient(HttpMessageHandler handler)
        {
            HttpClient = new HttpClient(handler);
        }

        public ZuneClient()
        {
            HttpClient = new HttpClient(new CompressedHttpClientHandler());
        }

        public async Task<List<SearchResult>> SearchAsync(string searchQuery, bool includeAlbums = true, bool includeArtists = true, bool includeTracks = true, bool includePodcasts = true)
        {
            if (string.IsNullOrEmpty(searchQuery))
            {
                throw new NullReferenceException("SearchQuery cannot be null or empty");
            }

            var url = string.Format(Constants.SearchUrlFormat, searchQuery,
                                    false,
                                    includeAlbums,
                                    includeArtists,
                                    includeTracks,
                                    includePodcasts
                );

            var xml = await HttpClient.GetStringAsync(url);

            var results = ParseXml<ZuneSearchResults>(xml);

            var resultList = results.Entries.Select(r => r.Result).ToList();

            return resultList;
        }

        public async Task<ZuneArtist> GetArtistInfoAsync(string artistId)
        {
            if (string.IsNullOrEmpty(artistId))
            {
                throw new NullReferenceException("Artist Id cannot be null or empty");
            }

            var url = string.Format(Constants.ArtistUrlFormat, artistId, "biography");

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

            var url = string.Format(Constants.ArtistUrlFormat, artistId, "albums");

            var xml = await HttpClient.GetStringAsync(url);

            var result = ParseXml<ZuneAlbumResults>(xml);

            var returnList = result.Entries.Select(r => r.Result).ToList();

            return returnList;
        }

        public async Task<Album> GetAlbumInfoAsync(string albumId)
        {
            if (string.IsNullOrEmpty(albumId))
            {
                throw new NullReferenceException("Album Id cannot be null or empty");
            }

            var url = string.Format(Constants.AlbumUrlFormat, albumId);

            var xml = await HttpClient.GetStringAsync(url);

            var result = ParseXml<ZuneAlbum>(xml);

            return result.Result;
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

            return string.Format(Constants.ArtistBackgroundUrlFormat, artistId, height);
        }

        public string CreateAlbumArtUrl(Album album)
        {
            return CreateAlbumArtUrl(album.ImageId);
        }

        public string CreateAlbumArtUrl(string albumImageId)
        {
            return string.Format(Constants.AlbumArtUrlFormat, albumImageId);
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
