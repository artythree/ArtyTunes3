using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ArtyTunes3.Models;

namespace ArtyTunes3.Data
{
    public class ArtyTunes3Context : DbContext
    {
        public ArtyTunes3Context (DbContextOptions<ArtyTunes3Context> options)
            : base(options)
        {
        }

        public DbSet<ArtyTunes3.Models.TrackForView> TrackForView { get; set; }
    }
}
