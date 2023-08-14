# Chapter 16: Advanced routing features

## Customizing the route system

So far, it has been shown how flexible and configurable the routing system is. But it can be even more, it is possible to customize the behavior of the routing system. This technique will be shown in the next two sections

### Creating a custom routeBase implemetation

To change the default route object, i.e. how URLs are matched, parameters are extracted and output URLs are generated, the RouteBase class can be used. To derive a class from RouteBase, you need to implement two methods:

1. GetRouteData(HttpContextBase httpContext)
2. GetVirtualPath(RequestContext requestContext, RouteValueDictinary values)

### Creating a custom route handler

<!--
# Chapter 16: Advanced routing features
## Customizing the route system
### Creating a custom routeBase implemetation
--------------------------------------------------

# Chapter 16: Advanced routing features
## Customizing the route system
### Creating a custom routeBase implemetation
### Creating a custom route handler
-->