<p align="center">
    In the previous chapter, the core infrastructure of the <b>SportsStore </b> application was configured. This infrastructure will now be used to add features to the application.    
</p>

<h1><i>ADDING NAVIGATION CONTROLS</i></h1>
    This section is divided into three phrases:<br />
    <ol>
        <li>
            Enhance the <b>List</b> method in the <b>ProductController</b> class so that it is able to filter the <b>Product</b> objects in the repository
        </li>
        <li>
            Revisit and enhance the URL scheme and revise the routing strategy
        </li>
        <li>
            Create category list that will go into the sidebar of the site, highlighting the current category and linkings to others.
        </li>                
    </ol>

<h2><i>FILTERING THE PRODUCT LIST</i></h2>
    <ul>
        <li>
            Let's start with the view model class <b>ProductListViewModel</b> in the <b>SportsStore.WebUI</b> project
        </li>
        <li>
            It is necessary to communicate the current category to the view in order to render the sidebar, for this we going to use <b>CurrentCategory</b> method (Listing 8-1)
        </li>
        <li>
            You can see this implementation in Listing 8-1, in the code below:
            <p align="center">
                <img src="Pictures/Listing 8-1.png" /><br />
                <b>Listing 8-1.</b> Enhancing the <b>ProductsListView.cs</b> file
            </p>
        </li>
        <li>
            The next step is to update <b>List</b> action method from the <b>ProductController</b> class. This update brings these features:
            <ol>
                <li>
                    The <b>List</b> action method will filter <b>Product</b> object by category
                </li>
                <li>
                    With the new property added to the view template it will be possible to define the category that was selected
                </li>
            </ol>
        </li>
        <li>
            You can see the implementation in Listing 8-2, in the code below:
            <p align="center">
                <img src="Pictures/Listing 8-2.png" /><br />
                <b>Listing 8-2.</b> Adding category support to the List action method in the ProductController.cs file
            </p>
        </li>
        <li>
            <h3><i>UNIT TEST: UPDATING EXISTING UNIT TESTS</i></h3>
                <ul>
                    <li>
                        The signature of the List action method has changed and you need to sync the unit tests with the changed code
                    </li>
                    <li>
                        The methods you need to change are <b>Can_Paginate</b> and <b>Can_Send_Pagination_View_Model</b> test. The code below shows the point you need to change:<br />
                            ...<br />
                            <i>
                            ProductsListViewModel result =<br />
                            <b>(ProductsListViewModel) controller.List(null, 2).Model;</b>
                            </i><br />
                            ...
                    </li>        
                </ul>
        </li>
        <li>
            With these small changes it's possible to see the result in practice. Run the application, type <b><i>/category=Soccer</i></b> at the end of the URL, for example: <i>http://localhost:xxxxx/?category=Soccer</i>. The result you will see in <b>Figure 8-1</b> in the picture below:
            <p align="center">
                <img src="Pictures/Figure 8-1.png" /><br />
                <b>Figure 8-1.</b> Using the query string to filte by category
            </p>
        </li>
        <li>
            <h3><i>UNIT TEST: CATEGORY FILTERING</i></h3>
            It's necessary to test whether the filtering function works correctly, here is the test:
            <p align="center">
                <img src="Pictures/UT_CATEGORY_FILTERING.png" />
            </p>
        </li>
    </ul>    

<h2><i>REFINING THE URL SCHEME</i></h2>
<ul>
    <li>
        We need a different approach to avoid seeing and using URL's like <b>/?category=Soccer</b>. To implement the new scheme, you must to change the <b>RegisterRouter</b> method in the <b>App_Start/RouterConfig.cs</b>file, as shown in Listing 8-3.
        <p align="center">
            <img src="Pictures/Listing 8-3.png" /><br />
            <b>Listing 8-3.</b> The new URL scheme in the <b>RouteConfig.cs</b> file
        </p>
    </li>
    <li>
        Now, you need updating the <b>list.cshtml</b> file and pass the information to the helper method, as shown in Listing 8-4.
        <p align="center">
            <img src="Pictures/Listing 8-4.png" /><br />
            <b>Listing 8-4.</b> Adding category information to the pagination links in the List.cshtml file
        </p>
    </li>
