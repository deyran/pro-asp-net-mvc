# Chapter 15: URL Routing

## Defining custom segment variables

The controller and action *segment variable* corresponds to the controller and action method, used to fulfill the request, they are default for Routing URL pattern definition. But a *custom variable* can be defined, as shown in Listing 15-15, a custom variable named **id** has been defined.

<p align="center">
    <img src="ch15-Pictures/Listing 15-15.png" /><br />
    <b>Listing 15-15.</b> Defining additional variable in a URL pattern in the RouteConfig.cs file
</p>

This route will match any zero-to-three-segment URL. The contents of the third segment will assigned to the id value will be used.

> ### CAUTION
>
> *controller*, *action*, and *area* are reserved names, so they cannot be used for custom segment variable names.  

Any segment variable can be accessed using the RouteData.Values property. As shown in Listing 15-16, an action method named CustomVariable has been added, its propurse is to get the value of the custom variable and passes it to the view through ViewBag.

<p align="center">
    <img src="ch15-Pictures/Listing 15-16.png" /><br />
    <b>Listing 15-16.</b> Accessing a custom variable in an action method in the HomeController.cs file
</p>

To see the effect of the custom segment variable, follow these steps:

1. Create an view for the *CustomVariable* action method called *CustomVariable.cshtml*, edit it to match Listing 15-17.

<p align="center">
    <img src="ch15-Pictures/Listing 15-17.png" /><br />
    <b>Listing 15-17.</b> The contents of the CustomVariable.cshtml file.
</p>

2. Start the application and navigate to the URL */Home/CustomVariable/Hello*, the result can be seen in Figure 15-8

<p align="center">
    <img src="ch15-Pictures/Figure 15-8.png" /><br />
    <b>Figure 15-8.</b> Displaying the value of a custom segment variable.
</p>

3. Now start the application using this URL */Home/CustomVariable*, and will see the use of the **default value** in Figure 15-9.

<p align="center">
    <img src="ch15-Pictures/Figure 15-9.png" /><br />
    <b>Figure 15-9.</b> The default value for a custom segment variable.
</p>

> ### UNIT TEST: TESTING CUSTOM SEGMENT VARIABLES
>
> A test for custom segment variable in the TestRouteMatch method has been added. Here are the changes that were added:

```js
TestRouteMatch("~/", "Home", "Index", new { id = "DefaultId" });
TestRouteMatch("~/Customer", "Customer", "index", new { id = "DefaultId" });
TestRouteMatch("~/Customer/List", "Customer", "List", new { id = "DefaultId" });
TestRouteMatch("~/Customer/List/All", "Customer", "List", new { id = "All" });
TestRouteFail("~/Customer/List/All/Delete");
```

### Using custom variables as action method parameters

In Listing 15-15 it was shown using RouteData.Values property to access value of the custom route variable. But there is other simple way to get the same result. To get the custom route variable value, just set parameter in the action method with names that match the URL pattern variable, as shown in Listing 15-18.

<p align="center">
    <img src="ch15-Pictures/Listing 15-18.png" /><br />
    <b>Listing 15-18.</b> Adding an action method parameter in the HomeController.cs file
</p>

The MVC Framework compares the list of segment variables with the list of action method paramenters, and if the names match, passes the values from the URL to the method.

### Defining optional URL segments

An optional URL segment is a route with an optional parameter. This means that if an optional parameter is not provided, the default value (**UrlParameter.Optional**) will be set and the route can be used without any problem. Listing 15-19 shows an example in the RouteConfig.cs file.

<p align="center">
    <img src="ch15-Pictures/Listing 15-19.png" /><br />
    <b>Listing 15-19.</b> Adding an action method parameter in the HomeController.cs file
</p>

The Table 15-4 shows how this works for different URLs.

Example URL|Maps to
---------|--------
mydomain.com | controller=Home - action=Index
mydomain.com/Customer | controller=Customer - action=Index
mydomain.com/Customer/List | controller=Customer - action=List
mydomain.com/Customer/List/All | controller=Customer - action=List - id=All
mydomain.com/Customer/List/All/Delete | No match

As can be seen, **id** variable has been added only when there is a corresponding segmet in the incoming URL. When no value is provided, the corresponding parameter will be set to null.

Now update the *HomeController.cs* file to respond when no value is provided, as show in Listing 15-20

<p align="center">
    <img src="ch15-Pictures/Listing 15-20.png" /><br />
    <b>Listing 15-20.</b> Checking for an Optional Segment Variable in the HomeController.cs file
</p>

Start the application navigating to the */Home/CustomVariable* controller URL, as show in Figure 15-10.

<p align="center">
    <img src="ch15-Pictures/Figure 15-10.png" /><br />
    <b>Figure 15-10.</b> Detecting when a URL doesn't contain a value for an optional segment variable
</p>

<!--
# Chapter 15: URL Routing
## Defining custom segment variables 392
### Defining optional URL segments
#### Listing 15-20. Checking for an Optional Segment Variable in the HomeController.cs file
-->

#### Using custom variables as action method parameters

* Some developers who are focused on the separation of concerns in the MVC pattern do not like putting the default values for segment variables into the routes for an application.
* If this is an issue, you can use C# optional parameters along with an optional segment variable in the route to define the default values for action method parameters.
* As an example, Listing 15-21 shows the CustomVariable action method to define a default value for the id parameter that will be used if the URL doesn't contain a value.
 Listing 15-21. Defining a default value for an action method parameter in the HomeController.cs file

* There will always be a value for the id parameter (either one from the URL or the default), so I am to remove the code which deals with the null value.
* This action method combined with the route I defined in Listing 15-21 is the functional equivalent to the route shown in Listing 15-22:
    Listing 15-22. An equivalent Route

