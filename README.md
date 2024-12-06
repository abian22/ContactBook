# Project Name
Contact Book
## Description
This is the backend for a Contact Book website. It allows users to create, read, update, and delete contacts, with all data stored in an SQL database. The frontend for this application can be found in the [ContactBookFront repository](link-to-frontend-repo).

## Requirements  
To run this project, make sure you have the following installed:  
- **.NET SDK**
- **SQL Server Management Studio (SSMS)**: For managing the SQL Server database.  
  *(Note: You need a server named ".", or you'll need to update the server name in the `appsettings.json` file if using a different name.)*  
- **Visual Studio**  

## Setup

1. Clone the repository:
2. 

3. Restore dependencies:  
    ```bash  
    dotnet restore  
    ```  

4. Add migrations (using the Package Manager Console in Visual Studio):  
    ```bash  
    Add-Migration InitDB  
    ```  

5. Build the project:  
    ```bash  
    dotnet build  
    ```  

6. Run the project:  
    ```bash  
    dotnet run  
    ```

7. (Optional) If you encounter any issues, ensure that the server name in `appsettings.json` is correct and matches your SQL Server setup.

