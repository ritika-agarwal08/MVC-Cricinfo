using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class CricinfoController : Controller
    {
        // GET: Cricinfo
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Upcoming()
        {
            return View();
        }
        public ActionResult Past()
        {
            return View();
        }
        public ActionResult Ranking()
        {
            return View();
        }
    }
}