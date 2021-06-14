using SpotifyAPI.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtyTunes3.Models
{
    public class APIConn
    {
        string token = "BQDD1wlyS6RYZcW4Lv1UpHBLfkKSTDaUkx2Yw-1cgLl3Ninb03xvBA2Zjim6Oyb94Ndtx5m0NFLdwsw-g4DTnSIVqMJnnTW5a1qlmGXYAXA91YpR7hdTy659L5GI70Th5Okx4HY5jULXXCs";
        public async Task Conn()
        {
            
        }

        /*public async Task RetrieveSongs()
        {
            TFVContext context = new TFVContext();
            List<TrackForView> t = new List<TrackForView>();
            var spotify = new SpotifyClient(token);
      
            for (int i = 0; i<2000; i+=50)
            {
                string query = $"q = 'year:2018', limit=50, offset={i}";
                SpotifyAPI.Web.Paging<FullTrack> tracks = await spotify.Search.Item(new SearchRequest(SearchRequest.Types.Track, query));
                foreach (var x in tracks.t)
            }
        }*/
    }
}
