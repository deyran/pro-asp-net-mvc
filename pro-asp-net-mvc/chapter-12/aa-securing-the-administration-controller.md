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
In this section, for authentication purpose, a class called *FormsAuthentication* from *System.Web.Security* package will be used with its static methods, *Authenticate* (to validate credentials) and *SetAuthCookie* (a cookie to maintain the authetication in the *Response* return).  
But there is a problem to use static method inside action methods, it is very difficult to implement Mock in *Unit test*, since mocking frameworks typically mock only instance members. To address that problem, the interface approach will be used, so the controller will be decouple from the static methods.


1. I start by defining the authentication provider interface. Create a new folder called Abstract in the Infrastructure folder of the SportsStore.WebUI project and add a new interface called IAuthProvider. 

2. The contents of this interface are shown in Listing 12-4.


Listing 12-4. The Contents of the IAuthProvider.cs File

### Creating the Account Controller
### Creating the View

chapter 12 - SportsStore: Security & Finishing Touches
    Securing the Administration Controller
        Creating the Authentication Provider