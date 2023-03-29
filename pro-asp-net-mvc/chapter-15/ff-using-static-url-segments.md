# Chapter 15: URL Routing

## Using static URL segments

Not all of the segments in a URL pattern need to be variables you can also create patterns that have static segments. For example, assuming you need a URL with a **Public** static prefix like in ht</span>tp://mydmain.com/**Public**/Home/Index, in Listing 15-11 shows how this URL can be set.

<p align="center">
    <img src="ch15-Pictures/Listing 15-11.png" /><br />
    <b>Listing 15-11.</b> A URL pattern with static segments in the RouteConfig.cs file
</p>

It is possible to create URL patterns that have segments containing both static and variable elements, such as the one shown in Listing 15-12.

<p align="center">
    <img src="ch15-Pictures/Listing 15-12.png" /><br />
    <b>Listing 15-12.</b> A URL Pattern with a Mixed segment in the RouteConfig.cs file
</p>
    
The pattern in this route matches any two-segment URL where the first segment starts with the letter X. Start the application and navigate using this URL: /**X**Home/Index, the result of which is illustrated by Figure 15-6.

<p align="center">
    <img src="ch15-Pictures/Figure 15-6.png" /><br />
    <b>Figure 15-6.</b> Mixing static and variable elements in a single segment
</p>

> ### ROUTE ORDERING
>
> In Listing 15-22, a new route has been defined and placed before all of the others in the *RegisterRoute* method. This happens because the *MapRoute* method adds a route to the end of the collection, applying them in the order they are defined in the *RouteCollection* object. This approach makes a simple application understandable.
>
> The route system takes the *incoming URL*, starting with the first route defined in the collection, iterate through that collection, comparing *incoming URL* with each URL pattern of the route, until a match or the set of routes is exhausted. The route showed in Listing 15-2 is more specifict than the route that follows. Suppose the order of the routes is reversed, like this:

```js
routes.MapRoute(
	"MyRoute",
	"{controller}/{action}",
	new { controller = "Home", action = "Index" }
);

routes.MapRoute(
	"",
	"X{controller}/{action}"
);
```

> Then the first route, which matches any URL with zero, one, or two segments, will be the one that is used. The more specific route, which is now second in the list, will never be reached. The new route excludes the leading X of a URL, so a URL like this *ht<span>tp:/</span>/mydomain.com/**X**Home/Index* will be target to a controller called *XHome*, which does not exist, and so will lead to a **404-Not Found error** being sent to the user.

### P5 -----------------------------------------

* I can combine static URL segments and default values to create an alias for a specific URL.

    > combine | static URL segments | default values | alias | specific URL

* This can be useful if you have published your URL schema publicly and it has formed a contract with your user.

    > Useful | URL schema | user contract

* If you refactor an application in this situation, you need to preserve the previous URL format so that any URL favorites, macros or scripts the user has created continue to work.

    > Refector | preserve URL

* Imagine that I used to have a controller called Shop, which has now been replaced by the Home controller.

    > controller called Shop | replaced by the Home controller

* Listing 15-13 shows how I can create a route a preserve the old URL schema.
    > Listing 15-13 shows how to create a route to preserve the old URL schema

	Listing 15-3. Mixing static URL segments and default values in the RouteConfig.cs file

<!--
# Chapter 15: URL Routing
## Using static URL segments
### P5 -----------------------------------------

> SUMMARRY AND UPDATE ==========================
.
> CONTENTS =====================================
# Chapter 15: URL Routing
## Using static URL segments
### ROUTE ORDERING
### UNIT TEST: TESTING STATIC SEGMENTS
.
> GITHUB =====================================
https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/ff-using-static-url-segments.md
.
> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->

### P6 -----------------------------------------

* The route I added matches any two-segment URL where the first segment in Shop.
* The action value is taken from the second URL segment.
* The URL pattern doesn't contain a variable segment for controller, so the default value I have supplied is used.
* This maeans that a request for an action on the Shop controller is translated to a request for the Home controller.
* You can see the effect of this route by starting the app and navigating to the /Shop/Index URL.
* As Figure 15-7 shows, the new route causes the MVC Framework to target the Index action method in the Home controller.
	Figure 15-7. Creating an alias to preserve URL schemas.

### P7 -----------------------------------------

* I can go one step futher and create aliases for action methods that have been refactored away as well and are no longer present in the controller.
* To do this, I create a static URL and provide the controller and action values as defaults, as shown in Listing 15-14.
    Listing 15-14. Aliasing a controler and action in the RouteConfig.cs file.

### P8 -----------------------------------------

* Notive that, once again, I have placed the new route so that it is defined first.
* This is because it is more specific than the routes that follow.
* If a request for Shop/OldAction were processed by the next defined route, for example, I would get a different result from the one I want.
* The request would be deal with using a 404-Not Found error, rather than being translated in order to preserve a contract with my clients.

### UNIT TEST: TESTING STATIC SEGMENTS

* Once again, I can use my helper methods to routes whose URL patterns contain static segments.
* Here is the additional I made to the TestIncomingRoutes unit test method to test the route added in Listing 15-14:
	CODE