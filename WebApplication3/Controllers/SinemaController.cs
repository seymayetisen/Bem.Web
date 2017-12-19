using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class SinemaController : Controller
    {
        // GET: Sinema
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guncel()
        {
            var sinemaListesi = new List<Etkinlik>();

            foreach (var sinema in EtkinlikRepository.ListeyiDoldur())
            {
                if ( sinema.EtkinlikTuru == EtkinlikTuru.Sinema)
                {
                    sinemaListesi.Add(sinema);
                }
            }

            //return View();
            //return View(sinemaListesi);
            return View("~/views/_shared/guncel.cshtml", sinemaListesi);
        }

        public ActionResult Tur(string tur)
        {
            var sinemaListesi = new List<Etkinlik>();

            foreach (var sinema in EtkinlikRepository.ListeyiDoldur())
            {
                if (sinema.AltTur == tur && sinema.EtkinlikTuru == EtkinlikTuru.Sinema)
                {
                    sinemaListesi.Add(sinema);
                }
            }

            return View("~/views/_shared/guncel.cshtml", sinemaListesi);
        }

        public ActionResult Bugun()
        {
            var sinemaListesi = new List<Etkinlik>();

            foreach (var sinema in EtkinlikRepository.ListeyiDoldur())
            {
                if (sinema.EtkinlikTuru == EtkinlikTuru.Sinema && sinema.BaslangicTarihi<= DateTime.Now && sinema.BitisTarihi>= DateTime.Now)
                {
                    sinemaListesi.Add(sinema);
                }
            }
            return View("~/views/_shared/guncel.cshtml", sinemaListesi);
        }

        public ActionResult Buhafta()
        {
            var sinemaListesi = new List<Etkinlik>();

            foreach (var sinema in EtkinlikRepository.ListeyiDoldur())
            {
                if (sinema.EtkinlikTuru == EtkinlikTuru.Sinema && sinema.BaslangicTarihi <= DateTime.Now && sinema.BitisTarihi >= DateTime.Now.AddDays(7))
                {
                    sinemaListesi.Add(sinema);
                }
            }
            return View("~/views/_shared/guncel.cshtml", sinemaListesi);
        }


        public ActionResult Buay()
        {
            var sinemaListesi = new List<Etkinlik>();

            foreach (var sinema in EtkinlikRepository.ListeyiDoldur())
            {
                if (sinema.EtkinlikTuru == EtkinlikTuru.Sinema && sinema.BaslangicTarihi <= DateTime.Now && sinema.BitisTarihi.Year == DateTime.Now.Year && sinema.BitisTarihi.Month == DateTime.Now.Month)
                {
                    sinemaListesi.Add(sinema);
                }
            }
            return View("~/views/_shared/guncel.cshtml", sinemaListesi);
        }
        
        public ActionResult Aralik(string tarih1,string tarih2)
        {
            var sinemaListesi = new List<Etkinlik>();

            foreach (var sinema in EtkinlikRepository.ListeyiDoldur())
            {
                if (sinema.EtkinlikTuru == EtkinlikTuru.Sinema && sinema.BaslangicTarihi <= DateTime.Parse(tarih1) && sinema.BitisTarihi >= DateTime.Parse(tarih2))
                {
                    sinemaListesi.Add(sinema);
                }
            }
            return View("~/views/_shared/guncel.cshtml", sinemaListesi);
        }
        //public ActionResult bugun()
        //{
        //    var sinemaListesi = new List<Etkinlik>();
            

        //    foreach (var sinema in EtkinlikRepository.ListeyiDoldur())
        //    {
        //        if (sinema.BitisTarihi == DateTime.Now && sinema.EtkinlikTuru == EtkinlikTuru.Sinema)
        //        {

        //            sinemaListesi.Add(sinema);
        //        }
        //    }
            
        //    return View("~/views/_shared/guncel.cshtml", sinemaListesi);
        //}
        //public ActionResult buHafta()
        //{
        //    return View("~/views/_shared/guncel.cshtml", Zmnfiltrele(DateTime.Now.AddDays(7)));
        //}
        //public ActionResult buay()
        //{
        //    return View("~/views/_shared/guncel.cshtml", Zmnfiltrele(DateTime.Now.AddMonths(1)));
        //}
        //public List<Etkinlik> Zmnfiltrele(DateTime t)
        //{
        //    var sinemaListesi = new List<Etkinlik>();

        //    foreach (var sinema in EtkinlikRepository.ListeyiDoldur())
        //    {
        //        if (sinema.BitisTarihi < t && sinema.EtkinlikTuru == EtkinlikTuru.Sinema)
        //        {

        //            sinemaListesi.Add(sinema);
        //        }
        //    }

        //    return sinemaListesi;
        //}
        
       

    }
}