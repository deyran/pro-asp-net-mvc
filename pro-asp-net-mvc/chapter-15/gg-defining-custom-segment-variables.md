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

* This method obtains the value of the custom variable in the route URL pattern and passes it to the view using the ViewBag.
* To create the view for the action method, create the Views/Home folder, right-click on it, select add > MVC 5 View Page (Razor) from the pop-up menu and set the name to CustomVariable.cshtml.
* Click the OK button to create the view and edit the contents to match Listing 15-17.
    Listing 15-17. The contents of the CustomVariable.cshtml file.

* To see the effect of the custom segment variable, start the application and navigate to the URL /Home/CustomVariable/Hello.
* The CustomVariable action method in the Home controller is called, and the value of the custom segment variable is retrieved from the ViewBag and passed to the view.
You can see the results in Figure 15-8.
    Figure 15-8. Displaying the value of a custom segment variable

I have provided a default value for the id segment variable in the route, which means that you will see the results shown in Figure 15-9 if you navigate to /Home/CustomVariable.
    Figure 15-9. The default value for a custom segment variable

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
