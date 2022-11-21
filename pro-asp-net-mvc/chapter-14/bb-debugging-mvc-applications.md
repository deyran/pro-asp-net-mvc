<h1 align="center">
    Chapter 14: Overview of MVC Projects
</h1>

# Debugging MVC Applications
The purpose of debugging is to identifying a problem, isolate the source of the problem and then fix the problem or determine a way to work around it. [[1]](https://www.techtarget.com/searchsoftwarequality/definition/debugging). In this section, you will see the basics of Visual Studio debugger operations like set up the debugger and perform different debugging activities on your MVC project.

## Preparing the Example Project
* To demonstrate using the debugger create a new *Solution* called *DebuggingDemo*, with *MVC project* using *MVC project template*, configuring *Individual User Accounts authentication* option, which sets up a basic user security system, as shown in Figure 14-3.  

<p align="center">
    <img src="ch14-Pictures/Figure 14-3.png" /><br />
    <b>Figure 14-3.</b> Creating a new project using the MVC project template
</p>  

* Run the application and see the result in Figure 14-4.  

<p align="center">
    <img src="ch14-Pictures/Figure 14-4.png" /><br />
    <b>Figure 14-4.</b> The effect of the additions made by the MVC project template
</p>  

### Creating the Controller
Open the *HomeController.cs* file and replace the content to match Listing 14-1.  

<p align="center">
    <img src="ch14-Pictures/Listing 14-1.png" /><br />
    <b>Listing 14-1.</b> The Contents of the HomeController.cs File
</p>  

### Creating the View
* Open the *View/Home/Index.cshtml* view file and replace the default content to match Listing 14-2.  

<p align="center">
    <img src="ch14-Pictures/Listing 14-2.png" /><br />
    <b>Listing 14-2.</b> The Contents of the Index.cshtml File
</p>  

* For the last change, open the */Content/Site.css* file and change one of the existing ones, as shown in Listing 14-3.  

<p align="center">
    <img src="ch14-Pictures/Listing 14-3.png" /><br />
    <b>Listing 14-3.</b> Adding a Style to the /Content/Site.css File.
</p>  

## Launching the Visual Studio Debugger
To debug an MVC Framework application, follow these two steps:
1. Change de configuration in the *Web.config* file (in the root project folder).
    1. Open the *Web.config*, find the *system.web* element
    2. Set the *debug* attribute to *true*, as shown in Listing 14-4
    <p align="center">
        <img src="ch14-Pictures/Listing 14-4.png" /><br />
        <b>Listing 14-4.</b> The Debug Attribute in the Web.config File
    </p>  

2. Ensure that the *Debug* configuration is selected in the *Visual Studio* toolbar, as shown in Figure 14-5


<!--
Chapter 14: Overview of MVC Projects
    # Debugging MVC Applications
        ## Launching the Visual Studio Debugger 355-356
            Listing 14-4. The Debug Attribute in the Web.config File
-->

## Causing the Visual Studio Debugger to Break
## Using Edit and Continue