using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AggnWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is the place where I tell you about me.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "This is the place where you tell me about you.";
            ViewBag.FindOutTheTruth = "The Truth Is Out There!";

            return View();
        }
    }
}