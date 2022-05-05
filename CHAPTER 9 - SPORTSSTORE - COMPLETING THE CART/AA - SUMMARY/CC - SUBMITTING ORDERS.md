<h1><div align="center">SUBMITTING ORDERS</div></h1>
<p align="center">
	<img src="ch09-Pictures/SUBMITTING_ORDERS.png" with=200 height=200 />
</p>

<h4>The SportsStore web app has these two features:</h4>
&nbsp;&nbsp;&nbsp;&nbsp;1 - the mechanism to pay for the things you are buying (check out)<br />
&nbsp;&nbsp;&nbsp;&nbsp;2 - Complete an order<br /><br />

<h4>Now in this section we will do the following tasks:</h4>
&nbsp;&nbsp;&nbsp;&nbsp;1 - Extend the domain model to provide support for capturing the shipping details from a user<br />
&nbsp;&nbsp;&nbsp;&nbsp;2 - Add the application support to process those details<br />

<h2><i>EXTENDING THE DOMAIN MODEL</i></h2>
&nbsp;&nbsp;&nbsp;&nbsp;Create a file called <b>ShippingDetails.cs</b>, and put in the <b>Entities</b> folder in <b>SportsStore.Domain</b> project, and edit to match as in <b>Listing 9-8</b>
<p align="center">
	<img src="ch09-Pictures/Listing 9-8.png" /><br />
	<b>Listing 9-8.</b> The Contents of the ShippingDetails.cs File
</p>

<h2><i>ADDING THE CHECKOUT PROCESS</i></h2>
<ul>
	<li> 
		Open the <b>Index.cshtml</b> file in <b>Views/Cart</b>, to add the <b>checkout button</b> to the cart summary view (Listing 9-9).
		<p align="center">
			<img src="ch09-Pictures/Listing 9-9.png" /><br />
			<b>Listing 9-9.</b> The Contents of the ShippingDetails.cs File
		</p><br />
		Run the web app and see the result:
		<p align="center">
			<img src="ch09-Pictures/Figure 9-3.png" /><br />
			<b>Figure 9-3.</b> The Checkout now button
		</p>
	</li>
	<li>
		In Listing 9-10, we will implement the <b>checkout</b> method in the <b>CartController</b> class, as shown in the picture below
		<p align="center">
			<img src="ch09-Pictures/Listing 9-10.png" /><br />
			<b>Listing 9-10.</b> The Checkout Action Method in the CartController.cs File
		</p>
	</li>
	<li>
		Now create the view for the action method called <b>Checkout</b>, edit to match Listing 9-11.
		<p align="center">
			<img src="ch09-Pictures/Listing 9-11.png" /><br />
			<b>Listing 9-11.</b> The Contents of the Checkout.cshtml File
		</p>
	</li>
	<li>
		Run the web app and see the result in the picture below:
		<p align="center">
			<img src="ch09-Pictures/Figure 9-4.png" /><br />
			<b>Figure 9-4.</b> The shipping details form
		</p>
	</li>
	<li>
		<h3><i>REDUCING DUPLICATION IN THE Checkout.cshtml FILE</i></h3>
		<ol>
			<li>
				The problem with this view is that it contains a lot of repeated markup, the Listing 9-12 shows how to reduce the repeated markup:
				<p align="center">
					<img src="ch09-Pictures/Listing 9-12.png" /><br />
					<b>Listing 9-12.</b> Reducing Duplication in the Checkout.cshtml File
				</p>
			</li>
			<li>Figure 9-5. The problem with generating labels from property names</li>
			<li>Listing 9-13. Applying th e Display attribute to the ShippingDetails.cs File</li>
			<li>Figure 9-6. The effect of the Display attribute on the model type</li>
		</ol>
	</li>
</ul>	
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