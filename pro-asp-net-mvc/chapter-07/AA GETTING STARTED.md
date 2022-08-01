<h1 align="center">
    CHAPTER 07 - SPORTSSTORE - A REAL APPLICATION
</h1>

## GETTING STARTED
To start this journey, it's necessary to create a *Visual Studio Solution* that contains three projects: 
1. Domain Model [[ch0701]](Issues/ch0701-domain-model.md)
2. MVC Application
3. Unit Tests  

*Tip:* Solution is a container to organize one or more related code projects [[1]](https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-projects-solutions?view=vs-2022)  

### CREATING THE VISUAL STUDIO SOLUTION AND PROJECTS
* To create a *Visual Studio Solution* and the *SportsStore.Domain* project, follow these steps:
    1. Open Visual Studio, and on the start window, select *Create a new project* (Figure 7-A).
        <p align="center">
            <img src="ch07-Pictures/Figure 7-A.png" /><br />
            <b>Figure 7-A.</b> Create a new project
        </p>  
    2. Set the fields as shown in *Figure 7-B*, select *Console App (.NET Framework)* and click the *Next* button
        <p align="center">
            <img src="ch07-Pictures/Figure 7-B.png" /><br />
            <b>Figure 7-B.</b> Console App (.NET Framework)
        </p>  
    3. On the screen *Configure your new project*, in the field *Project name* type *SportsStore.Domain* to create the *Domain Model project*. In the field *Location*, set the directory of your choice. In the *Solution name* field, set SportsStore and click the *Create* button, as shown in the Figure 7-1.
        <p align="center">
            <img src="ch07-Pictures/Figure 7-1.png" /><br />
            <b>Figure 7-1.</b> Creating the Solution container and SportsStore.Domain project
        </p>  

* A Visual Studio solution is a container for one or more projects. For this web application three projects are needed, these projects are described in Table 7-1:

**Project Name**|**Template**|**Purpose**
----------------|------------|------------
SportsStore.Domain|Class Library|Domain Entities and logic, persistence, repository and etc
SportsStore.WebUI|ASP.NET MVC Web Application|Holds the controllers and views; acts as the UI for the SportsStore application
SportsStore.UnitTests|Unit test project|holds the unit tests for the other two projects    

* To create MVC application -> SportsStore.WebUI, follows these steps:
    1. Right-click in *Solution Explorer* window
    2. Choose -> Add and New Project
    3. On the screen called *Add a new project*, type *MVC*, select ASP.*NET Web Application (.Net Framewok)* option and click *Next*, as shown in the picture below:
        <p align="center">
            <img src="ch07-Pictures/Figure 7-C.png" /><br />
            <b>Figure 7-C.</b> Creating *SportsStore.WebUI* project
        </p>  

### INSTALLING THE TOOL PACKAGES
### ADDING REFERENCES BETWEEN PROJECTS
### SETTING UP THE DI CONTAINER
### RUNNING THE APPLICATION

CHAPTER 07 - SPORTSSTORE - A REAL APPLICATION
    GETTING STARTED
        CREATING THE VISUAL STUDIO SOLUTION AND PROJECTS 156
            Creating *SportsStore.WebUI* project
            
