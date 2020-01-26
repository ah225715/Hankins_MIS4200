using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hankins_MIS4200.Controllers
{
    public class HelloWorldController : Controller
    {
            public ActionResult Index()
            {
            return View();
            }
    }
}