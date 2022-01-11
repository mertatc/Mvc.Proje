using Proje.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proje.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        public ActionResult Index()
        {
            //veri tabanı sorguluyoruz
            return View(_context.Products.ToList());
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