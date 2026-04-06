# Student Management System

## Overview
This is a Student Management System built using ASP.NET Core Web API. It provides CRUD operations for managing student data and secures all endpoints using JWT authentication.

## Tech Stack
- ASP.NET Core Web API
- SQL Server
- Entity Framework Core
- JWT Authentication
- Swagger

## Features
- CRUD Operations (Create, Read, Update, Delete)
- JWT Authentication (Login API)
- Secure APIs using authorization
- Global Exception Handling
- Logging (Serilog)
- Swagger API Testing
- Layered Architecture (Controller, Service, Repository)

## How to Run

1. Clone the repository
git clone https://github.com/AnuragBagul11/StudentManagementSystem.git

2. Open the project in Visual Studio

3. Update database connection in appsettings.json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;"
}

4. Run database migrations (Package Manager Console)
Add-Migration InitialCreate
Update-Database

5. Run the project

6. Open Swagger
https://localhost:xxxx/swagger

---

## JWT Authentication Steps

1. Login API Call  
Endpoint: POST /api/Auth/login  

Enter credentials:  
Username: admin  
Password: 1234  

Click Execute  

---

2. Copy Token  
You will get a response like:

{
  "token": "your_jwt_token_here"
}

Copy the token value  

---

3. Authorize in Swagger  
Click the Authorize button (top right)  

Enter token in this format:  
Bearer YOUR_TOKEN  

Click Authorize and then Close  

---

4. Access Secure APIs  

You can now access the following endpoints:

GET /api/Student  
GET /api/Student/{id}  
POST /api/Student  
PUT /api/Student  
DELETE /api/Student/{id}  

Without token: Unauthorized (401)  
With token: Success  

---

## Notes
- JWT token expires in 1 hour
- All Student APIs are secured
- Database is created using Entity Framework migrations
- Swagger is used for API testing

## Author
Anurag Bagul
