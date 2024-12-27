# Customer Web API

A RESTful WebAPI built with C# and ASP.NET Core for managing Customers Data.
---

### Installing Entity-Framework tools
```bash
dotnet tool install --global dotnet-ef
```

### Packages
Run the script below to install the project dependencies:

```bash
dotnet add package Microsoft.EntityFrameworkCore -v 8.0 # Add Microsoft EF Core library
dotnet add package Microsoft.EntityFrameworkCore.Sqlite -v 8.0 # Add Sqlite support
dotnet add package Microsoft.EntityFrameworkCore.Design -v 8.0 # Add Database Migration support
dotnet add package Swashbuckle.AspnetCore # Add Swagger support
```

### Database migration
Run the following for database migrations and update

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### Launch the web API
```bash
dotnet run
```
