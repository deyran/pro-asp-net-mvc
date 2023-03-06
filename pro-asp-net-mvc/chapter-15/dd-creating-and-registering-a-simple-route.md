# Chapter 15: URL Routing

## Creating and registering a simple route  

### P1 ----------------------

* Once you have a URL pattern in mind, you can use it to define a route.
* Routes are defined in the RouteConfig.cs file, which is in the App Start project folder.
* You can see the initial content that Visual Studio difines for this file in Listing 15-5.
    Listing 15-5. The Default contents of the RouteConfig.cs file

### P2 ----------------------

* The static RegisterRoutes method that is defined in the RouteConfig.cs file is called from the Glogal.asax.cs file, which sets up some of the core MVC features when the application is started.
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

### Using the simple route

<!--
# Chapter 15: URL Routing
## Creating and registering a simple route

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