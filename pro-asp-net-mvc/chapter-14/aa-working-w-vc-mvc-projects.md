<h1 align="center">
    Chapter 14: Overview of MVC Projects
</h1>

The purpose of this chapter is to present an overview of the MVC Framework features, following these items:
1. Structure and nature of an ASP.NET MVC application.
2. Default projects structure and naming conventions
3. some of which are optional and some of which are hard-coded into the way that the MVC Framework operates.  

# Working with Visual Studio MVC Projects
To create a new ASP.NET project, it is necessary a set of choices to configure the initil contents for the project. As a result, the project starts with basic code and structure. The ideas behind this approach are: 1 - Learning process for beginners; 2 - A time-saving best practices for common features and tasks.

With Visual Studio and MVC, Microsoft has updated the *templates* and *scaffolding*, as it is known, to blur the boundaries between different kinds of ASP.NET project and to provide a wider range of project templates and code configurations.  

An advice is to start with an empty project and add the folders, files, and packages that you need. Not only will you learn more about the way that the MVC Framework works, but you will have complete control over what your application contains.

## Creating the Project

When you first create a new MVC Framework project, you have two basic starting points to choose from: the Empty template and the MVC templamete.

The names are a little misleading, because you can add basic folders and assemblies required for the MVC Framework to any project template by checking the MVC option in the Add Folders and Core References section of the New ASP.NET Project dialog windown, as shown in Figure 14-1.

For the MVC option, this option is checked for you.

+++++++++++++++++++++++++++++++++++++++++++


The real difference is the additional content that the MVC project template adds to new projects, which provides a ready-made starting point that includes some default controllers and views, a security configuration, some popular JavaScript and CSS packages (such as jQuery and Bootstrap) and a layout that uses Bootstrap to provide a theme for the application content. The Empty project option just contains the basic references required for an MVC framework and the barebones folder structure. There is a fair amount of content added by the MVC template and you can see the differences in Figure 14-2, which shows the contents of two newly created projects. The one on the left was created with the Empty template with the MVC folders and references option checked. The others show the content of a project that was created with the MVC template, and to be able to show the files on the page, I had to focus the Solution Explorer on different folders because a single listing was too long for a printed page

<!--
Chapter 14: Overview of MVC Projects
# Working with Visual Studio MVC Projects
## Creating the Project
-->

## Understanding MVC Conventions