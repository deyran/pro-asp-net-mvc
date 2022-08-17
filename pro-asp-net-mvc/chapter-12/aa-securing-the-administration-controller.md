# SportsStore: Security & Finishing Touches
In this chapter, the following features will be implemented:
1. Authentication requirement to access SportsStore administration (previously implemented in the previous section).
2. Once authentication is ok, support for adding product image will be implemented.

## Securing the Administration Controller
ASP.NET authentication and authorization features are packages that function as general purpose system for keeping track of who is logged in.

### Creating a Basic Security Policy
I am going to start by configuring forms authentication, which is one of the ways in which users can be authenticated in an ASP.NET application. In Listing 12-1, you can see the additions I have made to the Web.config file in the SportsStore.WebUI project (the one in the root of the project and not the one in the views folder).



Authentication is set up using the authentication element and I have used the mode attribute to specify that I want forms authentication, which is the kind most often used for Internet-facing web applications. In ASP.NET 4.5.1, Microsoft has added support for a wider range of Internet-suitable authentication options, which I describe in the Pro ASP.NET MVC 5 Platform book, as noted earlier in the chapter. I am going to stick with forms authentication because it works with local user credentials and is simple to set up and manage.

The loginUrl attribute tells ASP.NET where to redirect users when they need to authenticate themselves (in this case the ~/Account/Login URL) and the timeout attribute specifies how long a user remains authenticated once they have successfully logged in, expressed in minutes (2,880 minutes is 48 hours).

The next step is to tell ASP.NET where it will get details of the application users. I have broken this into a separate step because I am about to do something that should never, ever, be done in a real project: I am going to define a username and password in the Web.config file. You can see the changes in Listing 12-2.


* Configuring forms authentication is one of the ways users can be authenticated in an ASP.NET application. Open the Web.config file to match with the Lising 12-1 (SportsStore.WebUI project).
    <p align="center">
        <img src="ch12-Pictures/Listing 12-1.png" /><br />
        <b>Listing 12-1.</b> Configuring Forms Authentication in the Web.config File
    </p>

* AAAAAAAAAA
    <p align="center">
        <img src="ch12-Pictures/Listing 12-2.png" /><br />
        <b>Listing 12-2.</b> Defining a Username and Password in the Web.config File
    </p>


Listing 12-2. Defining a Username and Password in the Web.config File

### Applying Authorization with Filters
### Creating the Authentication Provider
### Creating the Account Controller
### Creating the View

chapter 12 - SportsStore: Security & Finishing Touches
    Securing the Administration Controller
        Creating a Basic Security Policy 306
            Listing 12-1. Configuring Forms Authentication in the Web.config File