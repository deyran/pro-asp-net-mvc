<ul>
  <li>
    The most important goal of this chapter is to build a simple yet realistic e-commerce application
  </li>
  <li>
    These features will be implemented:
    <ol>
      <li>Online product catalog that customers can brower by category and page</li>
      <li>Users can add and remove product</li>
      <li>Checkout where customers can enter their shipping details</li>
      <li>An administration area (CRUD - create, read, update and delete) - facilities for managing the catalog</li>
      <li>To prevent misuse, only logged in administrators can make changes</li>
    </ol>
  </li>
  <li>In this chapter, the focus is on the MVC Framework, database integration and other things will be simplified</li>
  <li>The topics in this chapter are just an introduction that will be seen on other chapters</li>
</ul>

<h1>GETTING STARTED</h1>

<h2><i>CREATING THE VISUAL STUDIO SOLUTION AND PROJECTS</i></h2>

<ul>
  <li>
    "A solution is simply a container used by Visual Studio to organize one or more projects [...]".<br />
    &nbsp;&nbsp;&nbsp;&nbsp;Font: <a href="https://docs.microsoft.com/en-us/visualstudio/get-started/tutorial-projects-solutions?view=vs-2019">Visual Studio documentation->Solution</a> <br />
    &nbsp;&nbsp;&nbsp;&nbsp;Date: 09-08-21<br /><br />
    A visual studio solution containing three projects will be created:
    <ol>
      <li>
        Domain model -> <i>SportsStore.Domain (Class Library)</i><br />
        <ol>
          <li>Domain entities and Logic</li>
          <li>Persistence</li>
          <li>Entity Framework</li>
        </ol>
      </li>
      <li>
        MVC application -> <i>ASP.NET MVC Web Application</i><br />
        <ol>
          <li>Controllers</li>
          <li>Views</li>
          <li>UI for the SportsStore Application</li>
        </ol>        
      </li>
      <li>
        Unit tests -> <i>SportsStore.UnitTests</i><br />
        &nbsp&nbspHolds the unit tests for the other two projects
      </li>
    </ol>
  </li>
</ul>

<ul>
  <li>
    Create a new Visual studio solution called <b>SportStore</b> using the Blank Soluction template. For this example will required three projects:
    <ol>
      <li>File -> New -> Project</li>
      <li> 
        Type <b>Blank Solution</b> to search for and click <b>Next</b>, as shown in Figure 7.1A<br />
        <img src="Pictures/Figure 7_1.png" width=850px /><br />
        <i><strong>Figure 7-1A</strong></i>. Creating a new Visual Studio Solution
        <br /><br />
      </li>
      <li>
        In the second screen type <b>SportsStore</b> and click <b>Create</b>, as shown in Figure 7.1B<br />
        <img src="Pictures/Figure 7_1B.png" /><br />
        <i><strong>Figure 7-1B</strong></i>. Creating a new Visual Studio Solution called SportsStore<br />
      </li>
    </ol><br />
  </li>
</ul>

<ul>
 <li>
    To create <b>Domain model -> SportsStore.Domain (Class Library)</b>, follows these steps:
    <ol>
      <li>Right-click on the <b>SportsStore</b> in <b>Solution Explorer</b></li>
      <li>Choose -> <b>Add</b> and <b>New Project</b></li>
      <li>
        On screen <b>Add a new project</b>  type <b>Console Application C#</b>, choose <b>Console App (.NET Framework)</b> and click <b>Next</b>, as shown in the picture below:<br />
        <img src="Pictures/Figure 7_1C.png" /><br />
        <i><strong>Figure 7-1C</strong></i>. Creating SportsStore.Domain project<br /><br />
      </li>
      <li>
        On screen <b>Configure your new project</b> and in the <b>Project name</b> field type <b>SportsStore.Domain</b> and click <b>Create</b>, as shown in the picture below:<br />
        <img src="Pictures/Figure 7_1D.png" /><br />
        <i><strong>Figure 7-1D</strong></i>. Creating SportsStore.Domain project - Ending the process<br />
      </li>
    </ol>
  </li>
