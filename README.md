# **Students Web Application**

Student CRUD application using .NET 6 MVC as the MVC framework and EF Core 6 as ORM.

## **To run**

1. Install the dotnet ef core CLI <br/>
`dotnet tool install --global dotnet-ef`

2. Open a terminal in the Infrastructure directory (i.e the directory where the DbContext file resides).

3. Add the migration <br/>
`dotnet ef migrations add InitialMigration --startup-project ../Students.Web/Students.Web.csproj`

4. Update the database <br/>
`dotnet ef database update --startup-project ../Students.Web/Students.Web.csproj`