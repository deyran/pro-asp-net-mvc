<h1><i>BUILDING THE SHOPPING CART</i></h1>
<p align="center">
	Despides the progress, the application cannot sell any products until I implement a shopping cart. In this section, will be created the shopping cart experience.
</p>

<h2><i>DEFINING THE CART ENTITY</i></h2>
<ul>
	<li>
		Create a class file called Cart.cs to the Entities folder in the SportsStore.Domain project (Listing 8-12).
		<p align="center">
			<img src="Pictures/Listing 8-12.png" /><br />
			<b>Listing 8-12.</b> Cart and CartLine Classes in the Cart.cs File
		</p>
	</li>
	<li>
		<h3><i>UNIT TEST</i></h3>
		<ol>
			<li>
				<b>TESTING THE CART</b> - Create a new unit test file in the SportsStore.UnitTests project called CartTests.cs to test, in the first moment, the add an item to the cart behavior (see the code below).<br />
				<p align="center">
					<img src="Pictures/UT_TESTING_THE_CART.png" /><br />
					<i>UNIT TEST - TESTING THE CART</i>
				</p><br />				
			</li>
			<li>
				<b>ADD QUANTITY FOR EXISTING LINE</b> - After you have added items to the car, it's necessary to increment the quantity of the corresponding CarLine and not create a new one. Here is the test:<br />
				<p align="center">
					<img src="Pictures/UT_ADD_QTT_FOR_EXISTING_LINE.png" /><br />
					<i>UNIT TEST - ADD QUANTITY FOR EXISTING LINE</i>
				</p><br />
			</li>
			<li>
				<b>REMOVE PRODUCT</b> - In this step, the feature to remove products from cart will be implemented. This feature is implemented by the RemoveLine method in the code below:<br />
				<p align="center">
					<img src="Pictures/UT_TESTING_THE_CART_REMOVE_PRODUCT.png" /><br />
					<i>UNIT TEST - REMOVE PRODUCT</i>
				</p><br />	
			</li>
			<li>
				<b>CALCULATE THE TOTAL</b> - The next behavior i want to test is the ability to calculate the total cost of the items in the cart. here’s the test for
				this behavior:<br />
				<p align="center">
					<img src="Pictures/UT_TESTING_THE_CART_CALCULATE_TOTAL.png" /><br />
					<i>UNIT TEST - CALCULATE THE TOTAL</i>
				</p><br />
			</li>
			<li>
				<b>CLEAR CONTENTS OF THE CART</b> - The final test is simple -> to ensure that the contents of the cart are properly removed when reset. here is the test:<br />
				<p align="center">
					<img src="Pictures/UT_CLEAR_CONTENTS_CART.png" /><br />
					<i>UNIT TEST - CLEAR CONTENTS OF THE CART</i>
				</p><br />
			</li>
		</ol>
	</li>
</ul>

<h2><i>ADDING THE ADD TO CART BUTTONS</i></h2>
	Edit the ProductSummary.cshtml (Views/Shared) file to add the button to the product listings (Listing 8-13). When this button is clicked and submitted it invoke the AddToCart method in the Cart controller.
	<p align="center">
		<img src="Pictures/Listing 8-13.png" /><br />
		<b>Listing 8-13.</b> Adding the Buttons to the Product Summary.cshtml File View
	</p><br />
		<b>NOTE:</b> By default, the BeginForm helper method creates a form that uses the HTTP POST method, but can be changed to the HTTP GET method<br />

<h2><i>IMPLEMENTING THE CART CONTROLLER</i></h2>
	Create a new controller called CartController (SportsStore.WebUI projects) to handle the Add feature to the button presses (Listing 8-14). In this controller class we use the ASP.NET session state feature to store and retrieve Cart objects (Get method). The reason we need the ASP.NET session state is to persistent data between request due to the stateless features of the HTTP protocol. See the code below:<br />
	<p align="center">
		<img src="Pictures/Listing 8-14.png" /><br />
		<b>Listing 8-14.</b> The Contents of the CartController.cs File
	</p><br />

<h2><i>DISPLAYING THE CONTENTS OF THE CART</i></h2>
<ul>
	<li>
		<h3>THE CONTENTES OF THE CART</h3>
		The final point we can see in the CartController class that both the AddToCart and RemoveFromCart methods call the RedirectToAction method. This method ask the browser to request a new URL, in that case Index action method of the Cart controller. The index method will be to show the contents of the Cart.<br />
		To show the possible contents of the cart, two pieces of information are needed:
		<ol>
			<li>The Cart object;</li>
			<li>URL to be displayed if the user clicks on the continue shopping button</li>
		</ol>
		Create a classe named CartIndexViewModel.cs in the model folder of the SportsStore.WebUI project. The contents of this file are shown in Listing 8-15.	
		<p align="center">
			<img src="Pictures/Listing 8-15.png" /><br />
			<b>Listing 8-15.</b> The Contents of the CartIndexViewModel.cs File
		</p><br />
	</li>
	<li>AAA</li>
</ul>
	
	
	
	
  
