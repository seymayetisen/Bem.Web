using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View();
        }
    }
}