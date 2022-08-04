using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Abstract
{
    /*
    SUBMITTING ORDERS	
	    IMPLEMENTING THE ORDER PROCESSOR 244
		    DEFINING THE INTERFACE
			    Listing 9-14. The Contents of the IOrderProcessor.cs File
     */
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}