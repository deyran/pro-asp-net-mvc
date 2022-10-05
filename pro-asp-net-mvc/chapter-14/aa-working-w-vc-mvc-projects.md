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
When you first create a new MVC Framework project, you have two basic starting points to choose from: the Empty template and the MVC template. 

    >> MVC Framework project > Empty template > MVC template

The names are a little misleading, because you can add the basic folders and assemblies required for the MVC Framework to any project template by checking the MVC option in the Add Folders and Core References section of the New ASP.NET Project dialog window, as shown in Figure 14-1. 

    >> Basic folders and assemblies > MVC Framework
    >> project template > New ASP.NET Project dialog window

For the MVC option, this option is checked for you.


<!--
Chapter 14: Overview of MVC Projects
    # Working with Visual Studio MVC Projects
        ## Creating the Project
-->

## Understanding MVC Conventions