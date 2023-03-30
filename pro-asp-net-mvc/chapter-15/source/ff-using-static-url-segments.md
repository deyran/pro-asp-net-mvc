# Chapter 15: URL Routing

## Using static URL segments

### P1 -----------------------------------------

* Not all of the segments in a URL pattern need to be variables.
* You can also create patterns that have static segments.
* Suppose that I want to match a URL like this to support URLs that are prefixed with Public:
    http://mydmain.com/Public/Home/Index
* I can do so by using a pattern like the one shown in Listing 15-11.
    Listing 15-11. A URL pattern with static segments in the RouteConfig.cs file

### P2 -----------------------------------------

* This new pattern will match only URLs that contain three segments, the first of which must be Public.
* The other two segments can contains any value, and wil be used for the controller and action variables.
* If the last two segments are omitted, then default values will be used.

### P3 -----------------------------------------

* I can also create URL patterns that have segments containing both static and variable elements, such as the one shown in Listing 15-12.
    Listing 15-12. A URL Pattern with a Mixed segment in the RouteConfig.cs file

### P4 -----------------------------------------

* The pattern in this route matches any two-segment URL where the first segment starts with the letter X.
* The value for controller is taken from the first segment, excluding the X.
* The action value is taken from the second segment.
* You can see the effect of this route if you start the application and navigate to /XHome/Index, the result of which is illustrated by Figure 15-6.
    Figure 15-6. Mixing static and variable elements in a single segment.

### ROUTE ORDERING

### R1 -----------------------------------------

* In Listing 15-12, I defined a new route and placed it before all of the others in the RegisterRoutes method.
* I did this because routes are applied in the order in which they appear in the RouteCollection object.
* The MapRoute method adds a route to the end of the collection, which means that routes are generally applied in the order in which they are defined.
* I say "generally" because there are methods that insert routes in specific locations.
* I tend not to use these methods, because having routes applied in the order in which they are defined makes understanding the routing for an application simpler.

### R2 -----------------------------------------

* The route system tries to match an incoming URL against the URL pattern of the route that was defined first, and proceeds to the next route only if there is no match.
* The routes are tried in sequence until a match is found or the set of routes has been exhausted.
* The route I added in Listing 15-2 is more specific than the route that follows.
* Suppose that I reversed the order of the routes, likes this:
	CODE

### R3 -----------------------------------------

* Then the first route, which matches any URL with zero, one, or two segments, will be the one that is used.
* The more specific route, which is now second in the list, will never be reached.
* The new route excludes the leading X of a URL, but this won't be done by the older route.
* Therefore, a URL such as this: http://mydomain.com/XHome/Index

### R4 -----------------------------------------

* Will be target to a controller called XHome, which does not exist, and so will lead to a 404-Not Found error being sent to the user.

### P5 -----------------------------------------

* I can combine static URL segments and default values to create an alias for a specific URL.
* This can be useful if you have published your URL schema publicly and it has formed a contract with your user.
* If you refactor an application in this situation, you need to preserve the previous URL format so that any URL favorites, macros or scripts the user has created continue to work.
* Imagine that I used to have a controller called Shop, which has now been replaced by the Home controller.
* Listing 15-13 shows how I can create a route a preserve the old URL schema.
	Listing 15-3. Mixing static URL segments and default values in the RouteConfig.cs file

### P6 -----------------------------------------

* The route I added matches any two-segment URL where the first segment is Shop.
* The action value is taken from the second URL segment.
* The URL pattern doesn't contain a variable segment for controller, so the default value I have supplied is used.
* This means that a request for an action on the Shop controller is translated to a request for the Home controller.
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

<!--
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