using System.Linq;
using System.Web.Mvc;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Controllers
{
	/*
	BUILDING THE SHOPPING CART
		IMPLEMENTING THE CART CONTROLLER
			Listing 8-14. The Contents of the CartController.cs File
	 */

	public class CartController : Controller
    {
		private IProductRepository repository;

		public CartController(IProductRepository repo)
		{
			repository = repo;
		}

		public RedirectToRouteResult AddToCart(int productId, string returnUrl)
		{
			Product product = repository.Products
						.FirstOrDefault(p => p.ProductID == productId);

			if (product != null)
			{
				GetCart().AddItem(product, 1);
			}

			return RedirectToAction("Index", new { returnUrl });
		}

		public RedirectToRouteResult RemoveFromCart(int productId, string returnUrl)
		{
			Product product = repository.Products
						.FirstOrDefault(p => p.ProductID == productId);

			if (product != null)
			{
				GetCart().RemoveLine(product);
			}

			return RedirectToAction("Index", new { returnUrl });
		}

		private Cart GetCart()
		{
			Cart cart = (Cart)Session["Cart"];

			if (cart == null)
			{
				cart = new Cart();
				Session["Cart"] = cart;
			}

			return cart;
		}

	}
}