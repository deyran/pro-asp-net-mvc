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
    We have a working cart, but one issue, customers can view cart summary screen only when adding a new item to cart. To solve this problem, we have divided the problem into three steps:<br />
<ol>
    <li>
        We need to add the simple method, shown in Listing 9-5, to the <b>CartController</b> class.
        <p align="center">
            <img src="ch09-Pictures/Listing 9-5.png" /><br />
            <b>Listing 9-5.</b> Adding the Summary Method to the CartController.cs File
        </p>
    </li>    
    <li>
        The second step consists of creating a the View to supplying the current Cart as view data (Listing 9-6). 
        <ol>
            <li>Right-click the Summary action method and select Add View from the pop-up menu</li>
            <li>Set the name of the view to Summary and click the OK button to create the Views/Cart/Summary.cshtml</li>
            <li>
                Edit the view so that it matches Listing 9-6:
                <p align="center">
                    <img src="ch09-Pictures/Listing 9-6.png" /><br />
                    <b>Listing 9-6.</b> The Contents of the Summary.cshtml
                </p>
            </li>
        </ol>
    </li>    
    <li>
        The final step we can call the Summary action method in the _Layout.cshtml file to display the cart summary, as shown in Listing 9-7.
        <p align="center">
            <img src="ch09-Pictures/Listing 9-7.png" /><br />
            <b>Listing 9-7.</b> Adding the Summary Partial View to the _Layout.cshtml File
        </p>
    </li>    
    <li>
        Run the application and see the result (Figure 9-2).
        <p align="center">
            <img src="ch09-Pictures/Figure 9-2.png" /><br />
            <b>Figure 9-2.</b> The cart summary widget
        </p>
    </li>    
</ol>
