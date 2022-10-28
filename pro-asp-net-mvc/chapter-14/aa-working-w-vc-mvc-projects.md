<h1 align="center">
    Chapter 14: Overview of MVC Projects
</h1>

The purpose of this chapter is to present an overview of the MVC Framework features, following these items:
1. Structure and nature of an ASP.NET MVC application.
2. Default projects structure and naming conventions
3. some of which are optional and some of which are hard-coded into the way that the MVC Framework operates.  

# Working with Visual Studio MVC Projects
Visual Studio IDE has a set of tools and libraries that are used to build applications with basic initial functionality, settings and directory and file structures. These tools and libraries, as known as *frameworks*, avoid repetitive tasks and optimize work by allowing the developer focus on the project at a high level of project features. This support continues with templates used to create controllers and views (in MVC projects for web applications) that are created with template code for listing data objects, editing model properties and so on.

The author advice of this book is to avoid the templates and scaffolding and start with an empty project and add the folders, files and packages that you need. By doing so, you will learn more about how the Framework works, and you will have full control over your application contains

## Creating the Project
When we create a new *MVC Framework* project, a dialog box is used to guide the user through a set of options. The purpose of this dialog box, is to provide a Basic assemblies and folders needed by the *MVC Framework* project.  

The first dialog box when creating a new *MVC Framework* project is *Create a new project* dialog. As you can see in the Figure 14-0, the recently selected templates are shown on the left, but you can still use a filter to search all available projects.
<p align="center">
    <img src="ch14-Pictures/Figure 14-0.png" /><br />
    <b>Figure 14-0.</b> Create a new project dialog
</p>  

When you first create a new MVC Framework project, you have two basic starting points to choose from: the **Empty template** and the **MVC template**. On the right can be seen *Add folders & Core reference* which is used to add the basic folders and assemblies needed for the project (Figure 14-1). When you choose *Empty template* it is necessary check *MVC* option for the MVC Framework project purpose, but when the *MVC template* is chosen the *MVC* option is checked automatically.
<p align="center">
    <img src="ch14-Pictures/Figure 14-1.png" /><br />
    <b>Figure 14-1.</b> Selecting the project type, folders and assemblies for a new project
</p>  

In this section two projects are created, they are called *MyEmptyApplication* and *MyMvcApplication* respectively. The *MyEmptyApplication* project use *Empty template* and the *MVC* option (*Add folders & Core reference*) is checked, this project contains basic references and the minimum folder structure for an MVC framework. *MyMvcApplication* project uses *MVC template*, this type of template comes with additional content like: some default controllers and views, some popular JavaScript and CSS packages (such as jQuery and Bootstrap) and a layout that uses Bootstrap to provide a theme for the application content. The differences between *MyEmptyApplication* and *MyMvcApplication* projects can be seen in Figure 14-2.
<p align="center">
    <img src="ch14-Pictures/Figure 14-2.png" /><br />
    <b>Figure 14-2.</b> The default content added to a project by the Empty and MVC templates
</p>  

After seeing differences between *MyEmptyApplication* and *MyMvcApplication* projects, you can see similar *core file* and *folder structures*, *special roles* (hard-coded into ASP.NET or the MVC Framework) and *naming conventions* are applied to these MVC items. In Table 14-1 describes each of the core files and folders.

<p align="center">
    <b>Table 14-1.</b> Summary of MVC Project Items
</p>  

