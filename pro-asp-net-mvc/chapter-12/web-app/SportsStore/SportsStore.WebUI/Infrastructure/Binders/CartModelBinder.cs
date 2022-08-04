using System.Web.Mvc;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Infrastructure.Binders
{
	/*
	USING MODEL BINDING
		CREATING A CUSTOM MODEL BINDER
			Listing 9-1. The Contents of the CartModelBinder.cs File
	 */

	public class CartModelBinder : IModelBinder
    {
        private const string sessionKey = "Cart";

		public object BindModel(ControllerContext controllerContext,
					ModelBindingContext bindingContext)
		{
			// get the Cart from the session
			Cart cart = null;
			if (controllerContext.HttpContext.Session != null)
			{
				cart = (Cart)controllerContext.HttpContext.Session[sessionKey];
			}

			// create the Cart if there wasn't one in the session data
			if (cart == null)
			{
				cart = new Cart();
				if (controllerContext.HttpContext.Session != null)
				{
					controllerContext.HttpContext.Session[sessionKey] = cart;
				}
			}

			// return the cart
			return cart;
		}

	}
}