</ul>

<ul>
  <li>
      To create <b>MVC application -> SportsStore.WebUI</b>, follows these steps:
      <ol>
        <li>Right-click on the <b>SportsStore</b> in <b>Solution Explorer</b></li>
        <li>Choose -> <b>Add</b> and <b>New Project</b></li>
        <li>On screen Add a new project type <b>MVC</b>, choose <b>ASP.NET Web Application (.NET Framework)</b> and click Next, as shown in the picture below:<br />
          <img src="Pictures/Figure 7_1E.png" /><br />
          <i><strong>Figure 7-1E</strong></i>. Creating SportsStore.WebUI project<br /><br />
        </li>
        <li>
          In the second screen type <b>SportsStore.WebUI</b> and click <b>Create</b>, as shown in Figure 7.1F<br />
          <img src="Pictures/Figure 7_1F.png" /><br />
          <i><strong>Figure 7-1F</strong></i>. Creating SportsStore.WebUI project - Ending the process<br /><br />
        </li>
        <li>In the third screen (Create a new ASP.NET Web Application),  on right side choose <b>Empty</b> template, in left side (Add folders & core references) choose <b>MVC</b> and in <b>Advanced </b> choose <b>Also create a project for unit tests</b> and type <b>SportsStore.UnitTests</b>, as shown in Figure 7.1G<br />
          <img src="Pictures/Figure 7_1G.png" /><br />
          <i><strong>Figure 7-1G</strong></i>. Creating projects SportsStore.WebUI and SportsStore.UnitTests  - Ending the process<br />
      </ol>
    </li>
</ul>

<ul>
  <li>
    After creating the three projects, the Solution Explorer looks like Figure 7-2<br />
    <img src="Pictures/Figure 7_2.png" /><br />
    <i><strong>Figure 7-2</strong></i>. The projects shown in the Solution Explorer window<br />
  </li>
</ul>

<ul>
  <li>
    <i>Selecting a StartUp Project</i> -> The startup project is the project that will be executed by default when you click the start button or F5. To mark SportsStore.WebUI as default project follow these steps:<br />
    <ol>
      <li>Right-click the <b>SportsStore.WebUI</b> project</li>
      <li>Select <b>Set as Startup Project</b></li>
    </ol>
  </li>
</ul>

<h2><i>INSTALING THE TOOL PACKAGES</i></h2>

<ul>
  <li>
    SportsStore.WebUI<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Install-Package Ninject -version 3.0.1.10 <br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Install-Package Ninject.Web.Common -version 3.0.0.7<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Install-Package Ninject.MVC3 -version 3.0.0.6<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Install-Package Moq -version 4.1.1309.1617 <br />
  </li>
  <li>
    SportsStore.UnitTests<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Install-Package Ninject -version 3.0.1.10 <br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Install-Package Ninject.Web.Common -version 3.0.0.7  <br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Install-Package Ninject.MVC3 -version 3.0.0.6 <br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Install-Package Moq -version 4.1.1309.1617  <br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Install-Package Microsoft.Aspnet.Mvc -version 5.0.0 <br />
  </li>
  <li>
    SportsStore.Domain<br />
      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Install-Package Microsoft.Aspnet.Mvc -version 5.0.0 <br />
  </li>
</ul>

<h2><i>ADDING REFERENCES BETWEEN PROJECTS</i></h2>
<center>
  To set up dependencies between projects and to some of the Microsoft assemblies -> Right-click each project in the <b>Solution Explorer</b>, select <b>Add -> Reference ...</b><br />
  <img src="Pictures/Table 7-2.png" />
</center><br />

<h2><i>SETTING UP THE DI CONTAINER</i></h2>
´´´
function test() {
  console.log("notice the blank line before this function?");
}
´´´

<br />
<h2><i>RUNNING THE APPLICATION</i></h2>
