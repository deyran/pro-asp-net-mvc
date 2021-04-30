using System;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        /*
        >> PREPARING THE EXAMPLE PROJECT
        >>>> Adding the System.Net.Http assembly
        >>>>>>>> Listing 4-1. The inicial content of the HomeControler.cs file (page 68)
        */
        public string Index()
        {
            return "Navigate to a URL to show an example";
        }
    }
}