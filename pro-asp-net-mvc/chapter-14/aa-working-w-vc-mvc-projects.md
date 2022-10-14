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

After seeing differences between *MyEmptyApplication* and *MyMvcApplication* projects, you can see similar *core file* and *folder structures*, *special roles (hard-coded into ASP.NET or the MVC Framework)* and *naming conventions* are applied to these MVC items. In Table 14-1 describes each of the core files and folders.

AAAAAAAAA|BBBBBBBB|CCCCCCCCCCC
---------|--------|--------
AAAAAAAAA|BBBBBBBB|CCCCCCCCCCC


<!--
Chapter 14: Overview of MVC Projects
    # Working with Visual Studio MVC Projects
        ## Creating the Project
-->

## Understanding MVC Conventions