# Student Management System

## Tech Stack
- ASP.NET Core Web API
- SQL Server
- Entity Framework Core
- JWT Authentication

## Features
- CRUD Operations (Student)
- JWT Authentication (Login API)
- Secure APIs
- Swagger Testing

## How to Run
1. Clone the repository
2. Update database connection in appsettings.json
3. Run the project
4. Open Swagger: https://localhost:xxxx/swagger

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
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
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
- Token expires in 1 hour
- All Student APIs are secured using JWT
- Swagger is used for testing APIs
