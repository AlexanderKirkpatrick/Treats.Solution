# _Pierre's Sweet and Savory Treats Inventory Tracker!_

#### By _**Alexander Kirkpatrick**_

#### _A MVC web application for managing a factory's treats and it's flavors, using authentication with identity framework._

## Technologies Used

* MySql
* C#
* .NET 5.0 SDK
* MSTest
* ASP.NET Core MVC
* Entity Core Framework
* HTML
* CSS 
* Bootstrap
* Markdown

## Description

_This application was created for an independent project requirement during my time at Epicodus. It allows the user to to manage a list of treats and the treat's flavors, following best practices and conventions, as established by the CRUD methodology. This application utilizes MySQl Workbench for hosting and data storage capabilities. This project has a many to many relationship policy. It also uses authentication with identity to allow the user to log in and edit the database._

## Setup/Installation Requirements

_Open via Bash/GitBash/GitHub;_
* Click the green "Clone or download" button at the right of the screen.
* Select "Download ZIP."
* Use a file extractor or unzip program (such as PeaZip, Unzipper, WinZip, Zipware, or 7-ZIP) to extract the ZIP files onto your computer.
* In your browser, navigate to https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.408-macos-x64-installer for Mac or https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.408-windows-x64-installer for Windows. Click the link "click here to download manually" if the download for .NET Core 5.0.408 SDK does not start automatically.
* Double-click the downloaded .NET Core 5.0.408 SDK file and run the installer.
* Open your computer's terminal and navigate to the directory bearing the name of the program and containing the top level subdirectories and files.
* Enter the command "dotnet build" in the terminal.
* To ensure creation, use your terminal to input the command _touch appsettings.json_ in the top level of the directory.
* To properly fill out the connection string, you must first install MySQL Workbench to have the relevant information.
* Download and install instructions for MySQL Workbench can be found here at https://dev.mysql.com/downloads/workbench/8.0.html.
* A code editor will be needed to edit the _appsettings.json_ file. You can download for free VSCode here https://code.visualstudio.com/Download.
* The syntax for the _appsettings.json_ file is as follows ... 
  * {
      "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Port=3306;database=your_database_name_here;uid=your_user_id_here;pwd=your_password;"
     }
    } 
* Once work bench is open, in the _Navigator > Administration_ window, select _Data Import/Restore_.
* In _Import Options_ select _Import from Self-Contained File_. 
* Navigate to the Alexander_Kirkpatrick.sql dump file within the top directory of the application.
* Under _Default Schema to be Imported To_, select the _New_ button.
* Enter the name of the database, factory. Then click _OK_.
* Navigate to the tab called _Import Progress_ and click _Start Import_ at the bottom right corner of the window. 
* Reopen the _Navigator > Schemas_ tab. Right click and select _Refresh All_. The new database will appear.
* If the build fails to properly restore, Entity Framework commands for the terminal are as follows:
   * dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
   * dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
   * dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
* Within the top directory, enter the command "dotnet run" in the terminal.  Enter the link http://localhost:5000 in your browser to run the application.

## Known Bugs

* _No known bugs._  

## License

MIT License

Copyright (c) _August_2022_ _Alexander Kirkpatrick_