using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bem.Mvc.ResponseType.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WithoutLayout()
        {
            return View();
        }

        public ContentResult ContentResult()
        {
            var content = "<h1>Content Result</h1>";

            return Content(content);
        }

        public ContentResult ContentResultFromTextFile()
        {
            using (var tr = new StreamReader(Server.MapPath("~/content/html-content-in-text-file.txt")))
            {
                var content = tr.ReadToEnd();

                return Content(content);
            }
        }


        public ContentResult StringAsJson()
        {
            string jsonS = "{ \"Name\": \"Orhan\", \"Age\":\"33\", \"Skills\": [\"C#\", \"Javascript\"] }";

            Response.ContentType = "application/json";
            return Content(jsonS);
        }

        public ContentResult StringAsJsonPlain()
        {
            string jsonS = "{ \"Name\": \"Orhan\", \"Age\":\"33\", \"Skills\": [\"C#\", \"Javascript\"] }";

            Response.ContentType = "text/plain";
            return Content(jsonS);
        }

        public JsonResult JsonContent()
        {
            var obj = new { Name = "Orhan", Age = "33", Skills = new[] { "C#", "Javascript" } };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }

    }
}