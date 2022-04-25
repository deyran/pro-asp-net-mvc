<h1><div align="center">COMPLETING THE CART</div></h1>
It's time to implement two new feature to our applications:
<ol>
    <li>Remove an item from the cart</li>
    <li>Display a summary of the cart at the top of the page</li>    
</ol>

<h2><i>REMOVING ITEMS FROM THE CART</i></h2>
<ul>
    <li>
        The removal feature has been implemented in the <b>RemoveFromCart</b> action method in the <b>CartController</b> class. Now it is necessary to enable this functionality for the customer. The changes to  Views/Cart/Index.cshtml are shown in Listing 9-4.
        <p align="center">
            <img src="ch09-Pictures/Listing 9-4.png" /><br />
            <b>Listing 9-4.</b> Introducing a Remove Button to the Index.cshtml File
        </p>
    </li>
    <li>
        <i>NOTE</i>
        <ol>
            <li>
                <i>What's the <b>Html.Hidden()</b> and <b>Html.HiddenFor()</b>?</i> <br /> 
                They are MVC Html Helper, it means that they generate HTML control programmatically. The most important benefit is that can created a custom HTML helpers <br />
                For example: <b>Html.Hidden("Name", "Value")</b> will generate<br />
                <img src="ch09-Pictures/Listing 9-4-NOTE.png" />
            </li>
            <li>
                <i>What's the diference?</i>
                The problem when you use Html.Hidden instead of Html.HiddenFor() is that if you change the model properties the project will compile with no problems. But when you use, for example, Html.HiddenFor(x => line.Product.ProductID) you will get an explicit runtime error indicating that the property can't be found, the most important point is that Html.HiddenFor is a strongly typed method that is bounded with model class. <br />
            </li>            
        </ol>
    </li>
    <li>
        Run the application and see the result (Figure 9-1).
        <p align="center">
            <img src="ch09-Pictures/Figure 9-1.png" /><br />
            <b>Figure 9-1.</b> Removing an item from the shopping cart
        </p>
    </li>    
</ul>

<h2><i>ADDING THE CART SUMMARY</i></h2>
<ul>
    <li>
COMPLETING THE CART
    ADDING THE CART SUMMARY
        Listing 9-5. Adding the Summary Method to the CartController.cs File

I may have a functioning cart, but there is an issue with the way it is integrated into the interface. Customers can tell what is in their cart only by viewing the cart summary screen. And they can view the cart summary screen only by adding a new a new item to the cart.

To solve this problem, I am going to add a widget that summarizes the contents of the cart and that can be clicked to display the cart contents throughout the application. I will do this in much the same way that I added the navigation widget—as an action whose output I will inject into the Razor layout. To start, I need to add the simple method, shown in Listing 9-5, to the CartController class.
    </li>    
    <li>
COMPLETING THE CART
    ADDING THE CART SUMMARY
        Listing 9-6. The Contents of the Summary.cshtml File
    </li>    
    <li>
COMPLETING THE CART
    ADDING THE CART SUMMARY
        Listing 9-7. Adding the Summary Partial View to the _Layout.cshtml File
    </li>    
    <li>
COMPLETING THE CART
    ADDING THE CART SUMMARY
        Figure 9-2. The cart summary widget    
    </li>    
</ul>
