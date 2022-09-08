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




# Image Uploads 
## Enhancing the Domain Model 316
Listing 12-10. Adding Properties in the Product.cs File


## Creating the Upload User Interface Elements
## Saving Images to the Database
## Implementing the GetImage Action Method
## Displaying Product Images