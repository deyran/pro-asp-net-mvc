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
        5. Edit it to match with the Listing 11-1.
            <p align="center">
                <img src="ch11-Pictures/Listing 11-1.png" /><br />
                <b>Listing 11-1.</b> The Contents of the AdminController.cs File
            </p>        

    * AAAAAAAAAAAA
  

The controller constructor declares a dependency on the IProductRepository interface, which Ninject will resolve when instances are created. The controller defines a single action method, Index, that calls the View method to select the default view for the action, passing the set of products in the database as the view model.

* CREATING A NEW LAYOUT
* IMPLEMENTING THE LIST VIEW
* EDITING PRODUCTS
* CREATING NEW PRODUCTS 
* DELETING PRODUCTS

CHAPTER 11 - SPORTSSTORE - ADMINISTRATION
    ADDING CATALOG MANAGEMENT
        CREATING A CRUD CONTROLLER
            Listing 11-1. The Contents of the AdminController.cs File