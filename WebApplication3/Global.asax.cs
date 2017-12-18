using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WebApplication3
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public void Application_EndRequest()
        {
            var streamReader = new StreamReader(HttpContext.Current.Response.OutputStream);
            var content = streamReader.ReadToEnd();

            content.Replace("</body>", "<div>Footer</div></body>");
            HttpContext.Current.Response.Output.Write(content);
        }
    }
}
