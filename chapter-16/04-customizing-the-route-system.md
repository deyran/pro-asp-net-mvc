# Chapter 16: Advanced routing features

## Customizing the route system

So far, it has been shown how flexible and configurable the routing system is. But it can be even more, it is possible to customize the behavior of the routing system. This technique will be shown in the next two sections

### Creating a custom RouteBase implemetation

--
To take control how URLs are matched, parameters are extracted and output URLs are generated, changing the default behavior of the route object , the RouteBase class can be used.

change the default route object, i.e. how URLs are matched, parameters are extracted and output URLs are generated, the **RouteBase** class can be used. To use the **RouteBase** class you need to implement two methods:
--

1. GetRouteData(HttpContextBase httpContext)
2. GetVirtualPath(RequestContext requestContext, RouteValueDictinary values)

To demonstrate this customization, a **Roubase** class will be created to support **legacy URL** (old URLs like: bookmarked, hard-coded and etc). To start, create a controller called **LegacyController** to receive the legacy requests, as shown in Listing 16-16.

<p align="center">
    <img src="ch16-Pictures/Listing 16-16.png" /><br />
    <b>Listing 16-16.</b> The content of the LegacyController.cs file
</p>

### Creating a custom route handler

<!--
# Chapter 16: Advanced routing features
## Customizing the route system
### Creating a custom routeBase implemetation
#### Listing 16-16. The content of the LegacyController.cs file
--------------------------------------------------

# Chapter 16: Advanced routing features
## Customizing the route system
### Creating a custom routeBase implemetation
### Creating a custom route handler
-->