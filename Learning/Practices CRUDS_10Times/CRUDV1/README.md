# CRUDV1 User & Product Management App

## Overview

This is a basic CRUD (Create, Read, Update, Delete) application for managing user and product records. The app is built with Windows Forms using .NET Framework 4.7.2. It connects to a database named `CRUDV1` to store and manage user and product information.

> **Note:** This project is for learning purposes only.

## Features

- **User Management**
  - **Create**: Add new user records to the database.
  - **Read**: View existing user records.
  - **Update**: Edit and update user details.
  - **Delete**: Remove user records from the database.

- **Product Management**
  - **Create**: Add new product records to the database.
  - **Read**: View existing product records.
  - **Update**: Edit and update product details.
  - **Delete**: Remove product records from the database.

## Technologies Used

- .NET Framework 4.7.2
- Windows Forms (WinForms)
- SQL Server (Database: `CRUDV1`)

## Setup & Installation

1. **Clone the repository** to your local machine.
2. **Open the solution** in Visual Studio 2022.
3. **Restore NuGet packages** if required.
4. **Configure the database connection string** in the app settings to point to your SQL Server instance and the `CRUDV1` database.
5. **Build and run** the application.

## Usage

- Launch the app from Visual Studio or the executable.
- Use the provided interface to add, view, update, or delete user and product records.
- All changes are reflected in the `CRUDV1` database.

## Database Roadmap

1. **Design Tables**
   - Create a `Users` table for storing user information (e.g., UserID, Name, Email, etc.).
   - Create a `Products` table for storing product information (e.g., ProductID, Name, Description, Price, etc.).

2. **Establish Relationships**
   - If products are associated with users (e.g., each product has an owner), add a foreign key in the `Products` table referencing the `Users` table.

3. **Implement CRUD Operations**
   - Use SQL queries or an ORM to perform Create, Read, Update, and Delete operations for both tables.

4. **Integrate with Application**
   - Connect the WinForms UI to the database using ADO.NET or Entity Framework.
   - Ensure forms for both users and products interact with the correct tables.

5. **Testing**
   - Test all CRUD operations for both users and products to ensure data integrity and correct functionality.

## License

This project is for educational and demonstration purposes only.