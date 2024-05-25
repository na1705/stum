using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StuMSystem.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult DevelopmentStrategy()
        {
            return View();
        }
        public ActionResult InformationOverview()
        {
            return View();
        }
    }
}