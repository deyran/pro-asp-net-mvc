<h1 align="center">
    CHAPTER 11 - SPORTSSTORE - ADMINISTRATION
</h1>

In this chapter, we will add new features to the SportsStore application that will make it possible to manage the product catalog. These are the features that will be implemented in this chapter:
1. Create, read, update and delete (CRUD) product repository item.
2. Uploading and displaying images alongside products in the catalog.

## ADDING CATALOG MANAGEMENT
* CREATING A CRUD CONTROLLER  
    * To start this journey we will create a new controller (*SportsStore.WebUI project*) for the SportsStore administration by following these steps:
        1. Right-click on the Controllers folder. 
        2. Select *Add > Controller* from the pop-up menu.
        3. Select *MVC 5 Controller – Empty* from the list of options, click add button.
        4. Set the name to *AdminController*, click add button.
        5. Edit the content to match with the Listing 11-1.
            <p align="center">
                <img src="ch11-Pictures/Listing 11-1.png" /><br />
                <b>Listing 11-1.</b> The Contents of the AdminController.cs File
            </p>        

    * The controller constructor declares a dependency on the IProductRepository interface, which Ninject will resolve when instances are created

    * UNIT TEST: THE INDEX ACTION  
        * The focus in this test will be on the index method (AdminController.cs) if it correctly returns the Products objects from the repository. 
        * The test will work like this:
            1. Creating a mock repository
            2. Comparing the test data with the data returned by action method.
        * Create a new test file (*SportsStore.UnitTests* project) called *AdminTests.cs*, edit the content to match with the Listing 11-1A.
            <p align="center">
                <img src="ch11-Pictures/Listing 11-1A.png" /><br />
                <b>Listing 11-1A.</b> The Contents of the AdminTests.cs File
            </p>        

* CREATING A NEW LAYOUT
    * A simple layout will be created for the administration views to apply changes to the product catalog.
    * To create the administration views, follow these steps:
        1. Right-clicking the *Views/Shared* folder in the *SportsStore.WebUI* project
        2. Select *Add > MVC 5 Layout Page (Razor)* from pop-up menu
        3. Set the name to *_AdminLayout.cshtml*
        4. Click the *OK* button to create the file        
    * Set the contents of the new view to match *Listing 11-2*.
        <p align="center">
            <img src="ch11-Pictures/Listing 11-2.png" /><br />
            <b>Listing 11-2.</b> The Contents of the _AdminLayout.cshtml File
        </p>  

* IMPLEMENTING THE LIST VIEW
    * Once created a new layout, it's time to implement a view that corresponds to the *Index* action method of the *AdminController* class
    * To use the *Visual Studio scaffold* follow these steps:
        1. Right-click on the *View/Adimn* folder (*SportsStore.WebUI project*).
        2. Select *Add > View* from the menu.
        3. Select *MVC 5 View* and click the *Add* button
        4. Set all configuration to match *Figure 11-2* and click the *Add* button 
            <p align="center">
                <img src="ch11-Pictures/Figure 11-2.png" /><br />
                <b>Figure 11-2.</b> Configuring a scaffold view
            </p>  
    * In *Listing 11-3* you can see the content of the *Index.cshtml* file
        <p align="center">
            <img src="ch11-Pictures/Listing 11-3.png" /><br />
            <b>Listing 11-3.</b> The Contents of the <i>Views/Admin/Index.cshtml</i> File
        </p>
    * Run the web application and add */Admin/Index* to the URL. Figure 11-3 shows the results.
        <p align="center">
            <img src="ch11-Pictures/Figure 11-3.png" /><br />
            <b>Figure 11-3.</b> Rendering the scaffold List view
        </p>
    * Returning to the do-it-yourself approach, edit the *Index.cshtml* file so that it corresponds to Listing 11-4.
        <p align="center">
            <img src="ch11-Pictures/Listing 11-4.png" /><br />
            <b>Listing 11-4.</b> Modifying the <i>Index.cshtml</i> View
        </p>
    * You can see how this view renders in Figure 11-4    
        <p align="center">
            <img src="ch11-Pictures/Figure 11-4.png" /><br />
            <b>Figure 11-4.</b> Rendering the modified Index view
        </p>

