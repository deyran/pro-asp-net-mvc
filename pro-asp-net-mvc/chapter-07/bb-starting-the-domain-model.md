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

1. I need some way of getting Product entities from a database. 
    Getting Product entities from a database

As I explained in Chapter 3, the model includes the persistence logic for storing and retrieving the data from the persistent data store, 
    Model > Persistence Logic > storing and retrieving data > Persistente data store

but even within the model, I want to keep a degree of separation between the data model entities and the storage and retrieval logic, 
which I achieve using the repository pattern. 
    Model > Separation > data entities, storage, retrieval logic > Repository pattern


I will not worry about how I am going to implement data persistence for the moment, but I will start the process of defining an interface for it.
    At the moment, data persistence will not be implemented, but the process of defining an interface for it will be implemented


Create a new top-level folder inside the SportsStore.Domain project called Abstract and, within the new folder, a new interface file called IProductsRepository.cs, the contents of which Listing 7-4 shows. You can add a new interface by right-clicking the Abstract folder, selecting Add ➤ New Item, and selecting the Interface template. 

Listing 7-4. The Contents of the IProductRepository.cs File

This interface uses IEnumerable<T> to allow a caller to obtain a sequence of Product objects, without saying how or where the data is stored or retrieved. A class that depends on the IProductRepository interface can obtain Product objects without needing to know anything about where they are coming from or how the implementation class will deliver them. This is the essence of the repository pattern. I will revisit the IProductRepository interface throughout the development process to add features.

# chapter-07-SportsStore-A-Real-Application
## Creating an abstract repository


## Making a Mock Repository