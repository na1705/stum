using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StuMSystem.Controllers
{
    public class MediaController : Controller
    {
        // GET: Media
        public ActionResult Photo()
        {
            return View();
        }
        public ActionResult Video()
        {
            return View();
        }
    }
}