* EDITING PRODUCTS
    * CREATING THE EDIT ACTION METHOD  
        Adding the edit action method in the AdminController.cs file, as you can see in the Listing 11-5.
        <p align="center">
            <img src="ch11-Pictures/Listing 11-5.png" /><br />
            <b>Listing 11-5.</b> Adding the Edit Action Method in the AdminController.cs File
        </p>

        * UNIT TEST: THE EDIT ACTION METHOD
            * This test method will check two behaviors in the Edit action method:  
                1. Getting the product by providing the ID value to edit the expected product.  
                2. Do not get any product if the given id value is not in the repository.
            * Open the *AdminTests.cs* file and edit it to match Listing 11-5A 
                <p align="center">
                    <img src="ch11-Pictures/Listing 11-5A.png" /><br />
                </p>

    * CREATE THE EDIT VIEW
        * Now we have an action method, time to create a view for it to render:
            1. Right-click on the *View/Admin* folder.
            2. Select *Add > MVC 5 View Pagae (Razor)*.
            3. Set the name to *Edit.cshtml*.
            4. Click the button to create the file and edit the contents to match *Listing 11-6*.
                <p align="center">
                    <img src="ch11-Pictures/Listing 11-6.png" /><br />
                    <b>Listing 11-6.</b> The Contents of the Edit.cshtml File
                </p>

        * As you saw in *Lising 11-6*, was used *@Html.EditorForModel()* helper which returns an HTML input element for each property in the model, in this case *Product class*. Run the application and navigate to /Admin/Index, click one of the product name links, and you see the page shown in Figure 11.5.
            <p align="center">
                <img src="ch11-Pictures/Figure 11-5.png" /><br />
                <b>Figure 11-5.</b> The page generated using the EditorForModel helper method
            </p>  

        * We can influence the output of the *Html.EditorForModel* using *model metadata*. Listing 11-7 shows how to use metadata on the Product class in the SportsStore.Domain project.   
            <p align="center">
                <img src="ch11-Pictures/Listing 11-7.png" /><br />
                <b>Listing 11-7.</b> Using Model Metadata in the Product.cs File
            </p>

        * Run the web application, add */Admin/Edit?ProductID=1* to the URL and see the effect of the metadata on the fields (Figure 11-6).
            <p align="center">
                <img src="ch11-Pictures/Figure 11-6.png" /><br />
                <b>Figure 11-6.</b> The effect of applying metadata
            </p>  

        * Open the *Edit.cshtml* file edit it to match with the contents of Listing 11-8.
            <p align="center">
                <img src="ch11-Pictures/Listing 11-8.png" /><br />
                <b>Listing 11-8.</b> Updating the Edit.cshtml File
            </p>
        
        * You can see how this view is displayed in the browser in Figure 11-7.
            <p align="center">
                <img src="ch11-Pictures/Figure 11-7.png" /><br />
                <b>Figure 11-7.</b> Displaying the editor page for products
            </p>  
        

    * UPDATING THE PRODUCT REPOSITORY
        * Before implementing the save method (*Figure 11-7*), you need to add a new method to the ProductRepository (*SportsStore.Domain project*), as shown in Listing 11-9
            <p align="center">
                <img src="ch11-Pictures/Listing 11-9.png" /><br />
                <b>Listing 11-9.</b> Adding a Method to the IProductRespository.cs File
            </p>  

        * Now time to implement the SaveProduct in the EFProductRepository.cs file using Entity Framework as shown in Listing 11-10
            <p align="center">
                <img src="ch11-Pictures/Listing 11-10.png" /><br />
                <b>Listing 11-10.</b> Implementing the SaveProduct Method in the EFProductRepository.cs File
            </p>  

    * HANDLING EDIT POST REQUESTS
        <ol>
            <li>
                We can make the *Save* button work by implementing the overload *Edit* action method of the *AdminController* class. The new method is shown in Listing 11-11.
                <p align="center">
                    <img src="ch11-Pictures/Listing 11-11.png" /><br />
                    <b>Listing 11-11.</b> Adding the POST-Handling Edit Action Method in the AdminController.cs File
                </p><br />
                Here are some points we need to see about the code shown in Listing 11-11:
                <ul>
                    <li>
                        The *model binder* is able to validate the submitted data by reading its values using the *ModelState.IsValid* property. If the model binder validation is correct, all changes are saved to the repository, the Index action method is invoked and the user accesses the list of products. Otherwise, any problems with the data, *Edit* view is called again for the user make the corrections            
                    </li>
                    <li>
                        After changes saved to the repository, message is stored to the *TempData* feature. The *TempData* feature is a key/value dictionary similar to the Session data and *ViewBag* features. The most important difference from Session data is the TempData is deleted when the HTTP request ends.             
                    </li>
                    <li></li>
                </ul>
            </li>
            <li>UNIT TEST: EDIT SUBMISSIONS</li>
        </ol>

    * DISPLAYING A CONFIRMATION MESSAGE
    * ADDING MODEL VALIDATION
    * ENABLING CLIENT-SIDE VALIDATION        

CHAPTER 11 - SPORTSSTORE - ADMINISTRATION
    ADDING CATALOG MANAGEMENT
        HANDLING EDIT POST REQUESTS
            Listing 11-11. Adding the POST-Handling Edit Action Method in the AdminController.cs File

* CREATING NEW PRODUCTS
* DELETING PRODUCTS