<h1>STYLING THE CONTENT</h1>
<p>In this section, the visual part of the <b>SportsStore</b> application will be worked, a classic two-column layout with header will be implemented.</p>

<h2><i>INSTALLING THE BOOTSTRAP PACKAGE</i></h2>
<ol>
	<li>
		Open <b>Package Manage Console</b> (Tools > NuGet Package Manager > Package Manage Console)
	</li>
	<li>
		Type: <b>Install-Package -version 3.0.0 bootstrap –projectname SportsStore.WebUI</b>
	</li>
</ol>

<h2><i>APPLYING BOOTSTRAP STYLES TO THE LAYOUT</i></h2>
    <ul>
        <li>
            In <b>Listing 7-26</b> you will see the CSS Bootstrap library implemented in the _Layout.cshtml file
            <p align="center">
                <img src="Pictures/Listing 7-26.png" /><br />
                <b>Listing 7-26.</b> Applying Bootstrap CSS to the <b>_Layout.cshtml</b> file
            </p>
        </li>
        <li>
            You need to change the <b>List.cshtml</b> file, as shown in <b>Listing 7-27</b>.
            <p align="center">
                <img src="Pictures/Listing 7-27.png" /><br />
                <b>Listing 7-27</b>. Applying Bootstrap CSS to style the <b>List.cshtml</b> file
            </p>
        </li>
        <li>
            Run the application and see the result in Figure 7-17. 
            <p align="center">
                <img src="Pictures/Figure 7-17.png" /><br />
                <b>Figure 7-17</b>. The design-enhanced <b>SportsStore</b> application
            </p>
        </li>        
    </ul>

<h2><i>CREATING A PARTIAL VIEW</i></h2>