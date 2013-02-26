﻿using System.Collections.Generic;

namespace ZuneSearchClient.Entities
{
    public class SearchResult
    {
        public SearchResult()
        {
            Albums = new List<Album>();
            Tracks = new List<Track>();
            Artists = new List<Artist>();
        }

        public List<Album> Albums { get; set; }
        public List<Track> Tracks { get; set; }
        public List<Artist> Artists { get; set; }
    }
}