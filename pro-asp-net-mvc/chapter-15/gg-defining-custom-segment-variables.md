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

> ### UNIT TEST: TESTING CUSTOM SEGMENT VARIABLES
>
> * I included support for testing custom segment variables in the test helper methods.
> * The TestRouteMatch method has an optional parameter that accepts an anonymous type containging the names of the properties I want to test for and the values I expect.
> * Here are the changes I made to the TestIncomingRoutes test method to test the route defined in Listing 15-15:
>     CODE

### Using custom variables as action method parameters

* Using the RouteData.Values property is only one way to access custom route variables.
* The other way is much more elegant.
* If I define parameters to the action method with names that match the URL pattern variables, the MVC Framework will pass the values obtained from the URL asp parameters to the action method.
* For example, the custom variable I defined in the route in Listing 15-15 is called id.
I can modify the CustomVariable action method in the Home controller so that is has a matching parameter, as shown in Listing 15-18.
    Listing 15-18. Adding an action method parameter in the HomeController.cs file

* When the routing system matches a URL against the route defined in Listing 15-18, the value of the third segment in the URL is assigned to the custom variable id.
* The MVC Framework compares the list of segment variables with the list of action method paramenters, and if the names match, passes the values from the URL to the method.

* I have defined the id parameter as a string, but the MVC Framework will try to convert the URL value to whatever parameter type I defined.
* If I declared the id parameter as an int or a DateTime, then I would receive the value from the URL parsed to an instance of that type.
* This is an elegant and useful feature that removes the need for me to handle the conversion myself.

> Note The MVC Framework uses the model binding feature to convert the values contained in the  URL to .NET types and can handle much more complex situations than shown in this example. I cover model binding in Chapter 24.

### Defining optional URL segments

* An optional URL segment is one that the user does not need to specify, but for which on default value is specified.
* Listing 15-19 shows an example, and you can see that I specify that a segment variable is optional by setting the default value to UrlParameter.Optional.
    Lising 15-19. Specifying an optional URL segement in the RouteConfig.cs file

* This routes will match URLs wheter or not the id segment has been supplied. Table 15-4 shows how this works for differents URLs.
    Table 15-4. Matching URLs with an Optional segment variable.

* As you can see from the table, the id variabel is added to the set of variables only when there is a corresponding segment in the incoming URL.
* This feature is useful if you need to know whether the user supplied a value for a segment variable.
* When no value has been supplied for an optional segment variable, the value of the corresponding parameter will be null.
* I have updated the controller to respond when no value is provided for the id segment variable in Listing 15-20.
    Listing 15-20. Checking for an Optional Segment Variable in the HomeController.cs file

* You can see the result of starting the application and navigating to the /Home/CustomVariable controller URL (which doesn't define a value for the id segment variable) in Figure 15-10.
    Figure 15-10. Detecting when a URL doesn't contain a value for an optional segment variable

#### Using custom variables as action method parameters

* Some developers who are focused on the separation of concerns in the MVC pattern do not like putting the default values for segment variables into the routes for an application.
* If this is an issue, you can use C# optional parameters along with an optional segment variable in the route to define the default values for action method parameters.
* As an example, Listing 15-21 shows the CustomVariable action method to define a default value for the id parameter that will be used if the URL doesn't contain a value.
	Listing 15-21. Defining a default value for an action method parameter in the HomeController.cs file

* There will always be a value for the id parameter (either one from the URL or the default), so I am to remove the code which deals with the null value.
* This action method combined with the route I defined in Listing 15-21 is the functional equivalent to the route shown in Listing 15-22:
    Listing 15-22. An equivalent Route

### Defining variable-lenght routes

### Prioritizing controllers by namespaces

<!--
# Chapter 15: URL Routing
## Defining custom segment variables
### Defining optional URL segments
#### Using custom variables as action method parameters

> SUMMARRY AND UPDATE ==========================
.
> CONTENTS =====================================
# Chapter 15: URL Routing
## Defining custom segment variables
### Defining optional URL segments
#### Using custom variables as action method parameters
### Defining variable-lenght routes
### Prioritizing controllers by namespaces
.
> GITHUB =====================================
https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/gg-defining-custom-segment-variables.md
.
> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->
