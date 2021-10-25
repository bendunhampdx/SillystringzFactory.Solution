# Dr Sillystringz's Factory

#### An Epicodus project that allows the user to keep track of machine repairs

#### Created By: Ben Dunham

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench

## Description

This application was created to show many to many relationships between Engineers and machines that they are activly working on. 

## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation

* Clone [this](https://github.com/bendunhampdx/SillystringzFactory.Solution) repository, or download and open the Zip on your local machine
* Open the Factory.Solutions folder in your preferred text editor
* To install required packages, navigate to Factory.Solutions/Factory in the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef --version 3.0.0
* Create a file named "appsettings.json" in the Factory directory
  - add the following code to the appsettings.json file:
  ```
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=ben_dunham;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }.
  ```
  - replace [YOUR-PASSWORD-HERE] with your unique MySql password
* Launch the MySql server:
  - In the terminal, run the command "$ mySql -uroot -p[YOUR-PASSWORD-HERE]", replacing [YOUR-PASSWORD-HERE] with your unique MySql password
* To Import the required database:
  - In the terminal, navigate to SillystringzFactory.Solution/Factory and run the command:
    - dotnet ef database update
* To Make Changes to the Database:
  - If you would like to change the database, make changes in the proper models files, then run the following commands in the terminal navigated to Factory.Solution/Factory:
    - "dotnet ef migrations add YourDescriptionHere"
    - "dotnet ef database update"
* To Restore, build, and run the project:
  - Navigate to the Factory.Solution/Factory folder in the command line or terminal
    - Run the command "$ dotnet restore" to restore the project dependencies
    - Run the command "$ dotnet build" to build and compile the project
    - Run the command "$ dotnet run" to build and compile the project
    - If the styling is not appearing in the browser, open http://localhost:5000 in an incognito browser

## Known Bugs

* none at this time

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Ben Dunham

## Support and contact details

* [Ben Dunham](github.com/bendunhampdx) 
* <bendunhampdx@gmail.com>