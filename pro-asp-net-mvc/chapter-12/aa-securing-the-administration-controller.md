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

2. AAAAAAAAAA
    <p align="center">
        <img src="ch12-Pictures/Listing 12-2.png" /><br />
        <b>Listing 12-2.</b> Defining a Username and Password in the Web.config File
    </p>

1. The next step is to tell ASP.NET where it will get details of the application users. 
2. I have broken this into a separate step because I am about to do something that should never, ever, be done in a real project: I am going to define a username and password in the Web.config file. 
3. You can see the changes in Listing 12-2.
--------------------------------------------------------------------

1. I want to keep the example simple and focus on the way that the MVC Framework allows you to apply authentication and authorization to a web application. 
2. But putting credentials in the Web.config file is a recipe for disaster, especially if you set the passwordFormat attribute on the credentials element to Clear, meaning that passwords are stored as plain text.
--------------------------------------------------------------------

Caution ■
Don’t store user credentials in the Web.config file and don’t store passwords as plain text. See the free chapters excepted from my Pro ASP.NET MVC 5 Platform book (as described at the start of the section) for details of managing users via a database.
--------------------------------------------------------------------

1. Despite being unsuitable for real projects, using the Web.config file to store credentials lets me focus on MVC features without getting sidetracked into aspects of the core ASP.NET platform. 
2. The result of the additions to the Web.config file is that I have a hard-coded username (admin) and password (secret).


### Applying Authorization with Filters
### Creating the Authentication Provider
### Creating the Account Controller
### Creating the View

chapter 12 - SportsStore: Security & Finishing Touches
    Securing the Administration Controller
        Creating a Basic Security Policy 306
            Listing 12-2. Defining a Username and Password in the Web.config File