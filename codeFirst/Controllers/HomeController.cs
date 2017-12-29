using codeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codeFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var context = new OTODbContext();
            List<Buses> Busess = context.Buses.ToList();
            return View(Busess);
        }
    }
}