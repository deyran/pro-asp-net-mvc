using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.Models;
using System.Linq;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    /*
	BUILDING THE SHOPPING CART
		IMPLEMENTING THE CART CONTROLLER
			Listing 8-14. The Contents of the CartController.cs File

		DISPLAYING THE CONTENTS OF THE CART
			Listing 8-16. The Index Action Method in the CartController.cs File

    USING MODEL BINDING
	    CREATING A CUSTOM MODEL BINDER
		    Listing 9-3. Relying on the Model Binder in the CartController.cs File

    COMPLETING THE CART
        ADDING THE CART SUMMARY
            Listing 9-5. Adding the Summary Method to the CartController.cs File

    SUBMITTING ORDERS
	    ADDING THE CHECKOUT PROCESS
		    Listing 9-10. The Checkout Action Method in the CartController.cs File

    SUBMITTING ORDERS	
	    COMPLETING THE CART CONTROLLER 248
		    Listing 9-18. Completing the Controller in the CartController.cs File
    */

    public class CartController : Controller
    {
        private IProductRepository repository;
        private IOrderProcessor orderProcessor;

        public CartController(IProductRepository repo, IOrderProcessor proc)
        {
            repository = repo;
            orderProcessor = proc;
        }

        [HttpPost]
        public ViewResult Checkout(Cart cart, ShippingDetails shippingDetails)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry!, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                orderProcessor.ProcessOrder(cart, shippingDetails);
                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }
        }

        public ViewResult Index(Cart cart, string returnUrl)
        {
            return (
                View(
                    new CartIndexViewModel
                    {
                        Cart = cart,
                        ReturnUrl = returnUrl
                    }
                )
            );
        }

        public RedirectToRouteResult AddToCart(Cart cart, int productId, string returnUrl)
        {
            Product product = repository.Products
               .FirstOrDefault(p => p.ProductID == productId);

            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("/Index", new { returnUrl });
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart, int productId, string returnUrl)
        {
            Product product = repository.Products
                        .FirstOrDefault(p => p.ProductID == productId);

            if (product != null)
            {
                cart.RemoveLine(product);
            }

            return RedirectToAction("/Index", new { returnUrl });
        }

        public PartialViewResult Summary(Cart cart)
        {
            return PartialView(cart);
        }

        public ViewResult Checkout()
        {
            return View(
                new ShippingDetails()
            );
        }

    }
}