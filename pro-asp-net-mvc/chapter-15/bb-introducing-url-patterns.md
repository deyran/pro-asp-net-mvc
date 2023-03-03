<h1 align="center">
    Chapter 15: URL Routing
</h1>

## Introducing URL Patterns
Routing System works with a set of routes, also known as URL scheme, which comprises the URLs that the application will recognize and respond to.

No need to type out all of the individual application URLs. Instead, each route contains a *URL pattern*, which is compared to incoming Urls. If a URL matches the pattern, the *routing systems* process that URL. 

Let's start with a URL for the example application: *http<nolink>://mysite.com/Admin/Index*
* Excluding the *hostname* and *query string*, *URLs* can be broken down into segments
* In the example URL, there are two segments, as shown in Figure 15-3
<p align="center">
    <img src="ch15-Pictures/Figure 15-3.png" /><br />
    <b>Figure 15-3.</b> The segments in an example URL
</p>  

* The first segment (Admin) is for the *controller*
* The second segment (Index) is for the *action*
* *Routing systems* can understand this because of the *URL pattern* syntax definition: {controller}/{action}  
* The routing system's job is take the incoming request, match the URL to pattern and extracts their values to the segment variable. After theses processes, the *routing system* forwards to a route.
* For example, the pattern {controller}/{action} will match any URL that has two segments, as illustrated by Table 15-2.

Request URL|Segments Variables
---------|--------
http<noLink>://mysite.com/Admin/Index | controller=*Admin* - Action=*Index*
http<noLink>://mysite.com/Index/Admin | controller=*Index* - Action=*Admin*
http<noLink>://mysite.com/Apples|Oranges | controller=*Apples* - Action=*Oranges*
http<noLink>://mysite.com/Admin | *No match* - too few segments
http<noLink>://mysite.com/Admin/Index/Soccer | *No match* - too many segments

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
        ### paragraph 6
       
> SUMMARRY AND UPDATE ==========================

> CONTENTS =====================================
# Chapter 15: URL Routing
## Introducing URL Patterns 

> GITHUB =====================================
https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/bb-introducing-url-patterns.md

> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->