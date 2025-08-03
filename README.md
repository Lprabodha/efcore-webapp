# Book Management Razor Pages Project

## Overview

This project is a simple Book Management web application built with ASP.NET Core Razor Pages (.NET 8, C# 12). It allows users to view, add, edit, and delete books, storing details such as name, author, publish date, and release date.

## Features

- List all books
- Add new books
- Edit existing books
- Delete books
- View book details

## Technologies

- ASP.NET Core Razor Pages
- C# 12
- .NET 8
- Entity Framework Core (if using a database)
- Bootstrap (for UI styling, if included)

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 or later

### Setup

1. Clone the repository:
2. Open the solution in Visual Studio.
3. Restore NuGet packages.
4. Build the project.

### Running the Application

- Press `F5` in Visual Studio to run the project.
- The app will open in your browser at `https://localhost:xxxx`.

## Project Structure

- `Models/Book.cs` – Book entity definition
- `Pages/Book/` – Razor Pages for book CRUD operations
- `Data/` – Database context (if applicable)
- `wwwroot/` – Static files

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License

[MIT](LICENSE)
