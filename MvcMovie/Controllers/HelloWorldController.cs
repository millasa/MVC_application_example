using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()
        {
            return View();
        }

        //
        //GET: /HelloWorld/Welcome/

        public ActionResult Welcome(string name, int num = 5)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.Num = num;

            var type = typeof(IController);
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p));

            return View();
        }
    }
}
