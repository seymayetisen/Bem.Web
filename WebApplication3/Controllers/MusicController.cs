using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class MusicControllerr : Controller
    {
        // GET: Tiyatro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guncel()
        {
            var musicListesi = new List<Etkinlik>();

            foreach (var music in EtkinlikRepository.ListeyiDoldur())
            {
                if (music.EtkinlikTuru == EtkinlikTuru.Muzik)
                {
                    musicListesi.Add(music);
                }
            }

            return View("~/views/_shared/guncel.cshtml", musicListesi);
        }
    }
}