</ul>

<h2><i>BUILDING A CATEGORY NAVIGATION MENU</i></h2>
<ul>
    <li>
        In this section, we'll implement a way for the customer to select a category without typing URLs. To make this possible, we will introduce a concept called <b>child actions</b> for creating items as a reusable navigation control
    </li>
    <li>
        The most important characteristc of the <b>child action</b> is self-contained and reusable. But what's the <b>child action</b>? The <b>child action</b> is a controller that, through its methods renders any dynamic HTML in anywhere in the View. To render any HTML in anywhere you need to use HTML Helper method called <b>Html.Action</b><br /><br />
    </li>
    <li>
        <h3><i>CREATING THE NAVIGATION CONTROLLER</i></h3>
        <ol>
            <li>
                In the <b>SportsStore.WebUI</b> project create a new Controller called <b>NavController</b> and implement the action method called <b>Menu</b>, as shown in Listing 8-5.
                <p align="center">
                    <img src="Pictures/Listing 8-5.png" /><br />
                    <b>Listing 8-5</b>. Adding the Menu action method to the NavController.cs file
                </p>
            </li>
            <li>
                Now time to integrate the child action into the rest of the application. Edit the <b>Views/Share/_Layout.cshtml</b> so that it calls the <b>Html.Action</b> helper method, as shown in Listing 8-6.
                <p align="center">
                    <img src="Pictures/Listing 8-6.png" /><br />
                    <b>Listing 8-6</b>. Adding the render action call to the _Layout.cshtml file
                </p>
            </li>
            <li>
                Run the application and see the result (Figure 8-2)
                <p align="center">
                    <img src="Pictures/Figure 8-2.png" /><br />
                    <b>Figure 8-2</b>. Adding the render action call to the _Layout.cshtml file
                </p>
            </li>            
        </ol><br />
    </li>
    <li>
        <h3><i>GENERATING CATEGORY LISTS</i></h3>
        <ul>
            <li>
                Now it will be implemented the list of category in the Menu action method in thr NavController.cs file (Listing 8-7)
                <p align="center">
                    <img src="Pictures/Listing 8-7.png" /><br />
                    <b>Listing 8-7</b>. Implementing the Menu Method in the <b>NavController.cs</b> File
                </p>
            </li>
            <li>
                <h4><i>UNIT TEST: GENERATION THE CATEGORY LIST</i></h4>
                <ol>
                    <li>
                        The Unit Test for the ability to produce a category list simple, sorted in alphabetical order and contains no duplates.
                    </li>
                    <li>
                        A mock repository was created that contains repeated categories without alphabetical order and contains duplicate items.
                    </li>
                    <li>
                        The duplicates are removed and that alphabetical ordering is imposed, as you can see in the code below:
                        <p align="center">
                            <img src="Pictures/U_T_GENERATION_THE_CATEGORY_LIST.png" /><br />
                            <b>Listing 8-7A</b>. The category list
                        </p>
                    </li>
                </ol>
            </li>
        </ul>
    </li>
    <li>
        <h3><i>CREATING THE VIEW</i></h3>
        <ol>
            <li>
                To create the view for the Menu action method (Menu.cshtml), remove the contents that Visual Studio adds to new views and set the content to match Listing 8-8
                <p align="center">
                    <img src="Pictures/Listing 8-8.png" /><br />
                    <b>Listing 8-8</b>. The content of the Menu.cshtml file
                </p>
            </li>
            <li>
                Was add a link called Home (code below) that will appear at the top of the category list and will list all of the products with no category filter. Html.ActionLink() helper was used to produce link to call all products from all categories.
                <p align="center">
                    <img src="Pictures/Listing 8-8A.png" /><br />
                    <b>Listing 8-8A</b>. Html.ActionLink() helper
                </p>
            </li>
            <li>
                The list of categories was enumerated and links to each were created using the RouteLink method (code below). This is similar to ActionLink, but it lets me supply a set of name/value pairs that are taken into account when generating the URL from the routing configuration.
                <p align="center">
                    <img src="Pictures/Listing 8-8B.png" /><br />
                    <b>Listing 8-8B</b>. Html.ActionLink() method
                </p>
            </li>
            <li>
                The objects I created define the class attribute (prefixed with a @ because class is a reserved C# keyword) and apply Bootstrap classes to style the links as large Buttons.<br />
            </li>
            <li>
                You can see the category links if you run the application, as shown in <b>Figure 8-3</b>. If you click a category, the list of
                items is updated to show only items from the selected category.
                <p align="center">
                    <img src="Pictures/Figure 8-3.png" /><br />
                    <b>Figure 8-3</b>. The category links
                </p>
            </li><br />
        </ol>
    </li>
    <li>
        <h3><i>HIGHLIGHTING THE CURRENT CATEGORY</i></h3>
        <ol>
            <li>
                The user was not informed which category he is viewing (Figure 8-3). To show which category the user is viewing, the ViewBag resource will be used to maintain which category was selected. Listing 8-9 shows the changes to the Menu action method in the Nav controller.
                <p align="center">
                    <img src="Pictures/Listing 8-9.png" /><br />
                    <b>Listing 8-9</b>. Using the View Bag Feature in the NavController.cs File
                </p>
            </li>
            <li>
                <h3><i>UNIT TEST: REPORTING THE SELECTED CATEGORY</i></h3>
                I can test that the Menu action method correctly adds details of the selected category by reading the value of the ViewBag property in a unit test, which is available through the ViewResult class. here is the test:
                <p align="center">
                    <img src="Pictures/UT_REPORTING_THE_SELECTED_CATEGORY.png" /><br />
                </p>
            </li>
            <li>
                Now that information has been provided on whicj category is selected, I can update the view to take advantage of this, and add a Bootstrap class to the HTML anchor element that represents the selected category that causes the button to be highlighted. Listing 8-10 shows the changes to the Menu.cshtml file.
                <p align="center">
                    <img src="Pictures/Listing 8-10.png" /><br />
                    <b>Listing 8-10</b>. Highlighting the Selected Category in the Menu.cshtml File
                </p>
            </li>
            <li>
                Running the application shows the effect of the category highlighting, which you can also see in Figure 8-4.
                <p align="center">
                    <img src="Pictures/Figure 8-4.png" /><br />
                    <b>Figure 8-4</b>. Highlighting the selected category
                </p>
            </li>
        </ol>
    </li>    
</ul>

<h2><i>CORRECTING THE PAGE COUNT</i></h2>
<ul>
    <li>
        Page links should be fixed when a category is selected. The heart of the problem is that the number of page links is determined by the total number of products in the repository and not by the number of products in the selected category, the consequence is when the customer in some category does not have enough product to fill some pages, the client ends up finding an empty page. You can see the problem in Figure 8-5.
        <p align="center">
            <img src="Pictures/Figure 8-5.png" /><br />
            <b>Figure 8-5</b>. Displaying the wrong page links when a category is selected
        </p>
    </li>
    <li>
        To fix this problem we need to updating the List action method in the Product controller so that the pagination information
        takes the categories into account. You can see the required changes in Listing 8-11.
        <p align="center">
            <img src="Pictures/Listing 8-11.png" /><br />
            <b>Listing 8-11</b>. Creating Category-Aware Pagination Data in the ProductController.cs File
        </p>
    </li>
    <li>
        If a category has been selected, the number of items in that category is returned; if not, the total number of products is returned. Now when a category is selected, the links at the bottom of the page correctly reflect the number of products in the category, as shown in Figure 8-6.   
        <p align="center">
            <img src="Pictures/Figure 8-6.png" /><br />
            <b>Figure 8-6</b>. Displaying category-specific page counts
        </p>
    </li>
    <li>
        <h3><i>UNIT TEST: CATEGORY-SPECIFIC PRODUCT COUNTS</i></h3>
        The purpose of this test is to ensure that the right total count is made. Here is the unit test:
        <p align="center">
            <img src="Pictures/UT_CATEGORY_SPECIFIC_PRODUCT_COUNTS.png" /><br />
        </p>
    </li>
</ul>