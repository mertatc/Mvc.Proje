using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proje.Controllers
{
    public class HomeController : Controller
    {
        // GET: Hoe
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult List()
        {
            return View();
        }
    }
}