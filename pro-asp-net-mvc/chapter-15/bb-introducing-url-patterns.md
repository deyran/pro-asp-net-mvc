<h1 align="center">
    Chapter 15: URL Routing
</h1>

## Introducing URL Patterns
Routing System works with a set of routes, also known as URL scheme, which comprises the URLs that the application will recognize and respond to.

No need to type out all of the individual application URLs. Instead, each route contains a *URL pattern*, which is compared to incoming Urls. If a URL matches the pattern, the *routing systems* process that URL. 

Let's see the example below:
```js
http://mysite.com/Admin/Index
```

P3====================
* URLs can be broken down into segments. 
* These are the parts of the URL, excluding the hostname and query string, that are separated by the / character. 
* In the example URL, are two segments, as showni in Figure 15-3.
Figure 15-3. The segments in an example URL

P4====================
* The first segment contains the word Admin, and the second segment contains the word Index.
* To the human eye, it is obvious that the first segment relates to the controller and the second segment relates to the action.
* But, of course, I need to express this relationship in a way that the routing systems can understand.
* Here is a URL pattern that does this:
{controller}/{action}

P5====================
* When processing an incoming request, the job of the routing system is to match the URL that has been requested to a pattern and extract values from URL for the segment variable defined in the pattern.
* The segment variables are expressed using braces (the {and} characters).
* The example pattern has two segment variables with the names controller and action, and so the value of the controller segment variable will be Admin and the value of the action segment variable will be Index.

P6====================
* I say match to a pattern, because an MVC application will usually have several routes and the routing system will compare the incoming URL to the URL, pattern of each route until it finds a match

P7====================
* By default, a URL pattern will match any URL that has the correct number of segments.
* For example, the pattern {controller}/{action} will match any URL that has two segments, as illustrated by Table 15-2.
    Table 15-2. Matching URLs

P8====================
Table 15-2 highlights two key behaviors of URL patterns:
1. URL patterns are conservative, and will match only URLs have the same number of segments as the patterns. You can see this in the fourth and fifth examples in the table.
2. URL pattern are liberal. If a URL does URL have the correct number of segments, the pattern will extract the value of the segment variable, whatever it might be.

P9====================
1. These are the default behaviors, which are the keys to understanding how URL patterns function
2. I show you how to change the defaults later in this chapter

P10===================
1. As already mentioned, the rounting system does not know anything about an MVC application, and so URL patterns will match even when there is no controller or action that corresponds to the values extracted from a URL.
2. You can see this demonstrated in the second example in table 15.2. 
3. I transposed the Admin and Index segments in the URL, and so the values extracted from the URL have also been transposed, even though there is no Index controller in the example project.

<!--
# Chapter 15: URL Routing
    ## Introducing URL Patterns
        ### paragraph 3
       
> SUMMARRY AND UPDATE ==========================

> CONTENTS =====================================
# Chapter 15: URL Routing
## Introducing URL Patterns 

> GITHUB =====================================
https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/bb-introducing-url-patterns.md

> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->