  Project Description: Learning Management System (LMS) - User Management
Overview
The Learning Management System (LMS) is a comprehensive platform designed to manage and track educational activities. This project focuses on implementing a user management system using C# and Entity Framework with SQL Server. The core functionality includes CRUD (Create, Read, Update, Delete) operations for user management, allowing administrators to handle user accounts efficiently.

Features
User Creation:

Allows for the addition of new users to the LMS.
Users are prompted to enter their first name, last name, email, password, and role.
Passwords are securely hashed before storage using the BCrypt library.
User Retrieval:

Provides functionality to list all users in the system.
Displays user details including ID, full name, email, and role.
User Update:

Facilitates the modification of existing user details.
Users can update their first name, last name, email, password, and role.
Only fields that are modified will be updated in the database.
User Deletion:

(Not included in the initial code but can be added) Allows for the removal of user accounts from the system.
Console-Based Interface:

Provides a simple text-based menu to interact with the system.
Users can choose operations such as creating a new user, reading user details, updating user information, or exiting the application.
Technical Details
Programming Language: C#
Database: SQL Server
ORM Framework: Entity Framework
Password Hashing: BCrypt for secure password storage
Development Environment: Visual Studio
Setup and Installation
Clone the Repository:

Clone the project repository from the version control system (e.g., GitHub).
Install Dependencies:

Open the project in Visual Studio.
Install the required NuGet packages, including BCrypt.Net-Next for password hashing.
Database Configuration:

Ensure SQL Server is running and configure the connection string in the LMSEntities class to point to your database.
Run the Application:

Build and run the application within Visual Studio.
Use the console-based interface to interact with the user management system.
Future Enhancements
User Deletion: Add functionality to remove users from the system.
GUI Interface: Develop a graphical user interface (GUI) for a more user-friendly experience.
Advanced Features: Implement additional features such as role-based access control, user activity tracking, and integration with other LMS modules.
