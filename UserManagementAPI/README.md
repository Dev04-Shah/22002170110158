# UserManagementAPI

ASP.NET Core Web API project for user management with full CRUD, validation, and logging middleware.

## Features

- CRUD endpoints for users (`GET`, `POST`, `PUT`, `DELETE`)
- Model validation using data annotations
- Custom request/response logging middleware
- In-memory user storage via service layer
- Swagger UI for API testing

## Project Structure

```
UserManagementAPI/
├── Controllers/
│   └── UsersController.cs
├── Middleware/
│   └── LoggingMiddleware.cs
├── Models/
│   └── User.cs
├── Services/
│   └── UserService.cs
├── Program.cs
└── UserManagementAPI.csproj
```

## API Endpoints

- `GET /api/users` - Get all users
- `GET /api/users/{id}` - Get user by ID
- `POST /api/users` - Create a user
- `PUT /api/users/{id}` - Update a user
- `DELETE /api/users/{id}` - Delete a user

## Example Request Body

```json
{
  "name": "Alice Johnson",
  "email": "alice@example.com",
  "age": 24
}
```

## Validation Rules

- `Name` is required and minimum 3 characters
- `Email` is required and must be a valid email
- `Age` must be between 18 and 100

## Middleware

`LoggingMiddleware` logs incoming request method/path and outgoing response status code.

## Copilot Usage Statement

GitHub Copilot was used to assist in debugging, improving code structure, and generating optimized API logic for controllers, validation patterns, and service methods.

## Run Locally

1. Install .NET 8 SDK
2. Run:
   - `dotnet restore`
   - `dotnet run`
3. Open Swagger:
   - `http://localhost:5140/swagger`
   - or `https://localhost:7152/swagger`

## 25-Point Checklist

- GitHub repository created
- CRUD endpoints implemented
- Copilot usage documented
- Validation implemented
- Middleware implemented
