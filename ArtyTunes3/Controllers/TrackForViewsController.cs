using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArtyTunes3.Data;
using ArtyTunes3.Models;

namespace ArtyTunes3.Controllers
{
    public class TrackForViewsController : Controller
    {
        private readonly ArtyTunes3Context _context;

        public TrackForViewsController(ArtyTunes3Context context)
        {
            _context = context;
        }

        // GET: TrackForViews
        public async Task<IActionResult> Index()
        {
            return View(await _context.TrackForView.ToListAsync());
        }

        // GET: TrackForViews/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trackForView = _context.TrackForView.Where(m => m.Artist_Name == id||m.Song_Name == id);

            if (trackForView == null)
            {
                return NotFound();
            }

            return View(trackForView);
        }

        public ActionResult AverageDuration()
        {
            int count = _context.TrackForView.Count();
            int durationHolder = 0;
            foreach (var x in _context.TrackForView)
            {
                durationHolder += x.Duration;
            };
            if (count == 0)
            {
                return View(0);
            }
            int avgDuration = durationHolder / count;

            return View(avgDuration);
        }
        public ActionResult<IQueryable<TrackForView>> PopularSongs()
        {
            var trackForView = _context.TrackForView.Where(m => m.Popularity == 100);

            return View(trackForView);
        }
    }
}
