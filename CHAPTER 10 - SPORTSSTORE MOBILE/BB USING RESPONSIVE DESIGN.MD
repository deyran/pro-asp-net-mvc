<h1><div align="center">USING RESPONSIVE DESIGN</div></h1>
<p align="center">
	<img src="ch10-Pictures/RESPONSIVE_DESIGN.png" /><br />
	Using responsive design
</p>

<ul>
	<li>
		Responsive design creates web pages that automatically adjust to different screen sizes and viewports (the area your web page is drawn on). To make pages ability change automatically, HTML and CSS features are used to change the content layout based on the screen width	
	</li>
	<li>
		In this book our priority is study the MVC framework, so we will only see a demonstration of how the technique can be applied. The library that will be used is the Bootstrap library to style the SportsStore application.
	</li>
	<li>
		In the next sections, we will apply the Responsive design feature on the main part of the app so that it is visible in Chrome device Mode with dimensions of 305w x 639h, as Figure 10-2 shows.
		<p align="center">
			<img src="ch10-Pictures/Figure 10-2.png" /><br />
			<b>Figure 10-2.</b> Displaying the SportsStore on Chrome device mode with dimensions of 305w x 639h
		</p>		
	</li>		
</ul>

<h2><div align="center">CREATING A RESPONSIVE HEADER</div></h2>
<ul>
	<li>
		We start with the page header, which contains the SportsStore name, the cart summary, and the Checkout button. Open the _Layout.cshtml file and edit to match as Listen 10-1.
		<p align="center">
			<img src="ch10-Pictures/Listing 10-1.png" /><br />
			<b>Listing 10-1.</b> Adding Responsive content to the _Layout.cshtml file
		</p>
	</li>
	<li>
		Run the app and see the results for the SportsStore brand, the visible-xs and hidden-xs classes were used to switch to text on two lines that will be shown vertically when the window size is less than 768 pixels
		<p align="center">
			<img src="ch10-Pictures/Figure 10-3.png" /><br />
			<b>Figure 10-3.</b> Using Bootstrap responsive design features to adjust the application branding
		</p>				
	</li>
	<li>
		Now open the <i>Views/Cart/Summary.cshtml</i> file, open and edit it to match in Listing 10-2.
		<p align="center">
			<img src="ch10-Pictures/Listing 10-2.png" /><br />
			<b>Listing 10-2.</b> Adding Responsive Content to the Summary.cshtml File
		</p>				
	</li>
	<li>
		Run the application and sees the result on Chrome device mode with dimensions of 321w x 639h (<i>Figure 10-4</i>)
		<p align="center">
			<img src="ch10-Pictures/Figure 10-4.png" /><br />
			<b>Figure 10-4.</b> The modified SportsStore header displayed on Chrome device mode with dimensions of 321w x 639h
		</p>				
	</li>
</ul>

<h2><div align="center">CREATING A RESPONSIVE PRODUCT LIST</div></h2>
<ul>
	<li>
		We will now display a product list on narrow devices! To make this possible, the category buttons will disappear. Open the _Layout.cshtml File, open and edit it to match in Listing 10-3
		<p align="center">
			<img src="ch10-Pictures/Listing 10-3.png" /><br />
			<b>Listing 10-3.</b> Creating a Responsive Product List in the _Layout.cshtml File
		</p>				
	</li>
	<li>
		Now run the application and see the results in the Figure 10-5.	
		<p align="center">
			<img src="ch10-Pictures/Figure 10-5.png" /><br />
			<b>Figure 10-5.</b> Using a responsive grid in the product layout
		</p>				
	</li>
</ul>

<h2><div align="center">HELPING THE CONTROLLER SELECT A VIEW</div></h2>
<ul>
	<li>
		With the solution in the previous section we lost the functionality of the filter products. To solve this issue, create a new view called MenuHorizontal.cshtml in the Views/Nav folder with the content shown in Listing 10-4.
		<p align="center">
			<img src="ch10-Pictures/Listing 10-4.png" /><br />
			<b>Listing 10-4.</b> The Contents of the MenuHorizontal.cshtml File
		</p>				
	</li>
	<li>
		Now it's needed to update the Menu action method of the the Nav controller, as shown in Listing 10-5.
		<p align="center">
			<img src="ch10-Pictures/Listing 10-5.png" /><br />
			<b>Listing 10-5.</b> Updating the Menu Action Method in the NavController.cs File
		</p>				
	</li>
	<li>
		In the previous section, a new parameter was defined in the action method to specifies the orientation (vertical or horizontal) of the filter products. Now it's time to return to the <i>_Layout.cshtml</i>, as shown in Listing 10-6.
		<p align="center">
			<img src="ch10-Pictures/Listing 10-6.png" /><br />
			<b>Listing 10-6.</b> Updating the _Layout.cshtml File to Include the Horizontal Buttons
		</p>				
	</li>
	<li>
		The overall effect of these changes is shown in Figure 10-6.
		<p align="center">
			<img src="ch10-Pictures/Figure 10-6.png" /><br />
			<b>Figure 10-6.</b> The revised product listing for small screens
		</p>				
	</li>
</ul>

<h2><div align="center">REMOVING VIEW DUPLICATION</div></h2>
<ul>
	<li>
		In the previous example, we solve the problem but created other! This solution comes with two views, Menu.cshtml and MenuHorizontal.cshtml, that contains similar and Razor expressions. These characteristics pose a risk, as any changes requires them to be applied in two places. To resolve this issue we will consolidate the view. Create a file called <i>FlexMenu.cshtml</i> in <i>Views/Nav</i> folder and edit to match as shown in Listing 10-7.
		<p align="center">
			<img src="ch10-Pictures/Listing 10-7.png" /><br />
			<b>Listing 10-7.</b> The Contents of the FlexMenu.cshtml File
		</p>
	</li>
	<li>
		To use the consolidate view, it's need to revise the </i>Menu</i> action method in the <i>Nav</i> controller, as shown in Listing 10-8
		<p align="center">
			<img src="ch10-Pictures/Listing 10-8.png" /><br />
			<b>Listing 10-8.</b> The Contents of the FlexMenu.cshtml File
		</p>
	</li>
</ul>