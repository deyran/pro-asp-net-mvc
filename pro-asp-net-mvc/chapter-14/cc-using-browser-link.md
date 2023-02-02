<h1 align="center">
    Chapter 14: Overview of MVC Projects
</h1>

# Using Browser Link
P1--------------
* Visual Studio 2013 includes a feature called browser link that allows you to view the application in multiple browsers simultaneaously and have them all reload when you make a change.
* This feature is most useful once an application has stabilized and you are doing fit and finish work on the HTML and CSS that your views generate (I'll explain why shortly)

P2--------------
* To use browser link, click on the small down arrow next to the selected browser on the Visual Studio toolbar and select Browser With from the menu, as shown in Figure 14-17.

P3--------------
* The Browse With dialog window will appear.
* Hold the control key and select the browser that you want to use.
* In Figure 14-18, you can see that I have chosen Internet Explorer and Chrome.
* You can also use this dialog to add new browsers (although Visual Studio is pretty good at detecting most of the mainstream ones).

P4--------------
* Click the Browser button and Visual Studio will open the browsers you have selected and have each of them load the project URL. 
* You can edit the code and views in the application and then update all of the browser windows by selecting Refresh Linked Browsers from the Visual Studio toolbar, as shown in Figure 14-19. 
* The application will be compiled automatically so that you can see changes.

P5--------------
* This feature works by including some JavaScript in the HTML, sent to the browser and it can br a nice way of developing iteratively. 
* The reason that I recommend it only for working on views is that they are less likely to cause IIS to send HTTP error messages to the browser, which is what happens when there is an error in the code. 
* The JavaScript code isn't added to error responses, which means that the link between Visual Studio and the browsers is lost. You have to start over using the Browse With menu. 
* The browser link feature is a good idea, but the use of JavaScript is a problem. 
* I use a similar tool called LiveReload(http://livereload.com) for my non-ASP.NET development and it providers a better approach because it uses browser plugings that are not affected by HTTP error messages. 
* The value of Visual Studio browser link will be limited until Microsoft takes a similar approach.

<!--
Chapter 14: Overview of MVC Projects
    # Using Browser Link 366-368
        Figure 14-17. Preparing to select the browsers used for the browser link feature
        Figure 14-18. Selecting multiple browsers
        Figure 14-19. Refreshing linked browsers
-->