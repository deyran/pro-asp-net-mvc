# Chapter 15: URL Routing

## Introducing URL Patterns
Routing System works with a set of routes, also known as URL scheme, which comprises the URLs that the application will recognize and respond to.

No need to type out all of the individual application URLs. Instead, each route contains a *URL pattern*, which is compared to incoming Urls. If a URL matches the pattern, the *routing systems* process that URL. 

Let's start with a URL for the example application: **http<nolink>://mysite.com/Admin/Index?query=bing**. Excluding the hostname **(http<nolink>://mysite.com/)** and query string **(?query=bing)*, *URLs* can be aplit into two segments **(Admin/Index)** as shown in Figure 15-3.
    
<p align="center">
    <img src="ch15-Pictures/Figure 15-3.png" /><br />
    <b>Figure 15-3.</b> The segments in an example URL
</p>  

* The first segment (**Admin**) is for the *controller*
* The second segment (**Index**) is for the *action*
* *Routing systems* can understand this because of the *URL pattern* syntax definition: **{controller}/{action}**
* The routing system's job is take the incoming request, match the URL to pattern and extracts their values to the segment variable. After theses processes, the *routing system* forwards to a route.
* For example, the pattern **{controller}/{action}** will match any URL that has two segments, as illustrated by Table 15-2.  

Request URL|Segments Variables
---------|--------
http<noLink>://mysite.com/Admin/Index | controller=*Admin* - Action=*Index*
http<noLink>://mysite.com/Index/Admin | controller=*Index* - Action=*Admin*
http<noLink>://mysite.com/Apples/Oranges | controller=*Apples* - Action=*Oranges*
http<noLink>://mysite.com/Admin | *No match* - too few segments
http<noLink>://mysite.com/Admin/Index/Soccer | *No match* - too many segments

Table 15-2. Matching URLs

As shown in Table 15-2, the routing system will work with the incoming request even if there is no controller or action to receive the extrated values.

[<BACK](https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/aa-preparing-the-example-project.md) - [NEXT>](https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/dd-creating-and-registering-a-simple-route.md)

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
