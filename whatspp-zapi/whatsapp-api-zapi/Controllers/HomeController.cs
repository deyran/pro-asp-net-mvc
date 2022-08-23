using System;
using System.Web.Mvc;
using whatsApp_api_zpai.Models;

namespace whatsApp_api_zpai.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string ZPhoneNumber, string ZMessage)
        {
            try
            {
                var task = new WhatsAppSend().ExecutarAsync
                (
                    new WhatsAppMessage()
                    {
                        phone = ZPhoneNumber,
                        message = ZMessage
                    }
                );

            }
            catch (Exception e)
            {}

            ViewBag.vbNumber = ZPhoneNumber;
            ViewBag.vbMessage = ZMessage;

            return View();
        }
        
    }
}