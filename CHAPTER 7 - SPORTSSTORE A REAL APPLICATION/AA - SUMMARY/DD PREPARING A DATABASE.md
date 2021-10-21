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
<h2><i>ADDING DATA TO THE DATABASE</i></h2>
<h2><i>CREATING THE ENTITY FRAMEWORK CONTEXT</i></h2>
<h2><i>CREATING THE PRODUCT REPOSITORY</i></h2>
