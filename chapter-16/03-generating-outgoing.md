# Chapter 16: Advanced routing features

## Generating outgoing URLs in Views

In MVC applications, the user navigates from one view to another. A static link is used for the first view that targets the action method that generates the second view, as can seen in the code below.

```
<a href="/Home/CustomVariable"> This is an outgoing URL</a>
```

=======================================

* With the standard routing configuration, the HTML element creates a link that will target the CustomVariable action method on the Home controller.
* Manually defined URLs like this one are quick and simple to create.
* They are also extremely dangerous and you will break all of the URLs you have hard-coded when you change the URL schema for your application.
* You then must trawl through all of the views in your application and update all of the references to you controllers and action methods, a process that is dedious, error-prone, and difficult to test.
* A better alternative is to use the routing system to generate outgoing URLs, which ensures that the URLs scheme is used to produce the URLs dynamically and in a way that is guaranteed to reflect the URL schema of the application.

### Using the routing system to generate an outgoing URL

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