````markdown
# Lab 1: TodoAPI Minimal API

This project is a **Minimal API** built with **.NET 10** as part of Lab 1.

## Features
- CRUD operations for Todo items:
  - **GET** all todos
  - **GET** todo by ID
  - **POST** create todo
  - **PUT** update todo
  - **DELETE** remove todo
- In-Memory database using **Entity Framework Core**
- Swagger UI for testing endpoints

## How to Run
1. Clone the repo:
   ```bash
   git clone https://github.com/entuelias/ead--UGR-4241-15---lab-1-
````

2. Navigate to project:

   ```bash
   cd TodoApi
   ```
3. Restore dependencies and run:

   ```bash
   dotnet restore
   dotnet run
   ```
4. Open browser at `http://localhost:5066/swagger` to test endpoints.

## Tech Stack

* **.NET 10 Minimal API**
* **C#**
* **Entity Framework Core InMemory**
* **Swagger / NSwag**

