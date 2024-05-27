using NMHLesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NMHLesson06.Controllers
{
    public class NMHSongController : Controller
    {
        private static List<NMHSong> nmhSongs = new List<NMHSong>()
        {
            new NMHSong{id=100,NMHTitle="Nguyen Minh Hiep",NMHAuthor="K22CNTT1",NMHArtist="Hiep Hiep",NMHYearRelease=2024},
            new NMHSong{id=101,NMHTitle="Love Song",NMHAuthor="K22CNTT1",NMHArtist="Hiep Hiep",NMHYearRelease=2004},

        };
        // GET: NMHSong
        public ActionResult Index()
        {
            return View(nmhSongs);
        }

        // Get:create Song
        public ActionResult NMHCreate()
        {
            var NMHSong = new NMHSong();
            return View(NMHSong);
        }
        //Post Create Song
        [HttpPost]
        public ActionResult NMHCreate(NMHSong nmhSong)
        {
            if(!ModelState.IsValid)
                {
                return View(nmhSong);
            }
            nmhSongs.Add(nmhSong);
            return RedirectToAction("Index");
        }
    }
}