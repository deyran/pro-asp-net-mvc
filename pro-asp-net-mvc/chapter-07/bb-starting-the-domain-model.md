# Starting the domain model
* This MVC Framework projects will start with the *domain model* because everything in an MVC Framework application revolves around it. Create a new folder called *Entities* (SportsStore.Domain project), and then a new file called *Product.cs* within it, as shown as in Figure 7-4.
<p align="center">
    <img src="ch07-Pictures/Figure 7-4.png" /><br />
    <b>Figure 7-4.</b> Creating the Product class
</p>  

* Edit the Product.cs class file so that it matches Listing 7-3.
<p align="center">
    <img src="ch07-Pictures/Listing 7-3.png" /><br />
    <b>Listing 7-3.</b> The Contents of the Product.cs File
</p>  

## Creating an abstract repository
When talking about *Model*, we are talking about the process of storing and retrieving data from a database, the *Repository Pattern* approach will be used to deal with this issue. At the moment, data persistence will not be implemented, but the process of defining an interface for it will be implemented. To start the process of defining this interface, follow these steps:
1. In the *SportsStore.Domain* project, create a folder called *Abstract*.
2. Within the *Abstract* folder, create a *interface* file called IProductsRepository.cs
3. Edit IProductsRepository.cs to match Listing 7-4.
<p align="center">
    <img src="ch07-Pictures/Listing 7-4.png" /><br />
    <b>Listing 7-4.</b> The Contents of the IProductRepository.cs File
</p>  

## Making a Mock Repository

<!--
# chapter-07-SportsStore-A-Real-Application
## Making a Mock Repository
-->