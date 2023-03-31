# Chapter 15: URL Routing

## Defining custom segment variables

* The controller and action segment variable have special meaning to the MVC Framework and, obviously, they correspond to the controller and action method that will be used to service the request.
* But these are only the built-in segment variable.
* I can also define my own variable, as shown in Listing 15-15
* (I have removed the existing routes from the previous section so I can start over).
    Listing 15-15. Defining additional variable in a URL pattern in the RouteConfig.cs file


* The route's URL pattern defines the standard controller and action variables, as well as a custom variable called id.
* This route will match any zero-to-three-segment URL.
* The contents of the third segment will assigned to the id value will be used.

> ### CAUTION
>
> * Some nomes are reserved and no available for custom segment variable names.
> * These are controller, action, and area.
> * The meaning of the first two is obvious, and I will explain areas in the next chapter.

* I can access any of the segment variables in an action method by using the RouteData.Values property
* To demonstrate this, I have added an action method to the Home controller called CustomVariable, as shown in Listing 15-16.
    Listing 15-16. Accessing a custom variable in an action method in the HomeController.cs file

### Using custom variables as action method parameters

### Defining optional URL segments

### Defining variable-lenght routes

### Prioritizing controllers by namespaces

<!--
# Chapter 15: URL Routing
## Defining custom segment variables

> SUMMARRY AND UPDATE ==========================
.
> CONTENTS =====================================
# Chapter 15: URL Routing
## Defining custom segment variables
### Using custom variables as action method parameters
### Defining optional URL segments
### Defining variable-lenght routes
### Prioritizing controllers by namespaces
.
> GITHUB =====================================
https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/gg-defining-custom-segment-variables.md
.
> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->
