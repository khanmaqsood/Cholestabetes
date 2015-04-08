﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cholestabetes.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View();

           return  RedirectToAction("Index", "Patient");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}