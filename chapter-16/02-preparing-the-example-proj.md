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

* Later in the chapter I describe the areas feature, which requires a new package be installed in to the project.
* Enter the following command into the NeGet console:

```
Install-Package Microsoft.AspNet.Web.Optimization -version 1.1.0
```

================================================================

* This package contains functionality for optimizing the JavaScript and CSS files in the project, which I describe in chapter 26.
* I won't be using this feature directly in this chapter, but the areas feature has a dependency on it.

### Updating the Unit Test project

<!--
# Chapter 16: Advanced routing features
## Preparing the example project
### Adding the optimization package

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