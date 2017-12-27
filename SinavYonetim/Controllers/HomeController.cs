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
            var personList = context.Person.ToList();

            return View(personList);
        }

        public ActionResult FilteredResult(string name)
        {
            var context = new SinavYonetimDbContext();
            var personList = context.Person.Where(p=> p.Isim.Contains(name)).ToList();

            return View("~/views/home/index.cshtml",personList);
        }

        public ActionResult Exam(string name)
        {
            var context = new SinavYonetimDbContext();
            var pe = context.PersonExam.Include(p=> p.Exam).First();

            return View(pe);
        }
    }
}