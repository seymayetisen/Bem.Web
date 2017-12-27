using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bem.Mvc.ResponseType.Controllers
{
    public class PostGetDemoController : Controller
    {
        // GET: PostGetDemo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContentSample()
        {
            var content = "<h1>Content Result</h1>";

            return Content(content);
        }

        [HttpPost]
        public ActionResult ContentSampleOnlyPost()
        {
            var content = "<h1>Content Result</h1>";

            return Content(content);
        }
        public JsonResult JsonContent(string name)
        {
            var obj = new { Name = name, Age = "33", Skills = new[] { "C#", "Javascript" } };

            return Json(obj, JsonRequestBehavior.AllowGet);
        }


        public JsonResult JsonContentOnlyPost(string name)
        {
            var obj = new { Name = name, Age = "33", Skills = new[] { "C#", "Javascript" } };

            return Json(obj);
        }
    }
}