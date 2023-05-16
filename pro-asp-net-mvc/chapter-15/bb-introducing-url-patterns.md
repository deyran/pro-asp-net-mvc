# Chapter 15: URL Routing

## Introducing URL Patterns
Routing System (**Routing engine**) works with **URL Scheme** (a set of routes), which comprises the URLs that the application will recognize and respond to.

The Routing System works as follows:
1. An incoming request is received by the application
2. The Routing System examines the URL of the request to determine which controller and action should handle the request
3. The Routing System uses the URL Pattern to match the incoming request URL with a specific controller action
4. If no match is found, the Routing System will return an HTTP 404 error

    *This approach avoids typing all the individual URLs to support the application.*

Let's start with an example: **http<nolink>://mysite.com/Admin/Index?query=bing**. Excluding the hostname **(http<nolink>://mysite.com/)** and query string **(?query=bing)**, *URLs* can be split into two segments **(Admin/Index)** as shown in Figure 15-3.
    
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
> SUMMARRY AND UPDATE ==========================
.
> CONTENTS =====================================
# Chapter 15: URL Routing
## Introducing URL Patterns 
.
> GITHUB =====================================
https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/bb-introducing-url-patterns.md
.
> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->
