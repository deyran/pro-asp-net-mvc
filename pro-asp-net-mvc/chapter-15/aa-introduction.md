<h1 align="center">
    Chapter 15: URL Routing
</h1>

## Introduction
Before MVC Framework, there was a direct relationship between request *URLs* and the file on the server disk. The server receives the request and delivers the output from the corresponding file. In the MVC Application, all the requests are handled by action methods in controller classes, without using correlation with files on disk.  

To handle MVC URLs, the ASP.NET platform uses the *routing system* (will be seen in this chapter). The *route system* has three functions:
1. Examine and process incoming URL 
2. Deliver the processed URL to the appropriate controller and its action methods
3. Generate outgoing URLs.  

In this chapter, the definition and creation of *URL Routes* will be seen.

<!--
# Chapter 15: URL Routing
    ## Introduction
-->

