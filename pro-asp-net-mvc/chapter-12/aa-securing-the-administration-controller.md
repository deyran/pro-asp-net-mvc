# SportsStore: Security & Finishing Touches
In this chapter, the following features will be implemented:
1. Authentication requirement to access SportsStore administration (previously implemented in the previous section).
2. Once authentication is ok, support for adding product image will be implemented.

## Securing the Administration Controller
ASP.NET authentication and authorization features are packages that function as general purpose system for keeping track of who is logged in.

### Creating a Basic Security Policy
1. Let's start by configuring *forms authentication* (often used for Internet-facing web applications) to provide credentials to local users  to access the application and it is simple and easy to manage. In the *SportsStore.WebUI* project open the *Web.config* file and edit it to match with the Listing 12-1
    <p align="center">
        <img src="ch12-Pictures/Listing 12-1.png" /><br />
        <b>Listing 12-1.</b> Configuring Forms Authentication in the Web.config File
    </p>

2. The next step is to define a username and password in the Web.config file. The purpose of this step is to keep the example simple, in a real project we never set the credentials in the Web.config file. You can see the changes in Listing 12-2.
    <p align="center">
        <img src="ch12-Pictures/Listing 12-2.png" /><br />
        <b>Listing 12-2.</b> Defining a Username and Password in the Web.config File
    </p>

### Applying Authorization with Filters
1. The MVC Framework has a feature called filters. These filters are .NET attributes that are applied to the action method or a controller class, adding logic in the time the request is processed, changing the MVC Framework behavior (see chapter 18 for more details). The filter that will be used he is *Authorize*, you can see in Listing 12-3.
    <p align="center">
        <img src="ch12-Pictures/Listing 12-3.png" /><br />
        <b>Listing 12-3.</b> Adding the Authorize Attribute in the AdminController.cs File
    </p>

    * if you are authenticated, you are automatically authorized to use the administration features
    * In Listing 12-3, I applied the Authorize filter to the class, so all of the action methods in the Admin controller are available only to authenticated users.  

2. You can see the effect that the Authorize filter has by running the application and navigating to the */Admin/Index* URL. You will see an error similar to the one shown in Figure 12-1.
    <p align="center">
        <img src="ch12-Pictures/Figure 12-1.png" /><br />
        <b>Figure 12-1.</b> The effect of the Authorize filter
    </p>    

    * When you try to access the Index action method of the Admin controller, the MVC Framework detects the Authorize filter. 
    * Because you have not been authenticated, you are redirected to the URL specified in the Web.config forms authentication section: /Account/Login (not created yet, the reason for the error). 

### Creating the Authentication Provider
Using the forms authentication feature requires calls to two static methods of the System.Web.Security. FormsAuthentication class:
    The • Authenticate method validates credentials supplied by the user.
    The • SetAuthCookie method adds a cookie to the response to the browser, so that users do not need to authenticate every time they make a request.

The problem with calling static methods from within action methods is that it makes unit testing the controller difficult: mocking frameworks typically mock only instance members. The classes that comprise the MVC Framework have been designed with unit testing in mind, but the FormsAuthentication class predates the unit testing-friendly design of MVC.


The best way to address the problem is to decouple the controller from the static methods using an interface, which offers the additional benefit that this fits in with the broader MVC design pattern and makes it easier to switch to a different authentication system later.


I start by defining the authentication provider interface. Create a new folder called Abstract in the Infrastructure folder of the SportsStore.WebUI project and add a new interface called IAuthProvider. The contents of this interface are shown in Listing 12-4.


Listing 12-4. The Contents of the IAuthProvider.cs File

### Creating the Account Controller
### Creating the View

chapter 12 - SportsStore: Security & Finishing Touches
    Securing the Administration Controller
        Creating the Authentication Provider