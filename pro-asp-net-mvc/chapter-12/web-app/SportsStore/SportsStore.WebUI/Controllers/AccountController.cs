using System.Web.Mvc;
using SportsStore.WebUI.Infrastructure.Abstract;
using SportsStore.WebUI.Models;

namespace SportsStore.WebUI.Controllers
{
    /*
    chapter 12 - SportsStore: Security & Finishing Touches
        Securing the Administration Controller
            Creating the Account Controller 312
                Listing 12-8. The Contents of the AccountController.cs File
     */
    public class AccountController : Controller
    {
        IAuthProvider authProvider;

        public AccountController(IAuthProvider auth)
        {
            authProvider = auth;
        }

       // [HttpPost]
       [HttpGet]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (authProvider.Authenticate(model.UserName, model.Password))
            {
                return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            return Content("Hi there!");
        }
    }
}