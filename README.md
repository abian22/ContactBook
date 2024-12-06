# Project Name - Contact Book

## Description
This is the backend for a Contact Book website. It allows users to create, read, update, and delete contacts, with all data stored in an SQL database. The frontend for this application can be found in the [ContactBookFront repository](https://github.com/abian22/ContactBookFront).

## Requirements  
To run this project, make sure you have the following installed:  
- **.NET SDK**
- **SQL Server Management Studio (SSMS)**: For managing the SQL Server database.  
  *(Note: You need a server named ".", or you'll need to update the server name in the `appsettings.json` file if using a different name.)*  
- **Visual Studio**  

## Setup

1. Clone the repository

2. Restore dependencies:  
    ```bash  
    dotnet restore  
    ```  

3. Add migrations (using the Package Manager Console in Visual Studio):  
    ```bash  
    Add-Migration InitDB  
    ```  

4. Build the project:  
    ```bash  
    dotnet build  
    ```  

5. Run the project:  
    ```bash  
    dotnet run  
    ```

6. (Optional) If you encounter any issues, ensure that the server name in `appsettings.json` is correct and matches your SQL Server setup.

