# Factory Manager

### By Genesis Scott

A web application that allows managers to update their engineer details and add engineers to machines and machines to engineers.

### Technologies Used
- .NET 6.0
- ASP.NET Core MVC
- Entity Framework Core
- Bootstrap
- C#
- HTML
- CSS

### Setup/Installation Requirements
1. Ensure .NET SDK and runtime are installed on your machine.
2. Clone this repository to your local machine.

```bash
$ git clone https://github.com/witherScript/Factory-EFC-Many-to-Many
```
3. Navigate to the HairSalon.Solution directory in your terminal.
4. Touch a file in the HairSalon.Solution directory called appsettings.json add the following code, replacing the uid and pwd values with your own username and password for MySQL.

```bash
$ touch appsettings.json
```

```csharp
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=Genesis_Scott;uid=[YOUR-USERNAME];pwd=[YOUR-MYSQL-PASSWORD];"
  }
}
```

5. Run the command ```dotnet restore``` to install necessary packages.
6. Run the command ```dotnet build``` to compile the application.
7. Run ```dotnet ef database update``` to replicate current schema migrations
8. Run ```dotnet run``` to start the server and application.
9. Visit localhost:5000 in your browser to access the Employee Manage application.
10. Follow on-screen prompts to manage employee details.
11. If you come across any difficulties or wish to give feedback, don't hesitate to get in touch or raise an issue on the repository.

## Known Bugs
- Server restart completely manual, Ctrl+C 
## License
If you have queries, feedback, or are interested in contributing to the codebase, feel free to get in touch.

Single point of contact: genesis@evolve-self.org
