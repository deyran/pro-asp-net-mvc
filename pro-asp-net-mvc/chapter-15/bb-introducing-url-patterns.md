<h1 align="center">
    Chapter 15: URL Routing
</h1>

## Introducing URL Patterns
P1====================
* The routing system works its magic using a set of routes. 
* These routes collectively comprise the URL schema or scheme for an application, which is the set of URLs that your application will recognize and respond to.

P2====================
* I do not need to manually type out all of the individual URLs I am willing to support in my applications. 
* Instead, each route contais a URL pattern, which is compared to incoming Urls. 
* if a URL matches the pattern, then it is used by the routing system to process that URL, Let's stat with a URL for the example application:

http://mysite.com/Admin/Index

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
P9====================
P10===================

<!--
# Chapter 15: URL Routing
    ## Introducing URL Patterns
       
> SUMMARRY AND UPDATE ==========================

> CONTENTS =====================================
# Chapter 15: URL Routing
## Introducing URL Patterns 

> GITHUB =====================================
https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/bb-introducing-url-patterns.md

> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->