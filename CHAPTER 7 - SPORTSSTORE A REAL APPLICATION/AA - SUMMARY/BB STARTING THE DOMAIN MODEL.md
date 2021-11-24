<h1>STARTING THE DOMAIN MODEL</h1>
    <ul>
        <li>
           All MVC Framework projects start with the [domain model](GLOSSARY/DOMAIN MODEL.MD) because everything in an MVC Framework application revolves around it.
        </li>
        <li>
           Create a new folder called <b>Entities</b> inside the <b>Sports.Domain</b>
        </li>
        <li>
            Create a class called <b>Product.cs</b> and place it inside of <b>Entities</b> folder. 
            You can see the structure in Figure 7-4.
            <p align="center">
                <img src="Pictures/Figure 7_4.png" /><br />
                <b>Figure 7-4.</b> Creating the Product class
            </p>
        </li>
        <li>
            Edit the <b>Product.cs</b> class file so that it matches Listing 7-3.
            <p align="center">
                <img src="Pictures/Listing 7-3.png" /><br />
                <b>Listing 7-3.</b> The Contents of the Products.cs file
            </p>
        </li>
    </ul>

<h2><i>CREATING AN ABSTRACT REPOSITORY</i></h2>
<ul>
    <li>
        <b>Abstract repository</b> is a degree of separation between data model entities and store and retrieve logic that is achieved using the <b>repository pattern</b>
    </li>
    <li>
        At this first moment we will not implement data persistence, but we will define an interface for it.        
    </li>
    <li>
        In the SportsStore.Domain project create a folder called <b>Abstract</b>
    </li>
    <li>
        Implement an interface called <b> IProductRepository.cs </b>, place it in the <b> Abstract </b> folder, as shown in Listing 7-4 below.<br />
        <p align="center">
            <img src="Pictures/Listing 7-4.png" /><br />
            <b>Listing 7-4.</b> The contents of the IProductRepository.cs file. 
        </p>
    </li>
</ul>

<h2><i>MAKING A MOCK REPOSITORY</i></h2>
<ul>
    <li>
        Before to implementing the persistence mechanism and connecting it to a database, we will create a mock implementation. 
        You'll see the Mock <b>IProductRepository</b> implementation in Listing 7-5.
        <br />
        <p align="center">
            <img src="Pictures/Listing 7-5.png" /><br />
            <b>Listing 7-5.</b> Adding the Mock <b>IProductRepository</b> implementation in the <b>NinjectDependencyResolver.cs</b> file
        </p>        
    </li>
</ul>
