# Chapter 15: URL Routing

## Creating and registering a simple route  

### P1 ----------------------

* Once you have a URL pattern in mind, you can use it to define a route.
* Routes are defined in the RouteConfig.cs file, which is in the App Start project folder.
* You can see the initial content that Visual Studio difines for this file in Listing 15-5.
    Listing 15-5. The Default contents of the RouteConfig.cs file

### P2 ----------------------

* The static RegisterRoutes method that is defined in the RouteConfig.cs file is called from the Global.asax.cs file, which sets up some of the core MVC features when the application is started.
* You can see the default contents of the Global.asax.cs file in Listing 15-6, and I have highlighted the call to the RouteConfig.RegisterRoutes methods, which is made from the Application_Start method.
    Listing 15-6. The Defaiult Contents of the Global.asax.cs file

### P3 ----------------------

* The Application_Start method is called by the the underlying ASP.NET platform when the MVC application is first started, which leads to the RouteConfig.RegisterRoutes methods being called.
* The parameter to this method is the value of the static RouteTable.Routes property, which is an instance of the RouteCollection class, which I describe shortly.

### P4 ----------------------

* Listing 15-7 shows how to create a route using the example URL pattern from the previous section in the RegisterRoutes methods of the RouteConfig.cs file.
* (I have removed the other statements in the methods so I can focus on the example)
    Listing 15-7. Registering o Route in the RouteConfig.cs file

### P5 ----------------------

* I created a new Route using a URL pattern as a constructor parameter, which I express as a string.
* I also pass an instance of MvcRouteHandle to the constructor.

### P6 ----------------------

* A more convenient way of registering routes is to use the MapRoute method defined by the RouteCollection class.
* Listing 15-8 shows how I can use this method to register a route, which has the same effect as the previous example, but has a cleaner syntax.
    Listing 15-8. Registering a Route using the MapRoute method in the RouteConfig.cs file

### P7 ----------------------

* This approach is more compact, mainly because I do not need to create an instance of the MvcRouterHandler class (it is done for me, behind the scenes).
* The MapRoute methods is solely for use with MVC applications.
* ASP.NET Web forms applications can use the MapPageRoute method, also defined in the RouteCollection class.

### Using the simple route

#### PP1 ----------------------

* You can see the effect of the changes I made to the routing by starting the example application.
* You will see an error when the browser tries to navigate to the root URL for the application, but if you navigate to a route that matches the {controller}/{action} pattern, you will see a result like the one shown in Figure 15-4, which illustrates the effect of navigating to /admin/Index.
    Figure 15-4. Navigating using a simple route

#### PP2 ----------------------

* My simple route in Listing 15-8 does not tell the MVC Framework how to respond to requests for the root URL and only supports a single, specific, URL, pattern.
* I have temporarily taken a step back from the functionality that Visual Studio adds to the RouteConfig.cs file when it creates the project, but I will show you how to build more complex patterns and routes throughout the rest of this chapter.

#### UNIT TEST: TESTING INCOMING URLS

##### UT2 ----------------------

* I recommend that you unit test your routes to make sure they process incoming URLs as expected, even if you choose not to unit test the rest of your application.
* URL schemas can get pretty complex in large applications, and it is easy to create something that has unexpected results.

##### UT3 ----------------------

* In previous chapters, I avoided creating common helper methods to be shared among tests in order to keep each unit test description self-contained.
* For this chapter, I am taking a different approach.

##### UT4 ----------------------

* In previous chapters, I avoided creating common helper methods to be shared among tests in order to keep each unit test description self-contained. For this chapter, i am taking a different approach.
* Testing the routing schema for an application is most readily done when you can batch several tests in a single method, and this becomes much easier with some helper methods.

##### UT5 ----------------------

* To test routes, I need to mock three classes from the MVC Framework: HttpRequestBase, HttpContextBase and HttpResponseBase.
* (This last class is required for testing outgoing URLs, which I cover in the next chapter.)
* Together, these classes recreate enough of the MVC infrastructure to support the routing system.
* I added a new Unit Tests file called RouteTests.cs to the UrlsAndRoutes.Tests unit test project and my first addition is the helper method that creates the mock HttpContextBase objects, as follows:
    CODE

##### UT6 ----------------------

* The setup here is simpler than it looks.
* I expose the URL I want to test through the AppRelativeCurrentExecutionFilePath property of the HttpRequestBase class, and expose the HttpRequestBase through the request property of the mock HttpContextBase class.
* My next helper method lets me test a route:
     CODE

##### UT7 ----------------------

* The parameters of this method let me specify the URL to test, the expected values for the controller and action segments variables, and an object that contains the expected values for any additional variables I have defined.
* I show you how to create such variable later in the chapter and in the next chapter.
* I also defined a parameter for the HTTP method, which I will explain in the "Constraining Routes" section

##### UT8 ----------------------

* The TestRouteMatch method relies on another method, TestIncomingRouteResult, to compare the result obtained from the routing system with the segment variable values I expect.
* This method uses .NET reflection so that I can use an anonymous type express any additional segment variable.
* Do not worry if this method doesn't make sense, as this is just to make testing more convenient; it is not a requirement for understanding MVC.
* Here is the TestIncomingRouteResult method:
    CODE

##### UT9 ----------------------

* I aslo need a method to check that a URL does not work.
* As you will see, this can be an important part of defining a URL schema
    CODE

##### UT10 ---------------------

* TestRouteMatch and TestRouteFail contain calls to the Assert method, which throws and exception if the assertion fails.
* Because C# exceptions are propagated up the call stack,  I can create simple test methods that test a set of URLs and get the test behavior I require.
* Here is a test method that tests the route I defined in Listing 15-8.

##### UT11 ---------------------

* This test uses the TestRouteMatch method to check the URL I am expecting and also checks a URL in the same format to make sure that the controller and action values are being obtained properly using the URL segments.
* I use the TestRouteFail method to make sure that the application won't accept URLs that have a different number of segments.
* When testing, I must prefix the URL with the tilde (~) character, because this is how the ASP.NET Framework presents the URL to the routing system.

##### UT12 ---------------------

* Notice that I didn't need to define the routes in the test methods.
* This is because I am loading them directly using the RegisterRouter method in the RouteConfig class.




<!--
# Chapter 15: URL Routing
## Creating and registering a simple route
### Using the simple route
#### UNIT TEST: TESTING INCOMING URLS    

> SUMMARRY AND UPDATE ==========================
.
> CONTENTS =====================================
# Chapter 15: URL Routing
## Creating and registering a simple route
### Using the simple route
.
> GITHUB =====================================
https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/dd-creating-and-registering-a-simple-route.md
.
> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->