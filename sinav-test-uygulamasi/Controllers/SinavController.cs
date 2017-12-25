using Newtonsoft.Json;
using sinav_test_uygulamasi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sinav_test_uygulamasi.Controllers
{
    public class SinavController : Controller
    {
        // GET: Sinav
        public ActionResult Index(string sinavAdi)
        {
            //var sinavSonuc = new SinavSonuc();

            //sinavSonuc.Sinav = SinavRepository.SinavBul(sinavAdi);
            //sinavSonuc.Kisi = new Kisi
            //                    {
            //                        Isim = "Ahmet",
            //                        Soyisim = "Mehmet",
            //                        TcKimlikNo = "12345678912"
            //                    };
            //ViewBag.SinavAdi = sinavAdi;
            //return View(sinavSonuc);

            ViewBag.Url = sinavAdi;
            return View();
        }

        public ActionResult Cevapla(string sinavAdi)
        {
            var sinavSonuc = new SinavSonuc();

            sinavSonuc.Sinav = SinavRepository.SinavBul("deneme-sinavi-1");
            sinavSonuc.Kisi = new Kisi
            {
                Isim = "Ahmet",
                Soyisim = "Mehmet",
                TcKimlikNo = "12345678912"
            };
            ViewBag.SinavAdi = sinavAdi;


            //return Content(JsonConvert.SerializeObject(sinavSonuc));
            return Json(sinavSonuc, JsonRequestBehavior.AllowGet);
        }

        public JsonResult SorulariGetir(string sinavAdi)
        {
            var sinav = SinavRepository.SinavBul(sinavAdi);
            //MvcApplication.Sonuclar.Add("");
            return Json(sinav.Sorular, JsonRequestBehavior.AllowGet);
            
        }

        public ActionResult SinavListesi()
        {
            return View();
        }


        public ActionResult SinavDurumu()
        {
            return View();
        }
    }
}