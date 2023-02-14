<h1 align="center">
    Chapter 15: URL Routing
</h1>

Before MVC Framework, there was a direct relationship between request URLs and the file on the server disk. The server receives the request and delivers the output from the corresponding file.
In the MVC Application, all the requests are handled by action methods in controller classes, without using correlation with files on disk.
    
<!--
# P1------------------------------------------------------------
* Before the introduction of the MVC Framework, ASP.NET assumed that there was a direct relationship between request URLs and the files on the server hard disk.
* The job of the server was to receive the request from the browser and deliver the output from the corresponding file.  

# P2------------------------------------------------------------
* This approach works just fine for Web Forms, where each ASPX page is both a file and a self-contained response to a request. 
* It doesn't make sense for an MVC application, where requests are processed by action methods in controller classes and there is no one-to-one correlation to the files on the disk.
-->


# P3------------------------------------------------------------
* To handle MVC URLs, the ASP.NET platform uses the routing system.
* In this chapter, I will show you how to use the routing system to create powerful and flexible URL handling for your projects.
* As you will see, the routing system lets you create any pattern of URLs you desire and express them in a clear and concise manner.
* The routing system has two functions:
	* Examine an incoming URL and figure out for which controller and action the request is intended
    * Generate outgoing URLs. These are the URLs that appear in the HTML rendered from views so that a specific action will be invoked the user clicks the link (at which point, it has become an incoming URL again).  

# P4------------------------------------------------------------
* In this chapter, I will focus on defining routes and using them to process incoming URLs so that user can reach your controllers and actions.
* There are two ways to create routes in a MVC Framework application: convention-based routing and attribute routing.
* You will be familiar with convention-based routing if you have used earlier versions of the MVC Framework, but attribute routing is new to MVC 5.
* I explain both approaches in this chapter.

# P5------------------------------------------------------------
Then, in the next chapter, I will show you how to use those same routes to generate the outgoing URLs you will need to include in your views, as well as show you how to customize the routing system and use a related feature called areas.

<!--
# Chapter 15: URL Routing
-->