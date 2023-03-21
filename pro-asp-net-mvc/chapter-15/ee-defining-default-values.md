# Chapter 15: URL Routing

## Defining default values

In the previous section, when trying to run the application, it failed. This happens because the *default URL* (expressed as **~/** to the routing system) does not match the route defined by the *URL Pattern* {controller}/{action}.

The *URL pattern* will only match URLs with number of segments, this is the default behavior. Using the default values is the way to change this behavior when the URL doesn't contain segments matching to the value. Listing 15-9 provides an example of a route that contains a default value.

<p align="center">
    <img src="ch15-Pictures/Listing 15-9.png" /><br />
    <b>Listing 15-9.</b> Providing a default value in the RouteConfig.cs file
</p>

In Listing 15-9, the **new { action = "Index"}** instruction was given as the *default value*. So the action variable is provided with *Index* value and the route matches with the *URL pattern*.

For example, if the URL **ht<span>tp://</span>mydomain.com/Home/Index** is requested, the route will extract *Home* as the value for the *controller* and *Index* as the value for the action. Likewise, the URL **ht<span>tp://</span>mydomain.com/Home** route will extract *Home* as the *controller* value and insert *Index* into the *action* variable using the *default value* *Index*.

<p align="center">
    <img src="ch15-Pictures/Listing 15-9.png" /><br />
    <b>Listing 15-10.</b> Providing action and controller default values in the RouteConfig.cs file
</p>

By providing default values for both the controller and action variables, a route has been created that will match URLs that have zero, one, or two segments, as showm in Table 15-3.

Table 15-3. Matching URLs
Number of segments|Example|Maps To
---------|--------|--------
0|mydomain.com|controller=Home - action=Index
1|mydomain.com/Customer|controller=Customer - action=Index
2|mydomain.com/Customer/List|controller=Customer - action=List
3|mydomain.com/Customer/List/All|No match - too many segments

Run the application and see the effect of using default values as shown in Figure 15-5.

<p align="center">
    <img src="ch15-Pictures/Figure 15-5.png" /><br />
    <b>Figure 15-5.</b> Using default values to broaden the scope of a route
</p>

<!--
> SUMMARRY AND UPDATE ==========================
.
> CONTENTS =====================================
# Chapter 15: URL Routing
## Defining default values
.
> GITHUB =====================================
https://github.com/deyran/asp-dot-net-training/blob/main/pro-asp-net-mvc/chapter-15/ee-defining-default-values.md
.
> # ==========================================
#DotNet #csharp #csharpdotnet #dotnetcore #csharpdeveloper #dotnetdevelopers #aspnetcore #ASPNET #aspdotnet #IT #developer #TI #tecnologia #DevOps #desenvolvedor #programador #software #homeoffice #dev #tecnologiadainformacao #devs #code #programacao #programação #tecnologiadainformação #sistemasdeinformação #engenhariadesoftware #GitHub #ASPNETMVC #ASPNET #MVC #core #MVC #route #urlroute #urlroting #urlpatterns #RoutingSystem
-->