<h1>ADDING PAGINATION</h1>
    You can see in Figure 7-13 that the <b>List.cshtml </b> view displays all the products in the database on a single page. In this section, you'll add support for pagination so that the preview displays a series of products on one page, and the user can move from page to page to view the overall catalog (see Listing 7-16). 
    <br /><br />

<p align="center">
    <img src="Pictures/Listing 7-16.png" /><br />
    <b>Listing 7-16.</b> Adding pagination support to the list action method in the <b>ProductController.cs</b> file
</p>

<ul>
    <li>
        <h3><i>UNIT TEST: PAGINATION</i></h3>
        This is the purpose of creating the Unit Test: Compare the <b>Product</b> object with what you would expect from the test data in the simulated implementation. You can see this purpose fullfilled in the <b>UnitTest1.cs</b> file of the <b>SportsStore.UnitTests</b> project implemented below:<br /><br />
        <p align="center">
            <img src="Pictures/UNIT TEST PAGINATION.png" /><br />
        </p>
    </li>
    <li>
        <h3><i>Adding the View Model</i></h3>
        <p align="center">
            <img src="Pictures/Listing 7-17.png" /><br />
            <b>Listing 7-17.</b> The contents of the <b>PagingInfo.cs</b> file
        </p>
    </li>
    <li>
        <h3><i>Adding the HTML helper method</i></h3>
        <ol>
            <li>In the <b>SportsStore.WebUI</b> project, create a new folder called <b>HtmlHelpers</b></li>
            <li>
                Add a new class file called <b>PagingHelpers.cs</b>  (Listing 7-18).
            </li>
        </ol><br />
        <p align="center">
            <img src="Pictures/Listing 7-18.png" /><br />
            <b>Listing 7-18.</b> The contents of the <b>PagingHelpers.cs</b> file
        </p>
    </li>
    <li>
        <h3><i>UNIT TEST: CREATING PAGE LINKS</i></h3>
        To test the <b>PageLinks </b> helper method, it will call the method with the test data and compare the results to the expected HTML. The unit test method is as follows:<br />
        <p align="center">
            <img src="Pictures/UNIT_TEST_CREATING_PAGE_LINKS.png" />
        </p>               
    </li>
    <li>
        <h3><i>Adding the View Model data</i></h3>
        <p align="center">
            <img src="Pictures/Listing 7-20.png" /><br />
            <b>Listing 7-20.</b> The contents of the <b>ProductsListViewModel.cs</b> file
        </p><br />
        <p align="center">
            <img src="Pictures/Listing 7-21.png" /><br />
            <b>Listing 7-21.</b> Updating the list method in the <b>ProductController.cs</b> file
        </p>
    </li>
    <li>
        <h3><i>UNIT TEST: PAGE MODEL VIEW DATA</i></h3>
        <ul>
            <li>
                The code below tests whether the controller sends the correct paging data to the display.<br />
                <p align="center">
                    <img src="Pictures/UNIT TEST - PAGE MODEL VIEW DATA.png" /><br />
                </p>
            </li>
            <li>
                You need to modify the previous paging unit test contained in the <b>Can_Paginate</b> method. Data has been wrapped in another view model type. You can see the modification in the code below:<br />
                <p align="center">
                    <img src="Pictures/Can_Paginate.png" /><br />
                </p>
            </li>
        </ul>
    </li>
    <li>
        <h3><i>Updating the List.cshtml File</i></h3><br />
        <p align="center">
            <img src="Pictures/Listing 7-22.png" /><br />
            <b>Listing 7-22.</b> Updating the list <b>List.cshtml</b> file
        </p>        
    </li>
</ul>

<h2><i>DISPLAYING THE PAGE LINKS</i></h2><br />
<p align="center">
    <img src="Pictures/Listing 7-23.png" /><br />
    <b>Listing 7-23.</b> Calling the HTML helper method in the <b>List.cshtml</b> file
</p><br />

If you run the application, you will see the new page links, as illustraded in <b>Figure 7-14</b><br />
<p align="center">
    <img src="Pictures/Figure 7-14.png" /><br />
    <b>Figure 7-14.</b> Displaying page navigation links
</p>

<h2><i>IMPROVING THE URLs</i></h2>
<ul>
    <li>
        MVC makes it easy to change the URL scheme in application becasuse it uses the ASP.NET <i>routing</i> feature. All you need is add a new route to the <i>RegisterRoutes</i> method in the <i>RouteConfig.cs</i> file, which you will find in the <i>App_Start</i> folder of the <i>SportsStore.WebUI</i> project. You can see the change in Listing 7-24.<br />
        <p align="center">
            <img src="Pictures/Listing 7-24.png" /><br />
            <b>Listing 7-24.</b> Adding a new route to the <b>RouteConfig.cs</b> file
        </p>
    </li>
    <li>
        Run the application and navigate to a page, you will see the new URL scheme in action, as illustrated in Figure 7-15<br />
        <p align="center">
            <img src="Pictures/Figure 7-15.png" /><br />
            <b>Figure 7-15.</b> The new URL scheme displayed in the browser
        </p>
    </li>
</ul>