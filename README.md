# StaffMaster - Employee Management System

## Overview
**StaffMaster** is a comprehensive employee management system developed in C# using Visual Studio 2022. It streamlines the management of employee records, tracks attendance, manages roles and permissions, and generates detailed reports. The application is backed by an SQL database for data storage and retrieval.

## Features
- **Employee Management:** Create, read, update, and delete (CRUD) employee records.
- **Attendance Tracking:** Log employee attendance and leave details.
- **Role & Permissions:** Assign roles with specific permissions to control access levels.
- **Report Generation:** Generate reports for employee data, attendance, and performance.
- **Search & Filter:** Efficient searching and filtering options to easily find records.
  
## Prerequisites
To run this project, you will need the following:

- **Visual Studio 2022**: The IDE used for development. You can download it [here](https://visualstudio.microsoft.com/vs/).
- **.NET Framework**: The application is built on .NET (version specific to your project).
- **SQL Server**: Used for database management. Install [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) and ensure it’s running.
- **SQL Server Management Studio (SSMS)**: Optional but recommended for managing your database.

## Setup Instructions

### 1. Clone the Repository

### 2. Open in Visual Studio 2022
- Launch **Visual Studio 2022** on your system.
- From the top menu, go to `File -> Open -> Project/Solution`.
- Navigate to the cloned repository directory and select the `StaffMaster.sln` solution file.
- Once the project is opened, restore NuGet packages if prompted by Visual Studio.

### 3. Configure the SQL Database
- Open **SQL Server Management Studio (SSMS)**.
- Create a new database named `StaffMaster` or another name of your choice.
- In the `/DatabaseScripts/` folder of the cloned repository, find the SQL scripts to set up your database.
    - Execute the **schema.sql** file to create tables.
    - Optionally, execute the **seed.sql** file to populate the database with initial data (e.g., test employees, roles).
- Open the `appsettings.json` (or `web.config` if it's a desktop application) in Visual Studio and locate the connection string section.

Example connection string in `appsettings.json`:
```json
"ConnectionStrings": {
  "StaffMasterDB": "Server=your_server_name;Database=StaffMaster;User Id=your_user_id;Password=your_password;"
}

```
### 3. Configure the SQL Database
- Open **SQL Server Management Studio (SSMS)**.
- Create a new database named `StaffMaster` (or another name of your choice).
- Navigate to the `/DatabaseScripts/` folder in the cloned repository and find the following SQL scripts:
    - **schema.sql**: Contains the schema for creating the necessary tables.
    - **seed.sql** (optional): Contains sample data for testing purposes.
- Run the **schema.sql** script in SSMS to create the database tables.
- (Optional) Run the **seed.sql** script to populate the database with initial test data.
- In Visual Studio, open the `appsettings.json` (or `web.config` for desktop applications) and locate the connection string.

Example connection string in `appsettings.json`:
```json
"ConnectionStrings": {
  "StaffMasterDB": "Server=your_server_name;Database=StaffMaster;User Id=your_user_id;Password=your_password;"
}
```


Readme.MD WIP
