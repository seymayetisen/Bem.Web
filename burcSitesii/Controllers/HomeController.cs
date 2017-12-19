using burcSitesii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace burcSitesii.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private List<BurcKutusu> GetBurcKutusu()
        {
            return new List<BurcKutusu>
            {
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/oglak.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"},
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/kova.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"},
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/balik.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"},
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/boga.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"},
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/basak.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"},
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/koc.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"},
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/terazi.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"},
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/yay.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"},
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/yengec.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"},
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/ikizler.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"},
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/basak.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"},
                new BurcKutusu{adres="#gunluk-burc/oglak.html", ResimSRC="img/aslan.png",BurcIsmi="Oğlak",Aciklama="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alara"}
            };
        }
        public ActionResult Index()
        {
            var BurcKutusu = GetBurcKutusu();
            return View(BurcKutusu);
        }
    }
}