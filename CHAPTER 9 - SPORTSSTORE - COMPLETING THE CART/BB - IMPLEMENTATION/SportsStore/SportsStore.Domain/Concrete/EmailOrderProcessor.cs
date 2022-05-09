using System.Net;
using System.Net.Mail;
using System.Text;
using SportsStore.Domain.Abstract;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Concrete
{
	/*
    SUBMITTING ORDERS	
	    IMPLEMENTING THE ORDER PROCESSOR 244
		    IMPLEMENTING THE INTERFACE
			    Listing 9-15. The Contents of the EmailOrderProcessor.cs File
     */

	public class EmailSettings
	{
		public string MailToAddress = "deyran@gmail.com";
		public string MailFromAdress = "sportsstore@example.com";
		public bool UseSsl = true;
		public string Username = "deyran";
		public string Password = "MySmtpPassword";
		public string ServerName = "smtp.example.com";
		public int ServerPort = 587;
		public bool WriteAsFile = false;
		public string FileLocation = @"c:\sports_store_emails";
	}

	public class EmailOrderProcessor : IOrderProcessor
    {
        public void ProcessOrder(Cart cart, ShippingDetails shippingDetails)
        {
            throw new System.NotImplementedException();
        }
    }
}
