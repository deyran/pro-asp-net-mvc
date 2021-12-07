<p align="center">
    In the previous chapter, the core infrastructure of the <b>SportsStore </b> application was configured. This infrastructure will now be used to add features to the application.    
</p>

<h1><i>Adding Navigation Controls</i></h1>
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

<h2><i>Filtering the Product List</i></h2>
    <ul>
        <li>Let's start with the view model class <b>ProductListViewModel</b> in the <b>SportsStore.WebUI</b> project</li>
        <li>It is necessary to communicate the current category to the view in order to render the sidebar</li>
        <li>
            	You can see this implementation in Listing 8-1, in the code below:
	        <p align="center">
                	<img src="Pictures/Listing 8-1.png" /><br />
	                <b>Listing 8-1.</b> Enhancing the <b>ProductsListView.cs</b> file
		</p>
        </li>
	<li>
		<ul>
			<li>
				The next step is to update <b>List</b> action method from the <b>ProductController</b> class. This update brings these features:
				<ol>
					<li>The <b>List</b> action method will filter <b>Product</b> object by category</li>
					<li>With the new property added to the view template it will be possible to define the category that was selected</li>
				</ol>
			</li>
			<li>
				You can see the implementation in Listing 8-2, in the code below:
			        <p align="center">
                			<img src="Pictures/Listing 8-2.png" /><br />
			                <b>Listing 8-2.</b> Adding category support to the List action method in the ProductController.cs file
				</p>
			</li>
		</ul>
	</li>
    </ul>

<h2><i>Refining the URL Scheme</i></h2>
<h2><i>Building a Category Navigation Menu</i></h2>
<h2><i>Correcting the Page Count</i></h2>