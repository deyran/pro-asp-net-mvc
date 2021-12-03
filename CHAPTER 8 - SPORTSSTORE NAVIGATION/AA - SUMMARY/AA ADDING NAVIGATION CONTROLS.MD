<p align="center">
    <h2>
        In the chapter 7 was set up the core infrastructure of the SportsStore application, now will be used this infrastructre to add features to the application.
    </h2>
</p>

<h1>ADDING NAVIGATION CONTROLS</h1>

<h2><i>FILTERING THE PRODUCT LIST</i></h2>
    <b>Listing 8-1</b>. Enhancing the <b>ProductListView.cs</b> file
    <b>Listing 8-2</b>. Adding category support to the list action method in the <b>ProductController.cs</b> file
    <h3><i>UNIT TEST - UPDATING EXISTING UNIT TESTS</i></h3>
    <b>Figure 8-1</b>. Using the query string to filter by category
    <h3><i>UNIT TEST - CATEGORY FILTERING</i></h3>

<h2><i>REFINING THE URL SCHEME</i></h2>
    <b>Listing 8-3</b>. The new URL Scheme in the <b>RouteConfig.cs</b> file
    <b>Listing 8-4</b>. Adding category information to the pagination links in the <b>List.cshtml</b>

<h2><i>BUILDING A CATEGORY NAVIGATION MENU</i></h2>
    <h3><i>Creating the navigation controller</i></h3>
        <b>Listing 8-5</b>. Adding the menu action method to the <b>NavController.cs</b> file.
        <b>Listing 8-6</b>. Adding the <b>RenderAction</b> call the <b>_Layoutcshtml</b> file.
        <b>Figure 8-2</b>. Displaying the output from the menu action method
    <h3><i>Generating category lists</i></h3>
        <b>Listing 8-7</b>. Implementing the menu method in the <b>NavController.cs</b> file
        <h3><i>UNIT TEST - GENERATING THE CATEGORY LIST</i></h3>
    <h3><i>Creating the view</i></h3>
        <b>Listing 8-8</b>. The contents of the <b>Menu.cshtml</b> file
        <b>Figure 8-3</b>. The category links
    <h3><i>Highlighting the current category</i></h3>
        <b>Listing 8-9</b>. Using the <b>ViewBag</b> feature in the <b>NavController.cs</b> file
        <h3><i>UNIT TEST - REPORTING THE SELECTED CATEGORY</i></h3>
        <b>Listing 8-10</b>. Highlighting the selected category in the <b>Menu.cshtml</b> file.
        <b>Figure 8-4</b>. Hightlighting the selected category

<h2><i>CORRECTING THE PAGE COUNT</i></h2>
    <b>Figure 8-5</b>. Displaying the wrong page links when a category is selected
    <b>Listing 8-11</b>. Creating category-awre pagination data in the <b>ProductController.cs</b> file.
    <b>Figure 8-6</b>. Displaying category-specific page counts
    <h3><i>UNIT TEST - CATEGORY-SPECIFIC PRODUCT COUNTS</i></h3>