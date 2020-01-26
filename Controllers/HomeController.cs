using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hankins_MIS4200.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Bio";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Alex's Contact Details";

            return View();
        }
    }
}