# LaunchQ Take-Home Assignment

## Description

This is a simple Blazor WebAssembly application built for the LaunchQ take-home assignment.  
It fetches and displays a list of books by a selected author using the [OpenLibrary API](https://openlibrary.org/dev/docs/api/authors).

## Features

- Book listing by author (e.g., Stephen King)
- Clickable book titles leading to a detail view
- Clean, maintainable code with dependency injection
- API base URL managed via `appsettings.json`

## How to Run

1. Clone this repository
2. Open the solution in Visual Studio 2022 (or later)
3. Run the project with `F5` or using `dotnet run`

## Notes

- The author used in this example is **Stephen King**
- The project uses `HttpClient` and strongly typed models to consume OpenLibrary data
- The code is structured for clarity and follows standard .NET best practices
