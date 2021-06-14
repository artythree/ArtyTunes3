using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArtyTunes3.Models
{
    public class CSVParser
    {
        public void Parser()
        {
            TFVContext context = new TFVContext();
            Assembly assembly = Assembly.GetExecutingAssembly();
            string resourceName = "ArtyTunes3.Models.Seed_Data.SpotifyFeatures.csv";
            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            //config.HeaderValidated = null; 
            //config.MissingFieldFound = null;
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    CsvReader csvReader = new CsvReader(reader, config);
                    var tracks = csvReader.GetRecords<Track>().ToArray();
                    foreach (Track track in tracks)
                    {
                        TrackForView trackFV = new TrackForView();
                        trackFV.Artist_Name = track.artist_name;
                        trackFV.Duration = track.duration_ms;
                        trackFV.Popularity = track.popularity;
                        trackFV.Song_Name = track.track_name;

                        context.TFV.Add(trackFV);
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
