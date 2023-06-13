# Chapter 16: Advanced routing features

## Generating outgoing URLs in Views

In MVC applications, the user navigates from one view to another. A static link is used for the first view that targets the action method that generates the second view, as can seen in the code below.

```
<a href="/Home/CustomVariable"> This is an outgoing URL</a>
```

The HTML element creates a simple and quick link to CustomVariable action method on the Home controller. Although simple and quick, hard coded links can be dangerous when changes are needed. All application links must be updated one by one.

The routing system is an alternative to defining the URL scheme to generate outgoing URLs dynamically.

### Using the routing system to generate an outgoing URL

To generate an outgoing URL in view open the */View/Shared/ActionName.cshtml* file, edit it to match in Listing 16-2.

<p align="center">
    <img src="ch16-Pictures/Listing 16-2.png" /><br />
    <b>Listing 16-2.</b> Using the Html.ActionLink helper method in the ActionName.cshtml file
</p>  

As seen in Listing 16-2, **Html.ActionLink** was used to create a link. Run the application and see the result in Figure 16-1.

<p align="center">
    <img src="ch16-Pictures/Figure 16-1.png" /><br />
    <b>Figure 16-1.</b> Adding an outgoing URL to a View
</p>  



* The HTML that the ActionLink method generates is based on the current routing configuration.
* For example, using the schema defined in Listing 16-1 (and assuming that the view is being rendered by a request to the Home controller) generates this HTML:

```
<a href="/Home/CustomVariable">This is an outgoing URL</a>
```

--------------------------------------------------------------------

* Now, this may seem like a long path to recreate the manually defined URL I showed you earlier, but the benefit of this approach is that is that it automatically responds to changes in the routing configuration.
*As a demonstration, I have changed the route defined and added a new route to the RouteConfig.cs file, as shown in Listing 16-3.

Listing 16-3. Adding a route to the RouteConfig.cs file
--------------------------------------------------------------------

### Targeting other controllers

### Passing extra values

### Specifying HTML attributes

### Generating fully qualified URLs in links

### Generating URLs (and not links)

### Generating Outgoing URLs in action methods

### Generating a URL from a specific route

<!--
# Chapter 16: Advanced routing features
## Generating outgoing URLs in Views
### Using the routing system to generate an outgoing URL

> SUMMARRY AND UPDATE ==========================
.
> CONTENTS =====================================
# Chapter 16: Advanced routing features
## Generating outgoing URLs in Views
### Using the routing system to generate an outgoing URL
### Targeting other controllers
### Passing extra values
### Specifying HTML attributes
### Generating fully qualified URLs in links
### Generating URLs (and not links)
### Generating Outgoing URLs in action methods
### Generating a URL from a specific route
.
> GITHUB =====================================
https://github.com/deyran/pro-asp-net-mvc/blob/main/chapter-16/03-generating-outgoing.md
.
> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->

[<BACK](02-preparing-the-example-proj.md) - [NEXT>](03-generating-outgoing.md)