# SportsStore: Security & Finishing Touches
In this chapter, the following features will be implemented:
1. Authentication requirement to access SportsStore administration (previously implemented in the previous section).
2. Once authentication is ok, support for adding product image will be implemented.

## Securing the Administration Controller
ASP.NET authentication and authorization features are packages that function as general purpose system for keeping track of who is logged in.

### Creating a Basic Security Policy
* Let's start by configuring *forms authentication* (often used for Internet-facing web applications) to provide credentials to local users  to access the application and it is simple and easy to manage. In the *SportsStore.WebUI* project open the *Web.config* file and edit it to match with the Listing 12-1
    <p align="center">
        <img src="ch12-Pictures/Listing 12-1.png" /><br />
        <b>Listing 12-1.</b> Configuring Forms Authentication in the Web.config File
    </p>

The loginUrl attribute tells ASP.NET where to redirect users when they need to authenticate themselves (in this case the ~/Account/Login URL) and the timeout attribute specifies how long a user remains authenticated once they have successfully logged in, expressed in minutes (2,880 minutes is 48 hours).

The next step is to tell ASP.NET where it will get details of the application users. I have broken this into a separate step because I am about to do something that should never, ever, be done in a real project: I am going to define a username and password in the Web.config file. You can see the changes in Listing 12-2.



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