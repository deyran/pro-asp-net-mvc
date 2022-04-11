<h1>
	<div align="center">CHAPTER 9 - SPORTSSTORE - COMPLETING THE CART</div>
</h1>

<p align="center">
	In this chapter, the implementation of the SportsStore app will continue
</p>

<h1><i>USING MODEL BINDING</i></h1>
<p align="center">
	<img src="ch09-Pictures/MODEL_BINDING_MIDDLEMAN.png" /><br />
	Model Binding
</p>

&nbsp;&nbsp;&nbsp;&nbsp;ASP.NET MVC model binding is a process for automatically converting HTTP requests into objects that are passed to an action method parameters. Model binding, as an abstraction layer, simplifies this entire conversion process. In this section wil be implemented a custom model binder to improve the CartController class, taking the Cart object contained in the session data and passing them as parameters to the action method in the CartController class.

<ul>
	<li>
		<h2><i>Creating a Custom Model Binder</i></h2>
		To implement custom model using the <i>System.Web.Mvc.IModelBinder</i> interface follow these steps:
		<ol>
			<li>Added a new folder in the <i>SportsStore.WebUI</i> project inside the folder <i>Infrastructure</i> called <i>Binders</i></li>
			<li>Create a <i>CartModelBinder.cs</i> class inside it</li>
			<li>
				Implement the <i>CartModelBinder.cs</i> class shows in the code below (Listing 9-1)
				<p align="center">
					<img src="ch09-Pictures/Listing 9-1.png" /><br />
					<b>Listing 9-1.</b> The Contents of the CartModelBinder.cs File
				</p>
			</li>
		</ol>
	</li>
	<li>AAA</li>
	<li>BBBB</li>
</ul>

USING MODEL BINDING
	CREATING A CUSTOM MODEL BINDER
		Listing 9-1. The Contents of the CartModelBinder.cs File
------------------------------------------------------------------------------------------

USING MODEL BINDING
	CREATING A CUSTOM MODEL BINDER
		Listing 9-2. Registering the CartModelBinder Class in the Global.asax.cs File
------------------------------------------------------------------------------------------

USING MODEL BINDING
	CREATING A CUSTOM MODEL BINDER
		Listing 9-3. Relying on the Model Binder in the CartController.cs File
------------------------------------------------------------------------------------------

USING MODEL BINDING
	CREATING A CUSTOM MODEL BINDER
		UNIT TEST: THE CART CONTROLLER
	
