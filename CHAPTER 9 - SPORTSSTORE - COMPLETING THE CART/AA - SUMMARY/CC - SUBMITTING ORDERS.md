<h1><div align="center">SUBMITTING ORDERS</div></h1>
<p align="center">
	<img src="ch09-Pictures/SUBMITTING_ORDERS.png" with=200 height=200 />
</p>


<ol>> The SportsStore web app has these two features:
	<li>the mechanism to pay for the things you are buying (check out)</li>
	<li>Complete an order</li>
</ol>


<ol>> Now in this section we will do the following tasks:
	<li>Extend the domain model to provide support for capturing the shipping details from a user</li>
	<li>Add the application support to process those details</li>
</ol><br />

========================================================================================================================
<ul>
	<li>AAAAAAAAAA</li>
</ul>

SUBMITTING ORDERS
	EXTENDING THE DOMAIN MODEL 236
		Listing 9-8. The Contents of the ShippingDetails.cs File
------------------------------------------------------------------------------------------------------------------------

SUBMITTING ORDERS	
	ADDING THE CHECKOUT PROCESS 237
		Listing 9-9. Adding the Checkout Now Button to the Index.cshtml File
		Figure 9-3. The Checkout now button
		Listing 9-10. The Checkout Action Method in the CartController.cs File
		Listing 9-11. The Contents of the Checkout.cshtml File
		Figure 9-4. The shipping details form
		Listing 9-12. Reducing Duplication in the Checkout.cshtml File
		Figure 9-5. The problem with generating labels from property names
		Listing 9-13. Applying th e Display attribute to the ShippingDetails.cs File
		Figure 9-6. The effect of the Display attribute on the model type
------------------------------------------------------------------------------------------------------------------------

SUBMITTING ORDERS	
	IMPLEMENTING THE ORDER PROCESSOR 244
		DEFINING THE INTERFACE
			Listing 9-14. The Contents of the IOrderProcessor.cs File
		IMPLEMENTING THE INTERFACE
			Listing 9-15. The Contents of the EmailOrderProcessor.cs File
------------------------------------------------------------------------------------------------------------------------

SUBMITTING ORDERS
	REGISTERING THE IMPLEMENTATION 247
		Listing 9-16. Adding Ninject Bindings for IOrderProcessor to the NinjectDependencyResolver.cs File
		Listing 9-17. Application Settings in the Web.config File
------------------------------------------------------------------------------------------------------------------------

SUBMITTING ORDERS	
	COMPLETING THE CART CONTROLLER 248
		Listing 9-18. Completing the Controller in the CartController.cs File
		UNIT TEST: ORDER PROCESSING
------------------------------------------------------------------------------------------------------------------------

SUBMITTING ORDERS	
	DISPLAYING VALIDATION ERRORS 252
		Listing 9-19. Adding a Validation Summary to the Checkout.cshtml File
		Listing 9-20. The Contents of the ErrorStyles.css File
		Listing 9-21. Adding a Link Element in the _Layout.cshtml File
		Figure 9-7. Displaying validation messages
------------------------------------------------------------------------------------------------------------------------

SUBMITTING ORDERS	
	DISPLAYING A SUMMARY PAGE 254
		Listing 9-22. The Contents of the Completed.cshtml File
		Figure 9-8. The thank-you page