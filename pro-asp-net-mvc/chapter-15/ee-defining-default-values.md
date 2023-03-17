# Chapter 15: URL Routing

## Defining default values

### P1 ----------------------------

* The reason that I got an error when I requested the default URL for the application is that it didn't match the route I had defined.
*The Default URL is expressed as ~/ to routing system and there are no segments in this string that can be matched to the controller and action variables defined by the simple route pattern.

### P2 ----------------------------

* I explained earlier that URL pattern are convervative, in that they will match only URLs with the specifed number of segments.
* I also said that this was the default behavior and one way to change this behavior is to use default values.
* A default value is applied when the URL doesn't contain a segment that can be matched to the value.
* Listing 15-9 provides an example of a route that contains a default value.
    Listing 15-9. Providing a default value in the RouteConfig.cs file

### P3 ----------------------------

* Default values are supplied as properties in an anonymous type.
* In Listing 15-9, I provided a default value of Index for the action variable.
* This route will match all two-segment URLs, as it did previously.
* For example, if the URL **ht<span>tp://</span>mydomain.com/Home/Index** is requested, the route will extract Home as the value for the controller and Index as the value for the action.

### P4 ----------------------------

* Now that I have provided a default value for the action segment, the route will also match single-segment URLs as well.
* When processing a single-segment URL, the routing system will extract the controller value from the sole URL segment, and use the default value for the action variable.
* In this way, I can request the URL **ht<span>tp://</span>mydomain.com/Home** and invoke the Index action method on the Home controller.

### P5 ----------------------------

* I can go futher and define URLs that do not contain any segment variable at all, relying on just the default values to identify the action and controller.
* And as an example, Listing 15-10 shows how I have mapped the root URL for the application by providing default values for both segments.
    Listing 15-10. Providing action and controller default values in the RouteConfig.cs file

### P6 ----------------------------

* By providing default values for both the controller and action variables, I have created a route that will match URLs that have zero, one, or two segments, as showm in Table 15-3.

### P7 ----------------------------

* The fewer segments I receive in the incoming URL, the more I rely on the default values, up until the point I receive a URL with no segments and only default values are used.
* You can see the effect of the default values by starting the example app again.
* This time, when the browser requests the root URL for the application, the default values for the controller and action segment variables will be used, which will lead the MVC Framework to invoke the Index action method on the Home controller, as shown in Figure 15-5.
    Figure 15-5. Using default values to broaden the scope of a route

### Unit Testing: Default Values

### U1 ----------------------------

### U2 ----------------------------

<!--
# Chapter 15: URL Routing
## Defining default values
### P7 ----------------------------
### Unit Testing: Default Values

##### UNIT TEST TestIncomingRoutes

> SUMMARRY AND UPDATE ==========================
.
> CONTENTS =====================================
# Chapter 15: URL Routing
## Defining default values
.
> GITHUB =====================================
https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/ee-defining-default-values.md
.
> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->