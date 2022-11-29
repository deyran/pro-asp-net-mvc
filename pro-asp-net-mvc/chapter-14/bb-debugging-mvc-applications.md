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
* To debug an MVC Framework application, follow these three steps:
    1. Change de configuration in the *Web.config* file (in the root project folder).
        1. Open the *Web.config*, find the *system.web* element
        2. Set the *debug* attribute to *true*, as shown in Listing 14-4
        <p align="center">
            <img src="ch14-Pictures/Listing 14-4.png" /><br />
            <b>Listing 14-4.</b> The Debug Attribute in the Web.config File
        </p>  

    2. Ensure that the *Debug* configuration is selected in the *Visual Studio* toolbar, as shown in Figure 14-5.
    <p align="center">
        <img src="ch14-Pictures/Figure 14-5.png" /><br />
        <b>Figure 14-5.</b> Selecting the Debug configuration
    </p>

    3. Click the green arrow on the *Visual Studio* toolbar, as shown in Figure 14-5. If the *debug* attribute (in the *Web.config* file) has not been the set to *true*, the *Visual Studio* will display the dialog shown in Figure 14-6. Select the *Modify the Web.config file to enable debugging* and click the *OK* button and the debugger will start.
    <p align="center">
        <img src="ch14-Pictures/Figure 14-6.png" /><br />
        <b>Figure 14-6.</b> The dialog that Visual Studio displays when the Web.config File disables debugging
    </p>  

* At this point, your application will be displayed in a new browser window, as shown in Figure 14-7.  
    <p align="center">
        <img src="ch14-Pictures/Figure 14-7.png" /><br />
        <b>Figure 14-7.</b> Running the debugger
    </p>  

* You won't notice any difference until the debugger breaks, but that will be coverd in the next section.

## Causing the Visual Studio Debugger to Break
An application with the *degugger* attached will run normally until a *break* accurs. When an application running is stopped, control is handed over to the *debugger* for the developer to inspect and control the state of the application. This *breaks* accurs for two reasons: when a *breakpoint* is reached and when an unhandled exception arises. You will see examples of both in the following sections. 

### Using Breakpoints 
A breakpoint is a debugging technique available for developers break execution to inspect the state of the application, see what is happening, and resume execution again.  

To demonstrate the use of the *breakpoint* debugging technique, open the *DebuggingDemo* project, *HomeController.cs* file and follow these steps:
1. To create a breakpoint, right-click a code statement and select Breakpoint ➤ Insert Breakpoint from the pop-up menu as shown in Figure 14-8A. 
    <p align="center">
        <img src="ch14-Pictures/Figure 14-8A.png" /><br />
        <b>Figure 14-8A.</b> Creating a Breakpoint
    </p>

2. After these steps you you will see a red dot appear in the margin of the text editor, as shown in Figure 14-8.
    <p align="center">
        <img src="ch14-Pictures/Figure 14-8.png" /><br />
        <b>Figure 14-8.</b> Applying a breakpoint to the first statement in the Index action method
    </p>

3. Select *Start Debugging*, click the green arrow to start the debugger

4. When the application reaches the statement where the *breakpoint* was applied, the debugger will stop the application's execution and transfers the control to the developer, besides that, the *Visual Studio* provides a lot of useful information about the state of the application. At this point, *Visual Studio* highlights the point where the execution stopped with yellow highlights, as shown in Figure 14-9. 
    <p align="center">
        <img src="ch14-Pictures/Figure 14-9.png" /><br />
        <b>Figure 14-9.</b> Hitting a breakpointmethod
    </p>

### Viewing Data Values in the Code Editor
The most important feature of *Breakpoint* technique is the ability to view and monitor the values of variable in the code editor, it is makes track down bugs easily in source code.  

To demonstrate this feature follow these steps:
1. Start the application seen in the last section using the debugger until it hits the breakpoints.  
2. Move the mouse pointer over the *result* variable. A small pop-up shows the current value (which is 0), as seen in Figure 14-10.
    <p align="center">
        <img src="ch14-Pictures/Figure 14-10.png" /><br />
        <b>Figure 14-10.</b> Displaying the value of a variable in the Visual Studio code editor
    </p>

<!--
Chapter 14: Overview of MVC Projects
    # Debugging MVC Applications 
        ## Causing the Visual Studio Debugger to Break (357-363)
            ### Viewing Data Values in the Code Editor 358
                Figure 14-10. Displaying the value of a variable in the Visual Studio code editor
-->

Visual Studio shows the default value, which is 0 for the int type.

Press *F10* to step over and advance to the *ViewBag.Message*, hold mouse over to the *result* variable again to see value was assigned to the *result* variable, as shown in Figure 14-11.

Figure 14-11. The effect of assigning a value of a variable
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

There is a push icon to the right of the value in the popup

when clicked, popup becomes permanent and shows variable changes
++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


### Viewing Application State in the Debugger Windows
### Breaking on Exceptions
### Using Edit and Continue

## Using Edit and Continue