* The difference is that the default value for the id segment variable is defined in the controller code and not in the routing definition.

> ### UNIT TESTING: OPTIONAL URL SEGMENTS
>
> * The issue to be aware of when testing optional URL segments is that the segment variable will not be added to the RouteData.Values collections unless a value was found in the URL.
> * This means that you should not include the variable in the anonymous type unless you are testing a URL that contains the optional segment.
> * Here are the changes to the TestIncomingRoutes unit test method for the route defined in Listing 15-22.
>   CODE

### Defining variable-lenght routes

* Another way of changing the default conservatism of URL patterns is to accept a variable number of URL segments.
* This allows you to route URLs of arbitrary lengths in a single route.
* You define support for variable segments by designating one of the segment variables as a catchall, done by prefixing it with an asterisk (*), as shown in Listing 15-23.
    Listing 15-23. Designating a catchall variable in the RouteConfig.cs file

* I have extended the route from the previous example to add a catchall segment variable, which I imaginatively called catchall.
* This route will now match any URL, irrespective of the number of segments it contains or the value of any of those segments. The first three segments are used to set values for the controller, action, and id variables, respectively.
* If the URL contains additional segments, they are all assgned to the catchall variable, as shown in Table 15-5.
 Table 15-5. Matching Urls with a catchall segment variable

* There is no upper limit to the number of segments that the URL pattern in this route will match.
* Notice that the segments captured by the catchall are presented in the form segment/segment/segment.
* I am responsible for processing the string to break out the individual segments.

> ### UNIT TEST: TESTING CATCHALL SEGMENT VARIABLES
>
> * I can treat a catchall variable just like a custom variable.
> * The only difference is that I must expect multiple segments to be concatenated in a single value, such as segment/segment/segment.
> * Notice that I will not receive the leading or trailing / character.
> * Here are the changes to the TestIncomingRoutes method that demonstrate testing for a catchall segment, using the route defined in Listing 15-23 and the URLs shown in Table 15-5:
 TABLE

### Prioritizing controllers by namespaces

* When an incoming URL matches a route, the MVC Framework takes the values of the controller variable and looks for the appropriate name.
* For example, when the value of the controller variable is Home, then the MVC Framework looks for a controller called HomeController.
* This is an unqualified class name, which means that the MVC Framework doesn't know what to do if there are two or more class called HomeController in different namespaces.
* To demonstrate the problem, create a new folder in the root of the example project called AdditionalControllers and add a new Home controller, setting the contents to match those in Listing 15-24.
    Listing 15-24. The contents of the AdditionalControllers/HomeController.cs file

* When you start the app, you will see the error shown in Figure 15-11.  
    Figure 15-11. The error displayed when there are two controller with the same name

* The MVC Framework searched for a class called HomeController and found two: one in the original RoutesAndUrls.Controllers namespace and one in the new RouteAndUrls.AdditionalControllers namespace.
* If you read the text of the error shown in Figure 15-11, you can see that the MVC Framework helpfully reports which class it has found.

* This problem arises more often than you might expect, especially if you are working on a large MVC project that uses libraries of controllers from other development teams or third-party suppliers.
* It is natural to name a controller relating to user accounts AccountController, for example, and it is only a matter of time before you encounter a namimg clash

* To address this problem, I can tell the MVC Framework to give preference to certain namespaces when attempting to resolve the name of a controller class, as demonstrated in Listing 15-25.  
    Listing 15-25. Specifying namespace resolution order in the RouteConfig.cs file

* I express the namespaces as an array of strings and in the listing I have told the MVC Framework to look in the URLsAndRoutes.AdditionalControllers namespace before looking anywhere else.

* If a suitable controller cannot be found in that namespace, then the MVC Framework will default to its regular behavior and look in all of the available namespaces.
* if you start the app once you have made this addition to the route, you will see the result shown in Figure 15-12, which shows that the request for the root URL, which is translated in to a request for the Index action method in the Home controller, has been sent to the controller in the additionalControllers namespace.
    Figure 15-12. Giving priority to controllers in a specified namespaces

* The namespaces added to a route are given equal priority.
* The MVC Framework does not check the first namespace before moving on to the second and so forth.
* For example, suppose that I added both of the project namespaces to the routes, like this:

```js
CODE
```

* I would see the same error as shown in Figure 15-11, because the MVC Framework is trying to resolve the controller class name in all of the namespace added to the route.
* If I want to give preference to a single controller in one namespace, but have all other controller resolved in another namespace, I need to create multiple routes, as shown in Listing 15-26.  
    Listing 15-26. Using Multiple routes to control namespace resolution in the RouteConfig.cs file

* The first route applies when the user explicitly requests a URL whose first segment is Home and will target the Home controller in the AdditionalControllers folder.
* All other requests, including those where no first segment is specified, will be handled by controlled in the Controllers folder.

* I can tell the MVC Framework to look only in the namespace that I specify.
* If a matching controller cannot be found, then the framework will not search elsewhere.
* Listing 15-27 shows how this feature is used.  
    Listing 15-27. Disabling fallback namespaces in the RouteConfig.cs file

* The MapRoute method returns a Route object.
* I have been ignoring this in previous examples, because I didn't need to make any adjustments to the routes that were created.
* To disable searching for controllers in other namespaces, I take the Route object and set the UseNamespaceFallback key in the DataTokens collection property to false.
* This setting will be passed along to the component responsible for finding controllers, which is known as the controller factory and which I discuss in detail in Chapter 9.
* The effect of this addition is that requests that cannot be satisfied by the Home controller in the AdditionalControllers folders will fail.

[<BACK](ff-using-static-url-segments.md) - [NEXT>](hh-constraining-routes.md)

<!--
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