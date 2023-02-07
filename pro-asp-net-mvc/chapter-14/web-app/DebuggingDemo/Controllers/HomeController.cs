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

            ## Causing the Visual Studio Debugger to Break (357-363)
                ### Using Breakpoints
                    Figure 14-8. Applying a breakpoint to the first statement in the Index action method

                ### Breaking on Exceptions
                    Listing 14-5. Adding a Statement That Will Cause an Exception in the HomeController.cs File

            ## Using Edit and Continue 
                ### Modifying the Project (364-365)
                    Listing 14-6. Removing the ViewBag Call from the Index Method in the HomeController.cs file
    */

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int firstVal = 12;
            int secondVal = 0;
            int result = firstVal / 2;

            // This statement has been commented out
            // ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View(result);
        }
    }
}