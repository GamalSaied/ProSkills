# E-Learning Website

Welcome to our e-learning platform! This website is designed to provide automated DXF services and includes a comprehensive leaderboard system to track user points earned through interactive exercises.

## Features

- **Leaderboard**: Keep track of your points and see how you rank against other users.
- **Automated DXF Services**: Access a variety of automated DXF services tailored to your learning needs.
- **Interactive Learning with Revit Structure**: Engage with Revit Structure exercises using WPF to enhance your skills.
- **User-Friendly Interface**: Easy navigation and user experience.

## Technologies Used

- **.NET MVC**: For the web application framework.
- **SQL Server**: For the database management.
- **Entity Framework Code First**: For the data access layer.
- **Generic Repository Pattern**: For a more modular and testable codebase.
- **WPF (Windows Presentation Foundation)**: For creating interactive Revit Structure exercises.

## Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)
- [Visual Studio](https://visualstudio.microsoft.com/) (or any other .NET compatible IDE)
- [Revit](https://www.autodesk.com/products/revit/overview) (for Revit Structure exercises)
- [WPF](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/) (for interactive exercises)

### Installation

1. Clone the repository
    ```sh
    git clone https://github.com/yourusername/your-repo-name.git
    ```
2. Navigate to the project directory
    ```sh
    cd your-repo-name
    ```
3. Open the solution file (`.sln`) in Visual Studio.

### Configuration

1. Update the connection string in `appsettings.json` to point to your SQL Server instance:
    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=your_server_name;Database=your_database_name;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
    ```
2. Apply migrations to create the database schema:
    ```sh
    dotnet ef database update
    ```

### Running the Application

To start the application, run:
```sh
dotnet run
