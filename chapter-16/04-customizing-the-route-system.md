# Chapter 16: Advanced routing features

## Customizing the route system

So far, it has been shown how flexible and configurable the routing system is. But it can be even more, it is possible to customize the behavior of the routing system. This technique will be shown in the next two sections

### Creating a custom routeBase implemetation

If you do not like the way that standard Route objects match URLs, 

	STANDARD ROUTE OBJECTS MATCH URLS


or want to implement something unusual, 
		

you can derive an alternative class from RouteBase. 


This gives you control over how URLs are matched, how parameters are extracted, and how outgoing URLs are generated. 

To derive a class from RouteBase, 
you need to implement
two methods:

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