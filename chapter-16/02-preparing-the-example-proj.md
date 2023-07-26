# Chapter 16: Advanced routing features

## Preparing the example project

The UrlsAndRoutes project (chapter 15) will be used, but it's necessary to delete the **AdditionalControllers** folder and **HomeController.cs file**. To perform this deletion, right-click on the AdditionalControllers folder and select Delete from the pop-up menu.

### Simplifying the routes

Open the *App_Start/RouteConfig.cs* file, edit it to match the content shown in Listing 16-1.

<p align="center">
    <img src="ch16-Pictures/Listing 16-1.png" /><br />
    <b>Listing 16-1.</b> Simplifying the example routes in the RouteConfig.cs file
</p>  

### Adding the optimization package

The *areas feature* will be seen later in this chapter, for now it's necessary to install a new package, *areas feature* has a dependency on it. Enter the following commands in to the NeGet console:

```
Install-Package Microsoft.AspNet.Web.Optimization -version 1.1.0
```

This packge contains functionality for optimizing the JavaScript and CSS files (will be seen in chapter 26)

### Updating the Unit Test project

Two changes are needed to the unit test project, they are:

1. To avoid failed tests, delete the *TestIncomingRoutes* method from the *RouteTests.cs* file
2. Open the *Package Manager Console* install the package below:

```
Install-Package Microsoft.Aspnet.MVC -version 5.0.0
```

This package is needed to use some help methods to generate outgoing URLs

<!--
# Chapter 16: Advanced routing features
## Preparing the example project
### Updating the Unit Test project

> SUMMARRY AND UPDATE ==========================
.
> CONTENTS =====================================
# Chapter 16: Advanced routing features
## Preparing the example project
### Simplifying the routes
### Adding the optimization package
### Updating the Unit Test project
.
> GITHUB =====================================
https://github.com/deyran/pro-asp-net-mvc/blob/main/chapter-16/02-preparing-the-example-proj.md
.
> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->

[<BACK](01-Introduction.md) - [NEXT>](03-generating-outgoing.md)
