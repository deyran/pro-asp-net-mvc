<h1 align="center">
    Chapter 15: URL Routing
</h1>

## Introduction
Before MVC Framework, there was a direct relationship between request *URLs* and the file on the server disk. The server receives the request and delivers the output from the corresponding file. In the MVC Application, all the requests are handled by action methods in controller classes, without using correlation with files on disk.  

To handle MVC URLs, the ASP.NET platform uses the *routing system* (will be seen in this chapter). The *route system* has three functions:
1. Examine and process incoming URL 
2. Deliver the processed URL to the appropriate controller and its action methods
3. Generate outgoing URLs.  

<!--
# Chapter 15: URL Routing
    ## Introduction
-->
# P4------------------------------------------------------------
* In this chapter, I will focus on defining routes and using them to process incoming URLs so that user can reach your controllers and actions.
    Defining routes | Using routes to process incoming URLs | reach controller and actions

* There are two ways to create routes in a MVC Framework application: convention-based routing and attribute routing.

* You will be familiar with convention-based routing if you have used earlier versions of the MVC Framework, but attribute routing is new to MVC 5.
* I explain both approaches in this chapter.

# P5------------------------------------------------------------
Then, in the next chapter, I will show you how to use those same routes to generate the outgoing URLs you will need to include in your views, as well as show you how to customize the routing system and use a related feature called areas.