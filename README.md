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
- [Roadmap - Trello Board](https://trello.com/b/Exe1hjyr/modelcabinet)

## **Dependencies**
- Dotnet
- SQL Server
- Node.js
- Angular CLI
- THREE.js

## **Get Started**
- Download the repository
- Update the database
    - Ensure Dotnet EF tools are installed.
    ```
    dotnet tool install --global dotnet-ef
    ```
    - Deploy the database
    ```
    dotnet ef database update
    ```
- Run the App
```
dotnet run
```

## **Contributing**
To contribute to the project please create your own fork of the repository and submit your changes for review via a pull request.