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

        [HttpGet]
        public ActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        public string AddCar(Car car)
        {
            context.Cars.Add(car);
            context.SaveChanges();
            return "ok";
        }
        public ActionResult About()
        {
            ViewBag.Message = " ";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(Car car)
        {
            if (ModelState.IsValid)
            {
                //  TODO Email response to the party organizer
                return View("Car", car);
            }

            else
            {
                // there is validation error
                return View();
            }
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}