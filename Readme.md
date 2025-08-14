# ContactlyAPI

A RESTful API built with ASP.NET Core for managing contacts.

## Technologies Used

- .NET 9.0
- Entity Framework Core (In-Memory Database)
- AutoMapper 14.0
- Scalar API Explorer

## Prerequisites

- .NET 9.0 SDK or later
- Visual Studio 2022 or Visual Studio Code

## Getting Started

1. Clone the repository:
```bash
git clone https://github.com/Joshuapavan/ContactlyAPI.git
cd ContactlyAPI
```

2. Build the project:
```bash
dotnet build
```

3. Run the application:
```bash
dotnet run
```

4. Access the API:
- API Base URL: `http://localhost:5053`
- API Documentation: `http://localhost:5053/scalar`

## API Documentation

The API documentation is available through Scalar API Explorer when running the application. 
Visit `http://localhost:5053/scalar` to:
- View API endpoints
- Test API operations
- View request/response schemas
- Execute API calls directly from the browser

## Project Structure

- `Program.cs` - Application entry point and configuration
- `Data/` - Database context and entity configurations
- `Controllers/` - API endpoints and request handling
- `Models/` - Data models and DTOs

## Dependencies

- `AutoMapper (14.0.0)` - Object-to-object mapping
- `Microsoft.AspNetCore.OpenApi (9.0.6)` - OpenAPI support
- `Microsoft.EntityFrameworkCore.InMemory (9.0.8)` - In-memory database
- `Scalar.AspNetCore (2.6.9)` - API documentation and testing
- `Scalar.AspNetCore.Microsoft (2.6.9)` - Microsoft integration for Scalar
- `Scalar.AspNetCore.Swashbuckle (2.6.9)` - Swagger/OpenAPI implementation

## Development

The project uses an in-memory database for development purposes. The database is initialized on startup and data persists only during runtime.

## License

This project is currently not licensed.