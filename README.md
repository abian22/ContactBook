# Project Name

## Description
Backend of a Contact Book website, the frontend is ContactBookFront repo.

## Requirements  
To run this project, ensure you have the following installed:  
- **.NET SDK** (version 7.0+ or higher)  
- **SQL Server Management Studio (SSMS)**: Used to manage the SQL Server database.  
  *(Note: You must have a server named ".", or you'll need to update the name in the `appsettings.json` file if using a different one.)*  
- **Visual Studio**  

## Setup

1. Clone the repository:

2. Restore dependencies:  
    ```bash  
    dotnet restore  
    ```  

3. Add migrations (use the Package Manager Console in Visual Studio):  
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

6. (Optional) If you encounter issues, make sure to check the configuration in `appsettings.json` and ensure your database server name is set correctly.

