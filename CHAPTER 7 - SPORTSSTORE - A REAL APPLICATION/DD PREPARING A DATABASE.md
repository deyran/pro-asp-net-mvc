<h1>PREPARING A DATABASE</h1>
    <ul>
        <li>
            Before implement a real repository, it's necessary to set up a database and populate it with some data.
        </li>
        <li>
            To show a simple list of products and details of their content, will be used these approaches:
            <ol>
                <li>SQL Server as the database</li>
                <li>Entity Framework (EF) to access the database</li>
                <li>LINQ (Language-Integrated Query)</li>
            </ol>            
        </li>
    </ul>

<h2><i>CREATING THE DATABASE</i></h2>
    <ul>
        <li>
            "Microsoft SQL Server Express <b>LocalDB</b> is a feature of SQL Server Express target to developers. It is available on SQL Server Express with advanced services".<br />
            "<b>LocalDB</b> installation copies a minimal set of files necessary to start the SQL Server Database Engine [...]" <br />
            &nbsp;&nbsp;&nbsp;&nbsp;<b>FONT:</b> https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15 <br />
            &nbsp;&nbsp;&nbsp;&nbsp;<b>DATE:</b> 10-21-91 <br /><br />
        </li>
        <li>
            To create the database connection, follow these steps:
            <ol>
                <li>In the top menu, open the <b>Server Explorer</b> window (View > Server Explorer)</li>
                <li>
                    Click the <b>Connect to Database</b>
                    <img src="Pictures/Figure 7_7A.png" />
                    button
                </li>
                <li>
                    In the <b>Choose Data Source </b> dialog box (shown in Figure 7-7 below), click the <b>Continue</b> button
                    <p align="center">
                        <img src="Pictures/Figure 7_7.png" /><br />
                        <i><b>Figure 7-7.</b> Selecting the data source.</i>
                    </p>
                </li>
                <li>
                    You will see the <b>Add Connection</b> dialog (Figure 7-8), follow these steps. 
                    <ol>
                        <li>Set the <b>Server name</b> -> (localdb)\MSSQLLocalDB</li>
                        <li>In <b>Log on to the server</b>, Authentication:, set <b>Windows Authentication</b></li>
                        <li>In <b>Select or enter a database name</b>, set <b>SportsStore</b></li>
                    </ol>
                    <p align="center">
                        <img src="Pictures/Figure 7_8.png" /><br />
                        <i><b>Figure 7-8.</b> Selecting the data source.</i>
                    </p>
                </li>
                <li>
                    As can be seen, localdb database has been created (Figure 7-9)
                    <p align="center">
                        <img src="Pictures/Figure 7-9.png" /><br />
                        <i><b>Figure 7-9.</b> The localdb database as shown in the Server Explorer window.</i>
                    </p>
                </li>
            </ol>
        </li>
    </ul>

<h2><i>DEFINING THE DATABASE SCHEMA</i></h2>
    <ul>
        <li>
            To create the database table, follow these steps:
            <ol>
                <li>
                    Right-click on <b>Tables</b> and choose the <b>Add a New Table</b> option, as shown in Figure 7-10
                    <p align="center">
                        <img src="Pictures/Figure 7-10.png" /><br />
                        <i><b>Figure 7-10.</b> Adding a new table</i>
                    </p>
                </li>
                <li>
                    Enter the SQL statement shown in Listing 7-11 and click the <b>Update</b> <img src="Pictures/Listing 7-11A.png" />
                    button in the top-left of the table design window
                    <p align="center">
                        <img src="Pictures/Listing 7-11.png" /><br />
                        <i><b>Listing 7-11.</b> The SQL statement to create the table in the SportsStore database</i>
                    </p>
                </li>
                <li>
                    In the <b>Preview Database Updates</b> dialog, click the <b>Update Database</b> button, as shown in Figure 7-11.
                    <p align="center">
                        <img src="Pictures/Figure 7-11.png" /><br />
                        <i><b>Figure 7-11.</b> The summary of the effect of the SQL statement</i>
                    </p>
                </li>
            </ol>
        </li>
    </ul>

<h2><i>ADDING DATA TO THE DATABASE</i></h2>
<ul>
    <li>
        To add data to the database, follow these steps:
        <ol>
            <li>In the <b>Server Explorer</b> window, right-click on the <b>Tables</b> item</li>
            <li>
                Select <b>New Query</b>, and insert de code below: <br />
                <h4><i>INSERT INTO Products (Name, Description, Category, Price) VALUES ('Kayak', 'A boat for one person', 'Watersports', 275.00);</i></h4>
                <h4><i>INSERT INTO Products (Name, Description, Category, Price) VALUES ('Lifejacket', 'Protective and fashionable', 'Watersports', 48.95);</i></h4>
                <h4><i>INSERT INTO Products (Name, Description, Category, Price) VALUES ('Soccer Ball', 'FIFA-approved size and weight', 'Soccer', 19.50);</i></h4>
                <h4><i>INSERT INTO Products (Name, Description, Category, Price) VALUES ('Corner Flags', 'Give your playing field a professional touch', 'Soccer', 34.95);</i></h4>
                <h4><i>INSERT INTO Products (Name, Description, Category, Price) VALUES ('Stadium', 'Flat-packed, 35,000-seat stadium', 'Soccer', 79500.00);</i></h4>
                <h4><i>INSERT INTO Products (Name, Description, Category, Price) VALUES ('Thinking Cap', 'Improve your brain efficiency by 75%', 'Chess', 16.00);</i></h4>
                <h4><i>INSERT INTO Products (Name, Description, Category, Price) VALUES ('Unsteady Chair', 'Secretly give your opponent a disadvantage', 'Chess', 29.95);</i></h4>
                <h4><i>INSERT INTO Products (Name, Description, Category, Price) VALUES ('Human Chess Board', 'A fun game for the family', 'Chess', 75.00);</i></h4>
                <h4><i>INSERT INTO Products (Name, Description, Category, Price) VALUES ('Bling-Bling King', 'Gold-plated, diamond-studded King', 'Chess', 1200.00);</i></h4>
            </li>
            <li>Click on the <b>Execute</b> <img src="Pictures/Figure 7-12A.png" /> button</li>
        </ol><br />
    </li>
    <li>
        To see the result (Figure 7-12) follow these steps:
        <ol>
            <li>In the <b>Server Explorer</b> window, expand the <b>Tables</b> item</li>
            <li>
                Right-click on the <b>Products</b> table and select <b>Show Table Data</b>
            </li>
        </ol>
        <p align="center">
            <img src="Pictures/Figure 7-12.png" /><br />
            <b>Figure 7-12.</b> Data from <b>Products</b> table.
        </p>
    </li>    