Folder_or_File|Description|Notes
---------|--------|--------
/App_Data|The *App_Data* folder contains the physical store for data (LocalDB, .mdf files, XML files, and other data related files)|IIS will never serve files from App_Data folder
/App_Start|The *App_Start* folder contains classes files (AuthConfig.cs, BundleConfig.cs, FilterConfig.cs, RouteConfig.cs, etc.) that will be executed when the application starts.|All these classes files will be seen in other chapters like 15, 16, 18 and 26
/Areas|The *Areas* folder allows you to apply the principle known as *separation of concerns*, separating the application into smaller pieces. Models, views and controllers are separated into functinal sections of the application, which is useful in a large web application and multiple developers working on the same web application.|The *Areas* folder will be seen in chapter 15
/Bin|The compiled assembly for MVC application is placed in the *Bin* folder|These are binary files generated on compilation, so not available in *Solution Explorer*
/Content|In contains static files like CSS files, images and icon files.|This is a convention but not required. The static file can be placed anywhere
/Controllers|This is where the controller classes are placed|This is a convention. Controller classes can be placed anywhere as they are all compiled into the same assembly.
/Models|In the *Models* folder are placed the *View model* and *Domain model* classes that handle database tasks.|The *Models* folder is a convention. Classes that handle database tasks can be placed in another project as shown in the SportsStore solution.
/Scripts|This directory is the recommended location for script files for the web application. Files like JavaScript, AJAX foundationm, JQuery, TypeScript, etc are placed in the *Scripts* folder.|The *Scripts* folder will be seen in chapter 26
/Views|This directory holds *views* and *partial views*, usually grouped together in folders named after the controller with which they are associated.|*/Views/web.config* file ensure that views are only rendered via action method.
/Views/Shared|This directory holds layouts and views which are not specific to a single controller.|-
/Global.asax|This is the global ASP.NET application class, which is the place to configure or code routing configuration, application lifecycle, unhandled exceptions, etc.|-
/Web.config|This is the configuration file for your application.|-

## Understanding MVC Conventions
There are two kinds of conventions in an MVC project: *Web Application MVC Project Structure* [[1]](https://learn.microsoft.com/en-us/previous-versions/aspnet/dd410120(v=vs.100)) and *Convention over Configuration*.  

The *Web Application MVC Project Structure* convention is not an obligation but a suggestion. As seen in Table 14-1, each file goes to a specific place, for example, JavaScript file goes to Scripts folder. It is free to place JavaScript files in anywhere, but *Scripts* is the place other MVC developers would expect to find them, and where *NuGet packages* will install them.  

The other kind of convention is the *Convention over Configuration - [CoC](https://devopedia.org/convention-over-configuration)*. That means just following a *naming convention* for the files (controllers and views for example), and everything will work. The following sections explain the conventions that are used in place of configuration.

===========================================================
1. https://devopedia.org/convention-over-configuration


2. https://www.devmedia.com.br/introducao-ao-asp-net-mvc/31878
This concepts means developers does not need create associations between controllers and views, using *CoC* the MVC framework will make these associations automatically.

Vamos realizar a criação de um controller em nossa aplicação exemplo. Ele estará no diretório “Controllers”, de forma apropriada. Note, na Figura 3, que o Visual Studio novamente oferece uma série de templates para o controller. A ideia é que algumas utilizações comuns dos mesmos sejam utilizados com maior facilidade. Entretanto, estaremos criando um controller vazio nesse momento.

<!--
Chapter 14: Overview of MVC Projects
    # Working with Visual Studio MVC Projects
        ## Understanding MVC Conventions
            ### Following Conventions for Views
-->

===========================================================


### Following Conventions for Controller Classes
Every Controller class must have names that end with a *Controller* suffix, like the *ProductController* class, for example. As can be seen, the controller class name is formed by a prefix name, which is freely chosen, plus the suffix *"Controller"*. This convention, known as the *convention over configuration*, allows the MVC Framework automatically appends *Controller* to the name and starts looking for the controller class.

### Following Conventions for Views
Views and partial views associated with the **prefixName***Controller* class, can be found in the /Views/**prefixName** folder. In this convention, each action method of a controller class will correspond or not to a view or partial view, for example, if the **prefixName***Controller* class has a method called *list*, it view or partial view will correspond to /View/**prefixName**/List.cshtml file.




******************
The MVC Framework expects that the default view for an action method should be named after that method. 
    >> The MVC Framework > View > action method > named after that method  

************************************************************************
For example, the default view associated with an action method called List should be called List.cshtml. 
    >> For example > default view > action method > List > List.cshtml

Thus, for the List action method in the ProductController class, the default view is expected to be /Views/Product/List.cshtml.  
    >> List action method > ProductController class > /View/Product/List.cshtml

************************************************************************
The default view is used when you return the result of calling the View method in an action method, like this:
...
return View();
...
You can specify a different view by name, like this:
...
return View("MyOtherView");
...
Notice that I do not include the file name extension or the path to the view. When looking for a view, the MVC Framework looks in the folder named after the controller and then in the /Views/Shared folder. This means that I can put views that will be used by more than one controller in the /Views/Shared folder and the framework will find them.

### Following Conventions for Layouts