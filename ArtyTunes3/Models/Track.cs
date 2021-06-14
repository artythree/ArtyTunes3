using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtyTunes3.Models
{
    public class Track
    {
        public string genre { get; set; }
        public string artist_name { get; set; }
        public string track_name { get; set; }
        public string track_id { get; set; }
        public int popularity { get; set; }
        public string acousticness { get; set; }
        public string danceability { get; set; }
        public int duration_ms { get; set; }
        public string energy { get; set; }
        public string instrumentalness { get; set; }
        public string key { get; set; }
        public string liveness { get; set; }
        public string loudness { get; set; }
        public string mode { get; set; }
        public string speechiness { get; set; }
        public string tempo { get; set; }
        public string time_signature { get; set; }
        public string valence { get; set; }

    }
}