</ul>

<h2><i>CREATING THE ENTITY FRAMEWORK CONTEXT</i></h2>
<ul>
	<li>
		<h3>To associate the model class with the database, we need to follow the steps below:</h3>
		<ol>
			<li><i>Install Entity Framework</i></li>
			<li><i>Create a context class</i></li>
			<li><i>Connect Entity Framework with database</i></li>
		</ol><br />
	</li>
    <li>
        <h3>Install Entity Framework</h3>
        <ol>
            <li>Open <b>Package Manager Console</b></li>
            <li>Install-Package EntityFramework -projectname SportsStore.Domain</li>
            <li>Install-Package EntityFramework -projectname SportsStore.WebUI</li>
        </ol><br />
    </li>
    <li>
        <h3>Create a context class</h3>
        The purpose of the context class is to associate the model to the database, to start this process follow these steps:
        <ol>
            <li>Create a new folder in the <b>SportsStore.Domain</b> project called <b>Concrete</b></li>
            <li>Add a new class file called <b>EFDbContext.cs</b> within the <b>Concrete</b> folder</li>
            <li>
                Edit the contents of the class file so they match <b>Listing 7-12</b>, 
                as shown in the picture below: <br /><br />
                <p align="center">
                    <img src="Pictures/Listing 7-12.png" /><br />
                    <b>Listing 7-12.</b> The content of the EFDbContext.cs file
                </p>
                <i>
                    <b>Tip:</b>
                    <ol>
                        <li>The name of the property (Products) specifies the table (dbo.Products)</li>
                        <li>
                            The type parameter of the DbSet result specifies the model type, in that case SportsStore.Domain.Entities.Product
                        </li>
                        <li>The Entity Framework use the type parameter to represent rows in the Products table (dbo.Products)</li>
                    </ol>
                </i>    
            </li>
        </ol><br />
    </li>
    <li>
        <h3>Connect Entity Framework with database</h3>
        <ol>
            <li>
                Go to <b>Server Explorer</b> right-click on the localdb database (Figure 7-9) and choose <b>Properties</b> option.
                <p align="center">
                    <img src="Pictures/Figure 7-9.png" /><br />
                    <i><b>Figure 7-9.</b> The localdb database as shown in the Server Explorer window.</i>
                </p>
            </li>
            <li>
                Copy the <b>Connection String</b> value (See the Figure 7-12b)
                <p align="center">
                    <img src="Pictures/Figure 7-12B.png" /><br />
                    <i><b>Figure 7-12B.</b> Properties window.</i>
                </p>
            </li>
            <li>
                In the <b>SportsStore.WebUI</b> open the file <b>Web.config</b> to add a database connection string (see <b>Listing 7-13</b>). In the <b>connectionString</b> field, fill it in with the value you copied.
                <p align="center">
                    <img src="Pictures/Listing 7-13.png" /><br />
                    <i><b>Listing 7-13.</b> Adding a database connection in the Web.config file.</i>
                </p>
            </li>
        </ol>
    </li>
</ul>

<h2><i>CREATING THE PRODUCT REPOSITORY</i></h2>
<ol>
    <li>
        In the <b>Concrete</b> folder (SportsStore.Domain project), add a class called <b>EFProductRepository.cs</b>
    </li>
    <li>
        Edit the <b>EFProductRepository.cs</b> file to match with <b>Listing 7-14</b>, as shown in the figure below:
        <p align="center">
            <img src="Pictures/Listing 7-14.png" /><br />
            <b>Listing 7-14.</b> The contents of the EFProductRepository.cs File
        </p>
    </li>
    <li>
        Edit the <b>NinjectDependencyResolver.cs</b> class file in the <b>SportsStore.WebUI</b> project so that the <b>AddBindings</b> method looks like Listing 7-15.
        <p align="center">
            <img src="Pictures/Listing 7-15.png" /><br />
            <b>Listing 7-15.</b> Adding the real repository binding in the NinjectDependencyResolver.cs file
        </p>
    </li>
    <li>
        Run the application and Figure 7-13 show the results;
        <p align="center">
            <img src="Pictures/Figure 7-13.png" /><br />
            <b>Figure 7-13.</b> The result of implementation the real repository
        </p>
    </li>
</ol>