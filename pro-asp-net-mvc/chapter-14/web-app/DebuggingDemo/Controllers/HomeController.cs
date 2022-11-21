﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DebuggingDemo.Controllers
{
    /*
    Chapter 14: Overview of MVC Projects
        # Debugging MVC Applications
            ## Preparing the Example Project
                ### Creating the Controller
                    Listing 14-1. The Contents of the HomeController.cs File
    */
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int firstVal = 10;
            int secondVal = 5;
            int result = firstVal / secondVal;

            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View(result);
        }
    }
}