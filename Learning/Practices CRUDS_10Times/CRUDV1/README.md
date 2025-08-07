# CRUDV1 User Management App

## Overview

This is a basic CRUD (Create, Read, Update, Delete) application for managing user records. The app is built with Windows Forms using .NET Framework 4.7.2. It connects to a database named `CRUDV1` to store and manage user information.

> **Note:** This project is for learning purposes only.

## Features

- **Create**: Add new user records to the database.
- **Read**: View existing user records.
- **Update**: Edit and update user details.
- **Delete**: Remove user records from the database.

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
- Use the provided interface to add, view, update, or delete user records.
- All changes are reflected in the `CRUDV1` database.

## Database

- The app expects a SQL Server database named `CRUDV1`.
- Ensure the required tables for user management exist (e.g., `Users` table with appropriate columns).

## License

This project is for educational and demonstration purposes only.