# BlazorApp Solution

This is a solution for the **BlazorApp** project which contains the following projects:

- **BlazorApp**: The Blazor WebAssembly application.
- **BlazorApp.API**: The backend API for the Blazor application.
- **BlazorApp.Entities**: The entities or models used across the application.

## Prerequisites
- Visual Studio 2022
- .Net 8
- MS SQL Server for the database

## Getting Started
1. Clone this repository
2. Open the solution file (BlazorAndWebAPI.sln) in Visual Studio.
3. Restore NuGet packages:In Visual Studio, right-click on the solution in Solution Explorer and click Restore NuGet Packages.
Build the solution:
4. In Visual Studio, click on Build > Build Solution.
5. Setting up the Database (EF 8 - Code First Approach)
  - The project uses Entity Framework 8 (EF 8) in a code-first approach with MS SQL.
  - Add the database connection string: In appsettings.json
  - Run Migrations to create the database and tables:
      - Add-Migration InitialCreate
      - Update-Database

  This will generate the database and tables based on your EF models.

After running the migration commands, the database will be created and ready to use.

Solution Structure
1. BlazorApp: This is the main Blazor WebAssembly app that communicates with the API.
2. BlazorApp.API: This project contains the backend API built using ASP.NET Core. It exposes RESTful endpoints consumed by the Blazor app.
3. BlazorApp.Entities: This project contains the data models/entities used in both the API and the Blazor client. The models are also used by Entity Framework for database creation.
