using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bem.Mvc.ResponseType.Controllers
{
    public class AwayController : Controller
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

        public ContentResult ContentResultWithLayout(string innerPageName)
        {
            string mainContent = "";
            string innerContent = "";

            using (var tr = new StreamReader(Server.MapPath("~/content/html-content-in-text-file.txt")))
            {
                mainContent = tr.ReadToEnd();
            }

            using (var tr = new StreamReader(Server.MapPath($"~/views/home/{innerPageName}.cshtml")))
            {
                innerContent = tr.ReadToEnd();
            }

            Response.ContentType = "text/html";
            return Content(RazorEngine(mainContent).Replace("orhan", innerContent).Replace("[sayfaAdi]", innerPageName));
        }

        private string RazorEngine(string content)
        {
            var startIndex = content.IndexOf("[dön]");
            var endIndex = content.IndexOf("[/dön]")+6;

            var proccessedText = content.Substring(startIndex, endIndex - startIndex);

            var pieces = proccessedText.Split('\n');

            int step = int.Parse(pieces[1]);

            string temp = ""
;            for (int i = 0; i < step; i++)
            {
                temp += pieces[2];
            }
            content = content.Replace(proccessedText, temp);

            return content;
        }
    }
}