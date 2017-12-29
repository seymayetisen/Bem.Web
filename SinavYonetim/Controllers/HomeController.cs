using SinavYonetim.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SinavYonetim.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var context = new SinavYonetimDbContext();
            var personList = new List<Person>();
            

            int s1 = 5;
            int s2 = 7;
            //int s3 => s1* s2;

            ViewBag.Bir =Hesapla(s1, s2, (e,r)=> e+r);
            ViewBag.Iki =Hesapla(s1, s2, (p,l) => p*l);
            ViewBag.Uc = Hesapla(10, 11, Hesap2);
            ViewBag.Dort = Hesapla(10, 11, Hesap1);

            ViewBag.Bes = Uzunluk("Orhan", s => s.IndexOf("DENEME"));
            ViewBag.Alti = Uzunluk("Orhan", s => s.Length);

            var list = new List<int> { 1, 4, 8, 98,0, 231, 5, 7, 36, 1 };

            var sonuc = new List<int>();
            foreach (var item in list)
            {
                if (item > 5)
                {
                    sonuc.Add(item);
                }
            }

            var sonucList = from x in list
                            where x > 5
                            select x.ToString();


            var methodSonuc = list.Where(x => x > 5);

            var l1 = Where(list, c => c > 5);
            var l2 = Where(list, c => c.ToString().StartsWith("1"));

            return View(personList);
        }

        public ActionResult FilteredResult(string name)
        {
            var context = new SinavYonetimDbContext();
            var personList = context.Person.Where(p=> p.Name.Contains(name)).ToList();

            return View("~/views/home/index.cshtml",personList);
        }

        public ActionResult Exam(string name)
        {
            var context = new SinavYonetimDbContext();
            var pe = context.PersonExam.Include(p=> p.Exam).First();

            return View(pe);
        }

        private int Hesapla(int x , int y, Func<int,int,int> Hesap)
        {
            x++;
            y++;

            var result = Hesap(x, y);

            return result;
        }

        private int Uzunluk(string s, Func<string, int> UzunlukHesapla)
        {
            s += "DENEME";
            return UzunlukHesapla(s);
        }

        private int Hesap1(int a, int b) => a + b;
        private int Hesap2(int z, int t) => z * t;

        private List<int> Where(List<int> k, Func<int, bool> Kim)
        {
            var list = new List<int>();

            foreach (var item in k)
            {
                if (Kim(item))
                {
                    list.Add(item);
                }
            }

            return list;
        }
    }
}