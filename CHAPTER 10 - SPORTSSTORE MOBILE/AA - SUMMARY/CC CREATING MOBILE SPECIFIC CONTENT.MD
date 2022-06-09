# CREATING MOBILE SPECIFIC CONTENT

In the previous section, we saw the *Responsive Design* has the following characteristics:  
1. Same content to all devices;
2. Css is used to found out how the content should be presented
3. This process doesn't involves server-side of the applications
4. All devices is treated as being variations on the same client basic theme

The alternative approach is to use server to analyse the client's browser and return different views to different clients. For this alternative approach the Mvc framework supports a feature called *Display Mode* to create different views based on the client. In this section we will use a simpler form of display mode to handle mobile devices using *JQuery Mobile library*.

## CREATING A MOBILE LAYOUT
1. Open the *Package Manager Console* (Tools > NuGet Package Manager) and install the *JQuery Mobile library*, as shown below:
```js
Install-Package jquery.mobile -Version 1.3.2
Install-Package jquery -Version 1.9.1
```

2. Create a file called *_Layout.Mobile.cshtml* in the *Views/Shared* folder following these steps:
	1. Right-click the *shared* folder.
	2. Select *Add > 5 Layout Page (Razor)*.
	3. Type *_Layout.Mobile* from the pop-up menu
	4. Edit it to match Listing 10-9.  
		<p align="center">
			<img src="ch10-Pictures/Listing 10-9.png" /><br />
			<b>Listing 10-9.</b> The Contents of the _Layout.Mobile.cshtml File
		</p>

3. Open the *_ViewStart.cshtml* file and change the variable value from *"~/Views/Shared/_Layout.cshtml"* to *"~/Views/Shared/_Layout.Mobile.cshtml"*, run the application to see the result seen in Figure 10-7.
	<p align="center">
		<img src="ch10-Pictures/Figure 10-7.png" /><br />
		<b>Figure 10-7.</b> The effect of creating a mobile layout in the SportsStore application
	</p>

## CREATING THE MOBILE VIEWS
1. In the *Views/Nav* folder create a file called *FlexMenu.Mobile.cshtml* using the same steps seen in the previous section, open and edit it to match with the content shown in Listing 10-10.    
<p align="center">
	<img src="ch10-Pictures/Listing 10-10.png" /><br />
	<b>Listing 10-10.</b> The Contents of the FlexMenu.Mobile.html File
</p>

2. Now open *NavControlle.cs* file and edit it to match with the content shown in Listing 10-10A.
<p align="center">
	<img src="ch10-Pictures/Listing 10-10A.png" /><br />
	<b>Listing 10-10A.</b> The Contents of the NavControlle.cs File
</p>


CHAPTER 10 - SPORTSSTORE MOBILE
	CREATING MOBILE SPECIFIC CONTENT
		CREATING THE MOBILE VIEWS
			Listing 10-10. The Contents of the FlexMenu.Mobile.html File