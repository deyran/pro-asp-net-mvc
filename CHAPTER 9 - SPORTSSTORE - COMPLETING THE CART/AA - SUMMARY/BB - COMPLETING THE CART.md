<h1><div align="center">COMPLETING THE CART</div></h1>
It's time to implement two new feature to our applications:
<ol>
    <li>Remove an item from the cart</li>
    <li>Display a summary of the cart at the top of the page</li>    
</ol>

<h2><i>REMOVING ITEMS FROM THE CART</i></h2>
<ul>
    <li>

COMPLETING THE CART
    REMOVING ITEMS FROM THE CART
        Listing 9-4. Introducing a Remove Button to the Index.cshtml File


The removal feature has been implemented in the <b>RemoveFromCart</b> action method in the <b>CartController</b> class. Now it is necessary to enable this functionality for the customer. The changes to  Views/Cart/Index.cshtml are shown in Listing 9-4.




Note ■ i used the strongly typed Html.HiddenFor helper method to create a hidden field for the ReturnUrl model property, but i had to use the string-based Html.Hidden helper to do the same for the ProductId field. if i had written Html.HiddenFor(x => line.Product.ProductID), the helper would render a hidden field with the name line. Product.ProductID. the name of the field would not match the names of the parameters for the CartController. RemoveFromCart action method, which would prevent the default model binders from working, so the mVC Framework would not be able to call the method.

> https://stackoverflow.com/questions/4381871/what-is-the-difference-between-html-hidden-and-html-hiddenfor



> https://www.completecsharptutorial.com/asp-net-mvc5/html-hiddenfor-example-aspnet-mvc5.php
> https://technoteshelp.com/c-what-is-the-difference-between-html-hidden-and-html-hiddenfor/
> https://www.tutorialsteacher.com/mvc/htmlhelper-hidden-hiddenfor
> https://quick-adviser.com/how-to-use-hiddenfor-in-mvc/







    </li>
    <li>
COMPLETING THE CART
    REMOVING ITEMS FROM THE CART
        Figure 9-1. Removing an item from the shopping cart
    </li>    
</ul>

<h2><i>ADDING THE CART SUMMARY</i></h2>
<ul>
    <li>
COMPLETING THE CART
    ADDING THE CART SUMMARY
        Listing 9-5. Adding the Summary Method to the CartController.cs File
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
