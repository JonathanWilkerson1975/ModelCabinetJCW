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


## **Get Started for VS Code**
Download the repository

## **Dependencies**
- Dotnet
- SQL Server
- Node.js
- Angular CLI
- Dotnet EF
- Angular-stl-model-viewer
    - Three.js is a dependency of Angular-stl-model-viewer and should auto install with Angular-stl-model-viewer.

## **Checking/Installing Dependencies**

- Open terminal and run and 
```
"dotnet --version"
- To check if dotnet is installed
If not then check in the extensions tab on the left nav and looked up dotnet. (dotnet by leo-labs)

"sc queryex type= service | find "MSSQL"
- For SQL server
If not install, navigate the extention tab on the right nav collumn. Then in the search bard look up mssql, then it should be "SQL Server (mssql)" and "SQL Database Projects".

"node --version"
- For node.js
If not installed, the installation can be installed here. 
https://nodejs.org/en

"ng --version"
- For Angular CLI
To install Angular CLI, find it in the extension tab in the left nav bar. Angular-cli

To check for Angular stl model viewer look in the package-lock.json in the root to check if it's installed.
- If not installed run
"npm install angular-stl-model-viewer"
in the terminal

For Three.js it is installedd along side angular-stl-model-viewer

"dotnet ef"
- If not installed run 
dotnet tool install --global dotnet-ef
```

## **Update the Database**
```
"dotnet restore"

-To ensure versions match up with the written code

After dotnet restore, cd into ModelCabinet.Server

"dotnet ef database update"

Pulls data for project from the repository.

Run the App

"dotnet run"

```

## **Get Started for Visual Studio 2022**
After pulling the repository, cd into the folder that has the package.json, which is the client folder.

Download the repository

Navigate to project-page.component.html:5:6 and comment out

 "$`\color{fcfc7f}\textsf{<app-viewport></app-viewport>}`$"

## **Dependencies**
- Dotnet
- SQL Server
- Node.js
- Angular CLI
- Dotnet EF
- Angular-stl-model-viewer
    - Three.js is a dependency of Angular-stl-model-viewer and should auto install with Angular-stl-model-viewer.

## **Checking/Installing Dependencies**

```
Press the windows key and launch Visual Studio Installer

Check
ASP.NET and web development
Azure development for dotnet SDKs
Node.js
.NET Multi-platform App UI development
.NET desktop development for SQL Server Express
Windows Application development for Nuget package manager

Launch the project, it will stop if Node.js is not installed
Node.js needs to be install seperately from it's website

https://nodejs.org/en

"dotnet ef"
- If not installed run 
dotnet tool install --global dotnet-ef
```

Navigate to project-page.component.html:5:6 and comment out $`\color{fcfc7f}\textsf{<app-viewport></app-viewport>}`$

Run "npm start" in the terminal to launch the project client

After project is able to run, update the database.

## **Update the Database**
```
"dotnet restore"

-To ensure versions match up with the written code

After dotnet restore, cd into ModelCabinet.Server

"dotnet ef database update"

Pulls data for project from the repository.

Run the App

"dotnet run"

```


### Linux:

$`\color{fcfc7f}\textsf{Sql Server Current isn't Natively Supported On Linux}`$


## **Contributing**
To contribute to the project please create your own fork of the repository and submit your changes for review via a pull request.

