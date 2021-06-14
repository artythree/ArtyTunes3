using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ArtyTunes3.Models
{
    public class TrackForView
    {
        [Key]
        public int Id { get; set; }
        public string Artist_Name { get; set; }
        public string Song_Name { get; set; }
        public int Duration { get; set; }
        public int Popularity { get; set; }

    }
    public class TFVContext : System.Data.Entity.DbContext
    {
        public IDbSet<TrackForView> TFV { get; set; }


    }
}
