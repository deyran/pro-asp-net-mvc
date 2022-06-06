# CREATING MOBILE SPECIFIC CONTENT

In the previous section, we saw the *Responsive Design* has the following characteristics: \
	1. Same content to all devices;
	2. Css is used to found out how the content should be presented
	3. This process doesn't involves server-side of the applications
	4. All devices is treated as being variations on the same client basic theme

An alternative approach is to use the server to assess the capabilities of the client browser and send different HTML to different kinds of client. This works well if you want to present a completely different aspect of the application on the desktop to, say, a tablet.

The MVC Framework supports a feature called display modes, which allows you to create different views that are delivered based on the client that has made the request, a feature provided by the ASP.NET Framework. I explain how you can create and manage display modes in depth in my Pro ASP.NET MVC 5 Platform book, but for the SportsStore application, I am going to use the simplest form of display modes, which is to treat all mobile devices as being the same. My goal will be to deliver an experience to mobile devices using the popular jQuery Mobile library, while
keeping the existing content for desktop devices.

## Creating a mobile layout
## Creating the mobile views

CHAPTER 10 - SPORTSSTORE MOBILE
	CREATING MOBILE SPECIFIC CONTENT