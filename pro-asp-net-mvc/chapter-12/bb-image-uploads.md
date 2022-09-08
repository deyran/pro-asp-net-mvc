# Image Uploads
In this section, the SportStore user experience will be increased with addition of these features:
1. Upload product images
2. Store these images in the database
3. Displaying these images in the product catalog

## Extending the Database
In the *Visual Studio* follow these steps to extending the data base:
1. Open the *Server Explorer* windows (*CTRL + ALT + S*)
2. Open *EFDbContext* > Tables > *Products*
3. Right-click on the Products table and select New Query from the pop-up menu and enter the following SQL into the text area:
```
ALTER TABLE [dbo].[Products] ADD 
    [ImageData] VARBINARY (MAX) NULL,
    [ImageMimeType] VARCHAR (50) NULL;
```

Click the Execute button (which is marked with an arrow) in the top-left cover of the window and Visual Studio will update the database, adding two new columns to the table. To test the update, right-click on the Products table in the Server Explorer window and select Open Table Definition from the menu. You will see that there are now columns called ImageData and ImageMimeType, as shown in Figure 12-3.

# Image Uploads 
## Extending the Database 316

## Enhancing the Domain Model 
## Creating the Upload User Interface Elements
## Saving Images to the Database
## Implementing the GetImage Action Method
## Displaying Product Images