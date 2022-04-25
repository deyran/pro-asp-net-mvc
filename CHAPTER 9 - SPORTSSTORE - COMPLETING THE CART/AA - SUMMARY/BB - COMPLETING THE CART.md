<h1><div align="center">COMPLETING THE CART</div></h1>
It's time to implement two new feature to our applications:
<ol>
    <li>Remove an item from the cart</li>
    <li>Display a summary of the cart at the top of the page</li>    
</ol>

<h2><i>REMOVING ITEMS FROM THE CART</i></h2>
<h3><i>-- NOTE --</i></h3>
<ol>
    <li>
        <i>What's the Html.Hidden() and Html.HiddenFor()?</i> <br /> 
        They are MVC Html Helper, it means that they generate HTML control programmatically. The most important benefit is that can created a custom HTML helpers <br />
        For example: <br />
            Html.Hidden("Name", "Value") will generate <br />
            <input id="Name" name="Name" type="hidden" value="Value">                          
    </li>
    <li>AAAAAAAAAAA</li>            
</ol>

<ul>
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
