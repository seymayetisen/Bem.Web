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
            var sinavSonuc = new SinavSonuc();

            sinavSonuc.Sinav = SinavRepository.SinavBul(sinavAdi);
            sinavSonuc.Kisi = new Kisi
                                {
                                    Isim = "Ahmet",
                                    Soyisim = "Mehmet",
                                    TcKimlikNo = "12345678912"
                                };
            ViewBag.SinavAdi = sinavAdi;
            foreach (var item in MvcApplication.Sonuclar)
            {
                if (item.Key ==sinavSonuc.Kisi.TcKimlikNo)
                {
                    break;
                }
                else
                {
                    MvcApplication.Sonuclar.Add(sinavSonuc.Kisi.TcKimlikNo, sinavSonuc);

                }
            }
               

            
           
           
            
            return View(sinavSonuc);
        }

        public JsonResult SorulariGetir(string sinavAdi)
        {
            var sinav = SinavRepository.SinavBul(sinavAdi);
//MvcApplication.Sonuclar.Add("");
            return Json(sinav.Sorular, JsonRequestBehavior.AllowGet);
            
        }
    }
}