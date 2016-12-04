#Mobile Applications 3
##Jason McTigue
###G00312233

## Introduction
For my mobile applications module in 4th year I had to make a Universal Windows Platform(UWP) application. I decided to make a savings accumulator app, the aim for this app is to allow the user to enter a target and its price and then they can add or take away an amount as desired. This app looks quite simple but it has a lot of complexity behind as I tried to add all the technologies I learned this semester. I used the Model-View-ViewModel pattern (MVVM) while developing the application and I also used SQLite as my database.


##Technologies 

| **Technologies**       | 
| -------------          |
| UWP    |
| MVVM    |
| Entity Framwork Core   |
| SQLite | 
| INotifyPropertyChanged |
| Data Binding to view model |
| Await and Async |
| Lambda Expressions |

##Database

To create the SQLite database I used entity framework core. I installed the following packages using NuGet Package Manager:

    - Install-Package EntityFramework.SQLite –Pre
    - Install-Package EntityFramework.Commands –Pre 

I then Create a data model and Create a database file called SavingsAccumulator2.db.
I declared the Primary key by typing:

        
        [Key]//sets Id as the primary key
        public int TargetId { get; set; }
        

Finally  I ran:

    -Add-Migration MyFirstMigration
    
 This then created the initial set of tables for my model.
 
 To make sure this works on every device the application is run on, I added the following code to the app.xaml.cs page.
 
            
            using (var db = new TargetDataContext()) {
                db.Database.Migrate();
            }       
            

This will take care of creating the local database for each new device.



## How to use the application
To use the Application the user needs to click on the command bar in the bottom right hand side of the screen and then click on the add icon.
From here the user can add their target the amount there saving for and any notes.

This saving target is then added to the database and is displayed on the homescreen. From here the user can see how close they are to reaching their target and have the ability to add and subtract an amount from there account.

An Example of how to use the app is demonstrated in the following screenshots:



<img src="Screenshots/Homepage.PNG" alt="home" width="200" height="200"/>
<img src="Screenshots/add_page.PNG" alt="home" width="200" height="200"/>
<img src="Screenshots/main_page.PNG" alt="home" width="200" height="200"/>
<img src="Screenshots/add.PNG" alt="home" width="200" height="200"/>
<img src="Screenshots/updated.PNG" alt="home" width="200" height="200"/>

## Problems
In general I found this project to be quite challenging as there were a few more features that I would have liked to add in.
I tried to add in error handling on the text boxes by using [WinUx](http://jamescroft.co.uk/blog/winux/adding-textbox-validation-to-your-uwp-application-with-winux/) but I was unable to fully implement it in to my project.

Another feature that I would have liked to have added was a progress bar which would increase and decrease depending on the values inputted. I couldn’t figure out why this wouldn't work as I had set the minimum value as the current balance and the maximum as the target to reach.

Finally I would have like to added in an update feature but due to time constraints I was unable to add it in.

##References
[SQLite and Entity Framework on UWP](https://xamlbrewer.wordpress.com/2016/06/01/getting-started-with-sqlite-and-entity-framework-on-uwp/)
[Binding](https://msdn.microsoft.com/en-us/windows/uwp/xaml-platform/x-bind-markup-extension)
[MVVM](https://blogs.msdn.microsoft.com/johnshews_blog/2015/09/09/a-minimal-mvvm-uwp-app/)
[Await and Async](https://channel9.msdn.com/Series/Windows-Phone-8-1-Development-for-Absolute-Beginners/Part-19-Understanding-async-and-Awaitable-Tasks)
[INotifyPropertyChanged](https://learnwithbddevs.wordpress.com/2014/10/09/data-binding-with-inotifypropertychanged-interface/)
[Data Binding](http://stackoverflow.com/questions/38247631/data-binding-in-uwp-user-controls-using-template-10)
[WinUx](http://jamescroft.co.uk/blog/winux/adding-textbox-validation-to-your-uwp-application-with-winux/)
