# ShopEasy

A product catalog REST API built with ASP.NET Core Web API and Entity Framework Core.

## Tech Stack
- C# and ASP.NET Core Web API (.NET 8)
- Entity Framework Core (Code First, migrations)
- SQLite
- Visual Studio 2022

## Features
- Full CRUD for products (create, read, update, delete)
- Async/await database operations
- Dependency injection (`AppDbContext` injected into the controller)
- Proper HTTP status codes (200, 201, 204, 400, 404)
-    - MVC web interface with Razor Views (product list and add-product form)

## API Endpoints
| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | /api/products | Get all products |
| GET | /api/products/{id} | Get a product by id |
| POST | /api/products | Create a product |
| PUT | /api/products/{id} | Update a product |
| DELETE | /api/products/{id} | Delete a product |

## Run Locally
1. Clone the repository
2. Open `ShopEasy.slnx` in Visual Studio
3. In the Package Manager Console, run `Update-Database`
4. Press F5 and open `https://localhost:7045/api/products`

## Roadmap
- JWT authentication
- Cart and orders
