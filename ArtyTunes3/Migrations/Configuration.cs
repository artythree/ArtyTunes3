namespace ArtyTunes3.Migrations
{
    using ArtyTunes3.Models;
    using CsvHelper;
    using CsvHelper.Configuration;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    internal sealed class Configuration : DbMigrationsConfiguration<ArtyTunes3.Models.TFVContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ArtyTunes3.Models.TFVContext context)
        {
            //underneath is my seed method, it was looping for some reason and despite days of debugging I can't figure it out.
            /*{
                
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
                        List<TrackForView> t = new List<TrackForView>();
                        foreach (Track track in tracks)
                        {
                            TrackForView trackFV = new TrackForView();
                            trackFV.Artist_Name = track.artist_name;
                            trackFV.Duration = track.duration_ms;
                            trackFV.Popularity = track.popularity;
                            trackFV.Song_Name = track.track_name;

                            t.Add(trackFV);
                        }
                        context.TFV.AddOrUpdate(c => c.Song_Name, t.ToArray());
                    }
                }
            }*/
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
