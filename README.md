# ModelCabinet
ModelCabinet is a 3d printing management tool for managing 3d printer files in a web-facing database. Planned features include:
- Model storage
- Model visualization without download
- Model project management
- Model categorization and tagging
- Model searching
- Model support generation (long-term)
- Model merging (long-term)

## **Resources and Information**
- Documentation
- Issue Tracker
- [Roadmap - Github Projects](https://github.com/orgs/CCAppDevs/projects/2)

## **Dependencies**
- Dotnet
- SQL Server
- Node.js
- Angular CLI
- THREE.js

## **Get Started**
- Download the repository
- Install Dependencies
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Tools
```
- Update the database
    - Ensure Dotnet EF tools are installed.
    ```
    dotnet tool install --global dotnet-ef
    ```
    - Deploy the database
    ```
    cd ModelCabinet.Server
    dotnet ef database update
    ```
- Run the App
```
dotnet run
```

## **Contributing**
To contribute to the project please create your own fork of the repository and submit your changes for review via a pull request.
