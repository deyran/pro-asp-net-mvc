<h1 align="center">
    Chapter 15: URL Routing
</h1>

## Preparing the example project
* To demonstrate the *routing system*, follow these steps:
1. Create a new MVC application (Empty template) called UrlsAndRoutes
2. Add a test project to the *Solution* called *UrlsAndRoutes.Tests* by checking *Also create a project for unit tests* option, as shown in Figure 15-1. 
<p align="center">
    <img src="ch15-Pictures/Figure 15-1.png" /><br />
    <b>Figure 15-1.</b> Creating an Empty MVC application project with unit tests
</p>  

* It is still need to add Moq, so open the *Package Manager Console*, select *UrlsAndRoutes.Tests* as *Default project* and type:  
```js
Install-Package Moq -version 4.1.1309.1617
```

### Creating the example controllers
To demonstrate the routing feature, simple controllers will be added to the application. To start this demonstration, follow these steps:
1. Create the *HomeController.cs file*, and set its contents to match those in Listing 15-1.
<p align="center">
    <img src="ch15-Pictures/Listing 15-1.png" /><br />
    <b>Listing 15-1.</b> The contents of the HomeControllers.cs file
</p>  

2. Create the *CustomerController.cs* file and set its contents to match Listing 15-2.  
<p align="center">
    <img src="ch15-Pictures/Listing 15-2.png" /><br />
    <b>Listing 15-2.</b> The contents of the CustomerController.cs file
</p>  

3. Create the *AdminController.cs* file and edit its contents to match the code shown in Listing 15-3.
<p align="center">
    <img src="ch15-Pictures/Listing 15-3.png" /><br />
    <b>Listing 15-3.</b> The contents of the AdminController.cs file
</p>  

### Creating the View
### Setting the start URL and testing application

<!--
# Chapter 15: URL Routing
    ## Preparing the example project
        ### Creating the example controllers
            Listing 15-3. The contents of the AdminController.cs file

> SUMMARRY AND UPDATE ==========================

> CONTENTS =====================================
# Chapter 15: URL Routing
## Preparing the example project
### Creating the example controllers
### Creating the View
### Setting the start URL and testing application

> GITHUB =====================================
https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/aa-preparing-the-example-project.md

> # ==========================================
#DotNet #csharp #dotnetcore #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #Actions #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting
-->