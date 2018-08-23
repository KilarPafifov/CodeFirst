using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        CarContext context = new CarContext();
        public ActionResult Index()
        {
            ViewBag.Cars = context.Cars;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = " ";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}