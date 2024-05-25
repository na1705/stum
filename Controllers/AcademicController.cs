using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StuMSystem.Controllers
{
    public class AcademicController : Controller
    {
        // GET: Academic
        public ActionResult Undergraduate()
        {
            return View();
        }
        public ActionResult Graduate()
        {
            return View();
        }
    }
}