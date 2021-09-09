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

<br /><h1>GETTING STARTED</h1>

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
  </li><br />

  <li>
    Create a new Visual studio solution called <b>SportStore</b> using the Blank Soluction template. For this example will required three projects:
    <ol>
      <li>File -> New -> Project</li>
      <li>
        Type <b>Blank Solution</b> to search for and click <b>Next</b>, as shown in Figure 7.1A<br />
        <img src="Figure 7_1.png" width=850px /><br />
        <i><strong>Figure 7-1A</strong></i>. Creating a new Visual Studio Solution
        <br /><br />
      </li>
      <li>
        In the second screen type <b>SportsStore</b> and click <b>Create</b>, as shown in Figure 7.1B<br />
        <img src="Figure 7_1B.png" /><br />
        <i><strong>Figure 7-1B</strong></i>. Creating a new Visual Studio Solution called SportsStore<br />
      </li>
    </ol><br />
  </li>

  <li>
    To create <b>Domain model -> SportsStore.Domain (Class Library)</b>, follows these steps:
    <ol>
      <li>Right-click on the <b>SportsStore</b> in <b>Solution Explorer</b></li>
      <li>Choose -> <b>Add</b> and <b>New Project</b></li>
      <li>
        On screen <b>Add a new project</b>  type <b>Console Application C#</b>, choose <b>Console App (.NET Framework)</b> and click <b>Next</b>, as shown in the picture below:<br />
        <img src="Figure 7_1C.png" /><br />
        <i><strong>Figure 7-1C</strong></i>. Creating SportsStore.Domain project<br /><br />
      </li>
      <li>
        On screen <b>Configure your new project</b> and in the <b>Project name</b> field type <b>SportsStore.Domain</b> and click <b>Create</b>, as shown in the picture below:<br />
        <img src="Figure 7_1D.png" /><br />
        <i><strong>Figure 7-1D</strong></i>. Creating SportsStore.Domain project - Ending the process<br />
      </li>
    </ol>
  </li>
</ul>

<h2><i>INSTALING THE TOOL PACKAGES</i><h2>
<h2><i>ADDING REFERENCES BETWEEN PROJECTS</i><h2>
<h2><i>SETTING UP THE DI CONTAINER</i><h2>
<h2><i>RUNNING THE APPlICATION</i><h2>
