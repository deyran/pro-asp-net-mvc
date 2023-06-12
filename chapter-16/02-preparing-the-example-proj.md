# Chapter 16: Advanced routing features

## Preparing the example project

The UrlsAndRoutes project (from the previous chapter) will be used, but it's necessary to delete the AdditionalControllers folder and HomeController.cs file. To perform the deletion, right-click on the AdditionalControllers folder and select Delete from the pop-up menu.

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

1. AAAA
2. AAAA

* I need to make two changes to the unit test project.
* The first is to delete the TestIncomingRoutes method, which I won't be using since this chapter is about generating outgoing routes.
* To avoid failed tests, simply remove the method from the RouteTests.cs file

================================================================================================

* The second changes is to add a reference to the System.Web.MVC namespace, which I do by installing the MVC NuGet package into the unit test project.
Enter the following commands into the NuGet console:
    Install-Package Microsoft.Aspnet.MVC -version 5.0.0

================================================================================================

* I need to add the MVC 5 package so that I can use some help methods to generate outgoing URLs.
* I didn't need to do this in the last chapter because the support for dealing with incoming URLs is in the System.Web and System.Web.Routing namespaces.

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

[<BACK](01-Introduction.md) - [NEXT>](02-preparing-the-example-proj.md)