# ST10045251_CLDV_POE
This repository contains Part 2 of a POE project for KhumaloCraft.

## Overview
In this part of the project, we focus on designing and implementing a robust database schema to manage product information and user data for KhumaloCraft Emporium. The database is integrated with the existing web application to enhance functionality and scalability.

## Benefits of the Database Design
- **Scalability**: The schema is designed to accommodate future growth, allowing for the addition of new products, users, and categories without significant restructuring.
- **Data Integrity**: Foreign keys ensure referential integrity between tables, maintaining data consistency.
- **Performance**: Indexing primary keys improves query performance, essential for handling a growing number of transactions.

## How to Run the Project in Visual Studio:

1. **Clone the Repository**: Clone the KhumaloCraft repository to your local machine using Git: https://github.com/ST10045251/ST10045251_CLDV_POE.git

2. **Open Solution in Visual Studio**: Open the solution file (KhumaloCraft.sln) in Visual Studio.

3. **Build the Solution**: Build the solution by selecting Build > Build Solution from the menu, or by pressing Ctrl + Shift + B.

4. **Set Startup Project**: Right-click on the web project (typically named KhumaloCraft.Web) in the Solution Explorer, then select Set as StartUp Project.

5. **Configure Database Connection**: If the project uses a database, ensure that the database connection string is correctly configured in the appsettings.json file.

6. **Run the Application**: Press F5 or select Debug > Start Debugging from the menu to run the application. Alternatively, you can press Ctrl + F5 to run without debugging.

7. **View the Application**: Once the application has started, it will open in your default web browser. If not, navigate to https://localhost:port in your browser, where port is typically 5001 or 5000 for HTTPS or HTTP respectively.

8. **Explore the Application**: You can now explore the KhumaloCraft application and test its functionality.
