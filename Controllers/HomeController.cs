﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biosalvus.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Better manage Important Species for our Environment.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ClimateChange()
        {
            return View();
        }

        public ActionResult Bushfire()
        {
            return View();
        }

        public ActionResult Cats()
        {
            return View();
        }

        public ActionResult Climate()
        {
            return View();
        }
    }
}