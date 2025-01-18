# ASP.NET Core MVC + Entity Framework Core

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework%20Core-512BD4?style=for-the-badge&logo=nuget&logoColor=white)

## 📖 Description

This project leverages **ASP.NET Core MVC** along with **Entity Framework Core** to develop a modern and scalable web application. With support for relational databases, it implements migrations and efficient data handling.

## 🚀 Requirements

Before starting, ensure you have the following installed:

- **[.NET SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0)**
- **Visual Studio 2022** or **Visual Studio Code**
- **SQL Server** or another provider compatible with Entity Framework Core

## 📂 Project Structure

```
📦 Project
├── 📁 Controllers
├── 📁 Models
├── 📁 Views
├── 📁 Data
│   ├── ApplicationDbContext.cs
├── 📄 appsettings.json
└── 📄 Program.cs
```

## 🔧 Setup

### 1. Clone the repository

```bash
git clone https://github.com/yourusername/your-repository.git
cd your-repository
```

### 2. Configure the database connection

Open the `appsettings.json` file and modify the `ConnectionStrings` value:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=your-server;Database=your-database;User Id=your-username;Password=your-password;"
}
```

### 3. Restore dependencies

```bash
dotnet restore
```

### 4. Apply migrations

Run the following **Entity Framework Core** commands in the Package Manager Console or terminal:

#### Create a new migration
```bash
dotnet ef migrations add InitialCreate
```

#### Apply migrations to the database
```bash
dotnet ef database update
```

#### Remove the last migration
```bash
dotnet ef migrations remove
```

## ✨ Technologies Used

- **ASP.NET Core MVC**: Microsoft’s web development framework.
- **Entity Framework Core**: Modern ORM for .NET.
- **SQL Server**: Relational database (can be replaced with another provider).
- **Bootstrap 5**: For responsive UI design.

## 📸 Screenshots

### Home Page

> Add screenshots here to showcase your application!

## 📜 License

This project is licensed under the [MIT](LICENSE).

---

Contributions are welcome! If you have any suggestions or encounter any issues, feel free to open an **issue** or submit a **pull request**.

