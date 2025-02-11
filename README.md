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
- Ensure dependenies are install
```
Open terminal and run

dotnet --version
sc queryex type= service | find "MSSQL"
node --version
ng --version
For Three.js you can look in ModelCabinet.client package-lock.json to check for if it's installed.
```
- Ensure Dotnet EF tools are installed.
-- by running 
---dotnet ef
---- A unicorn should pop up if you have it installed(Scroll up).
``
if not run installed
-dotnet tool install --global dotnet-ef
``

Update the database
```
dotnet restore
--To ensure versions match up with the written code

After dotnet restore, run
```
-dotnet ef database update
---Pulls data for project from the repository.

- Run the App
```
--dotnet run
```

## **Contributing**
To contribute to the project please create your own fork of the repository and submit your changes for review via a pull request.

