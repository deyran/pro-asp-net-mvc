<h1>DISPLAYING A LIST OF PRODUCTS</h1>
    &nbsp;&nbsp;We will see in this section:<br />
    <ul>
        <li>A controller and action method that can display details of the products in the repository.</li>
        <li>An initial routing configuration to map requests to the controller that was created</li>
    </ul>

<h2><i>ADDING A CONTROLLER</i></h2>
    <ul>
        <li>
            In the <b>Sports.WebUI</b> project, follow these steps:<br />
            <ol>
                <li>Right-click the <b>Controller</b> folder and select <b>Add > Contoller</b></li>
                <li>Select <b>MVC 5 Controller - Empty</b> and click the button <b>Add</b></li>
                <li>Set the name to <b>ProductController</b></li>
                <li>
                    The implementation of <b>ProductController.cs</b> file can be seen in the Listing below:<br />
                    <p align="center">
                        <img src="Pictures/Listing 7-6.png" /><br />
                        <b>Listing 7-6.</b> The initial contents of the <b>ProductController.cs</b> file
                    </p>
                </li>
            </ol>
        </li>
        <li>
            The next step, a called action method <b>List</b> will be implemented, 
            which will render a view showing the full list of products (Listing 7-7 below):<br />
            <p align="center">
                <img src="Pictures/Listing 7-7.png" /><br />
                <b>Listing 7-7.</b> Adding an action method to the ProductController.cs file
            </p>    
        </li>
    </ul>

<h2><i>ADDING THE LAYOUT, VIEW START FILE AND VIEW</i></h2>
    <ul>
        <li>
            To add the default view for the <b>List</b> action method fellow these steps:<br />
            <ol>
                <li>Right-click on the <b>List</b> action method in the <b>HomeController</b></li>
                <li>Select <b>Add View</b> from the pop-up menu</li>
                <li>
                    In the <b>Add View</b> screen, fill in the fields as shown in Figure <b>Figure 7-5</b> and click <b>Add</b>.
                    <p align="center">
                        <img src="Pictures/Figure 7_5.png" /><br />
                        <b>Figure 7_5.</b> Adding the View/Product/List.cshtml view
                    </p>    
                </li>
            </ol>
        </li>
        <li>
            When you creating the <b>List.cshtml</b> file you also create the <b>_ViewStart.cshtml</b> file and a <b>Shared/_Layout.cshtml</b> file. Edit the <b>_Layout.cshtml</b> file so that it matches the content shown in <b>Listing 7-8</b>.
            <p align="center">
                <img src="Pictures/Listing 7-8.png" /><br />
                <b>Listing 7-8.</b> Editing the _Layout.cshtml file
            </p>
        </li>
    </ul>

<h2><i>SETTING THE DEFAULT ROUTE</i></h2>
<h2><i>RUNNING THE APPLICATION</i></h2>
