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

* Let's start to implement the authentication provider interface.
    1. Create a new folder called *Abstract* in the *Infrastructure* folder of the *SportsStore.WebUI project*.
    2. Add a new interface called IAuthProvider. The contents of this interface are shown in Listing 12-4.
        <p align="center">
            <img src="ch12-Pictures/Listing 12-4.png" /><br />
            <b>Listing 12-4.</b> The Contents of the IAuthProvider.cs File
        </p>  

* Now, it's time to implement *IAuthProvider* interface which acts as wrapper around the static methods of the FormsAuthentication class. 
    1. In the *Infrastructure (SportsStore.WebUI project)* folder, create a new folder called *Concrete*
    2. Create a new class called FormsAuthProvider and place it inside the *Concrete* folder.
    3. Edit the FormsAuthProvider.cs file to match Listing 12-5.
        <p align="center">
            <img src="ch12-Pictures/Listing 12-5.png" /><br />
            <b>Listing 12-5.</b> The Contents of the FormsAuthProvider.cs File
        </p>  

    * As you can see, there is a warning about the FormsAuthentication.Authenticate method has been deprecated, for the moment this deprecated  method will be sufficient to allow authentication using the static details that were added to the Web.config file.  

* The final step is to register the *FormsAuthProvider* in the *AddBindings* method of the *NinjectDependencyResolver* class, as shown in Listing 12-6.
    <p align="center">
        <img src="ch12-Pictures/Listing 12-6.png" /><br />
        <b>Listing 12-6.</b> Registering the Authentication Provider in the NinjectDependencyResolver.cs File
    </p>  

### Creating the Account Controller
* In this section, the *Account controller* that contens *Login* action method (referred to in the *Web.config* file) will be implemented. To start this task, create a view model class called LoginViewModel.cs, place it in the *Models* folder of the *SportsStore.WebUI* project, edit the contents to match Listing 12-7.
    <p align="center">
        <img src="ch12-Pictures/Listing 12-7.png" /><br />
        <b>Listing 12-7.</b> The Contents of the LoginViewModel.cs File
    </p>  

* Finally, create a class called *AccountController.cs* (it will handle authentication) in the *Controllers* folder and edit the file contents to match Listing 12-8.
    <p align="center">
        <img src="ch12-Pictures/Listing 12-8.png" /><br />
        <b>Listing 12-8.</b> The Contents of the AccountController.cs File
    </p>  

### Creating the View
1. To create the view that will ask the users for their credentials, create the Views/Account folder in the SportsStore.WebUI folder. 
2. Right-click on the new folder, select Add ➤ MVC 5 View Page (Razor) from the menu, set the name to Login and click OK to create the Login.cshtml file. 
3. Edit the contents of the new file to match Listing 12-9.


Listing 12-9. The Contents of the Login.cshtml File



chapter 12 - SportsStore: Security & Finishing Touches
    Securing the Administration Controller
        Creating the View 312





This view uses the _AdminLayout.cshtml layout and Bootstrap classes to style the content. There are no new techniques in this view, other than the use of the Html.PasswordFor helper method, which generates an input element whose type attribute is set to password. I describe the complete set of HTML helper methods in Chapter 21. You can see how the view appears by starting the app and navigating to the /Admin/Index URL, as shown in Figure 12-2.


Figure 12-2. The Login view


The Required attributes that I applied to the properties of the view model are enforced using client-side validation. (Remember that the required JavaScript libraries are included in the _AdminLayout.cshtml layout created in the previous chapter.) Users can submit the form only after they have provided both a username and password, and the authentication is performed at the server when I call the FormsAuthentication.Authenticate method.


Caution ■
In general, using client-side data validation is a good idea. It offloads some of the work from your server and gives users immediate feedback about the data they are providing. however, you should not be tempted to perform authentication at the client, as this would typically involve sending valid credentials to the client so they can be used to check the username and password that the user has entered, or at least trusting the client’s report of whether they have successfully authenticated. Authentication must always be done at the server.

When I receive bad credentials, I add an error to the ModelState and re-render the view. This causes a message to be displayed in the validation summary area, which I created by calling the Html.ValidationSummary helper method in the view. This takes care of protecting the SportsStore administration functions. Users will be allowed to access these features only after they have supplied valid credentials and received a cookie, which will be attached to subsequent requests.

### UNIT TEST: AUTHENTICATION

