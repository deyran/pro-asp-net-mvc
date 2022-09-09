# Image Uploads
In this section, the SportStore user experience will be increased with addition of these features:
1. Upload product images
2. Store these images in the database
3. Displaying these images in the product catalog

## Extending the Database
In the *Visual Studio* follow these steps to extending the data base:
1. Open the *Server Explorer* windows (*CTRL + ALT + S*)
2. Open *EFDbContext* > Tables > *Products*
3. Right-click on the *Products* table and select *New Query* from the pop-up menu and enter the following SQL into the text area:
```
ALTER TABLE [dbo].[Products] ADD 
    [ImageData] VARBINARY (MAX) NULL,
    [ImageMimeType] VARCHAR (50) NULL;
```
4. Click the Execute button (*CTRL + SHIFT + e*)
5. Right-click on the Products table (*Server Explorer*) and select *Open Table Definition* from the menu
6. You will see that there are now columns called *ImageData* and *ImageMimeType*, as shown in Figure 12-3.
<p align="center">
    <img src="ch12-Pictures/Figure 12-3.png" /><br />
    <b>Figure 12-3.</b> Adding columns to the database
</p>  

## Enhancing the Domain Model 
It is now necessary to add two new fields to the *Products* class in the *SportsStore.Domain* project that correspond to the new database columns, as shown in Listing 12-10.
<p align="center">
    <img src="ch12-Pictures/Listing 12-10.png" /><br />
    <b>Listing 12-10.</b> Adding Properties in the Product.cs File
</p>  

## Creating the Upload User Interface Elements
The next step is to add support for handling file uploads. Modify the *Views/Admin/Edit.cshtml* view so that it matches Listing 12-11.
<p align="center">
    <img src="ch12-Pictures/Listing 12-11.png" /><br />
    <b>Listing 12-11.</b> Adding Properties in the Product.cs File
</p>  

## Saving Images to the Database
* Let's edit the POST version of the *Edit* action method in the Admin controller, to take the image data and save it in the database. Listing 12-12 shows the changes that are required.
<p align="center">
    <img src="ch12-Pictures/Listing 12-12.png" /><br />
    <b>Listing 12-12.</b> Handling Image Data in the AdminController.cs File
</p>  

* Edit the EFProductRepository class (SportsStore.Domain project) to store in the database values assigned to the ImageData and ImageMimeType properties. Listing 12-13 shows the required changes to the SaveProduct method.
<p align="center">
    <img src="ch12-Pictures/Listing 12-13.png" /><br />
    <b>Listing 12-13.</b> Ensuring That the Image Values Are Stored in the Database in the EFProductRepository.cs File
</p>  

## Implementing the GetImage Action Method
To display images contained in the database, you need to implement the GetImage action method on the Product controller (seen in Listing 12-11). Listing 12-14 shows the definition of the action method.
<p align="center">
    <img src="ch12-Pictures/Listing 12-14.png" /><br />
    <b>Listing 12-14.</b> The GetImage Action Method in the ProductController.cs File
</p>  


CHAPTER 12 - SportsStore: Security & Finishing Touches
# Image Uploads 
## Implementing the GetImage Action Method
Listing 12-14. The GetImage Action Method in the ProductController.cs File


## Displaying Product Images