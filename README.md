# 🏢 Office Management REST API

A production-ready RESTful Web API built with **ASP.NET Core (.NET 8)** and **Entity Framework Core** for managing office Employees and Departments. Designed with clean architecture principles, full CRUD support, and interactive API documentation.

---

## 📋 Table of Contents

- [Features](#-features)
- [Tech Stack](#-tech-stack)
- [Project Structure](#-project-structure)
- [API Endpoints](#-api-endpoints)
- [Database Configuration](#-database-configuration)
- [Getting Started](#-getting-started)
- [Author](#-author)

---

## ✨ Features

- Full **CRUD operations** for Employees and Departments
- **Entity Framework Core** with code-first migrations
- **SQL Server** database integration
- Clean **RESTful API** architecture following REST conventions
- **Dependency Injection** with scoped `DbContext`
- Interactive API documentation via **OpenAPI / Scalar**

---

## 🛠 Tech Stack

| Layer             | Technology              |
|-------------------|-------------------------|
| Backend Framework | ASP.NET Core (.NET 8)   |
| ORM               | Entity Framework Core   |
| Database          | SQL Server              |
| API Documentation | OpenAPI / Scalar        |
| Language          | C#                      |

---

## 📁 Project Structure

```
officeRestAPI/
│
├── Controllers/
│   ├── EmployeeController.cs       # Employee CRUD endpoints
│   └── DepartmentController.cs     # Department CRUD endpoints
│
├── Models/
│   ├── Employee.cs                 # Employee entity model
│   ├── Department.cs               # Department entity model
│   └── OfficeContext.cs            # EF Core DbContext
│
└── Program.cs                      # App entry point & service registration
```

---

## 📡 API Endpoints

### 👤 Employee Endpoints

| Method   | Endpoint              | Description            |
|----------|-----------------------|------------------------|
| `GET`    | `/api/Employee`       | Retrieve all employees |
| `GET`    | `/api/Employee/{id}`  | Retrieve employee by ID|
| `POST`   | `/api/Employee`       | Create a new employee  |
| `PUT`    | `/api/Employee/{id}`  | Update an employee     |
| `DELETE` | `/api/Employee/{id}`  | Delete an employee     |

### 🏛 Department Endpoints

| Method   | Endpoint                | Description              |
|----------|-------------------------|--------------------------|
| `GET`    | `/api/Department`       | Retrieve all departments |
| `GET`    | `/api/Department/{id}`  | Retrieve department by ID|
| `POST`   | `/api/Department`       | Create a new department  |
| `PUT`    | `/api/Department/{id}`  | Update a department      |
| `DELETE` | `/api/Department/{id}`  | Delete a department      |

---

## 🗄 Database Configuration

Update the connection string in `appsettings.json` to match your SQL Server instance:

```json
"ConnectionStrings": {
  "dbcs": "Server=YOUR_SERVER;Database=OfficeDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

Then apply EF Core migrations to create the database schema:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (local or remote instance)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### Installation

1. **Clone the repository**

   ```bash
   git clone https://github.com/yourusername/OfficeManagementAPI.git
   cd OfficeManagementAPI
   ```

2. **Configure the database**

   Open `appsettings.json` and update the connection string with your SQL Server credentials.

3. **Apply database migrations**

   ```bash
   dotnet ef database update
   ```

4. **Run the application**

   ```bash
   dotnet run
   ```

5. **Explore the API**

   Navigate to `https://localhost:{port}/scalar` in your browser to access the interactive API documentation.

---

## 👨‍💻 Author

**Habib Ullah**  
Full Stack Developer — C# · .NET · REST API · SQL Server



---

## 📄 License

This project is licensed under the [MIT License](LICENSE).
