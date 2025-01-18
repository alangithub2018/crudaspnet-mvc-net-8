# ASP.NET Core MVC + Entity Framework Core

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=.net&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/Entity%20Framework%20Core-512BD4?style=for-the-badge&logo=nuget&logoColor=white)

## 📖 Descripción

Este proyecto utiliza **ASP.NET Core MVC** junto con **Entity Framework Core** para desarrollar una aplicación web moderna y escalable. Con soporte para bases de datos relacionales, implementa migraciones y manejo eficiente de datos.

## 🚀 Requisitos

Antes de comenzar, asegúrate de tener instalado lo siguiente:

- **[.NET SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0)**
- **Visual Studio 2022** o **Visual Studio Code**
- **SQL Server** u otro proveedor compatible con Entity Framework Core

## 📂 Estructura del Proyecto

```
📦 Proyecto
├── 📁 Controllers
├── 📁 Models
├── 📁 Views
├── 📁 Data
│   ├── ApplicationDbContext.cs
├── 📄 appsettings.json
└── 📄 Program.cs
```

## 🔧 Configuración

### 1. Clona el repositorio

```bash
git clone https://github.com/tuusuario/tu-repositorio.git
cd tu-repositorio
```

### 2. Configura la conexión a la base de datos

Abre el archivo `appsettings.json` y modifica el valor de `ConnectionStrings`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=tu-servidor;Database=tu-base-datos;User Id=tu-usuario;Password=tu-contraseña;"
}
```

### 3. Restaura las dependencias

```bash
dotnet restore
```

### 4. Aplica las migraciones

Ejecuta los siguientes comandos de **Entity Framework Core** en la consola de administración de paquetes o terminal:

#### Crear una nueva migración
```bash
dotnet ef migrations add InitialCreate
```

#### Aplicar las migraciones a la base de datos
```bash
dotnet ef database update
```

#### Eliminar la última migración
```bash
dotnet ef migrations remove
```

## ✨ Tecnologías Utilizadas

- **ASP.NET Core MVC**: Framework de desarrollo web de Microsoft.
- **Entity Framework Core**: ORM moderno para .NET.
- **SQL Server**: Base de datos relacional (puedes cambiarlo por otro proveedor).
- **Bootstrap 5**: Para el diseño responsivo de la interfaz de usuario.

## 📸 Capturas

### Pantalla de Inicio

> ¡Agrega capturas aquí para que los usuarios vean cómo luce tu aplicación!

## 📜 Licencia

Este proyecto está bajo la licencia [MIT](LICENSE).

---

¡Contribuciones son bienvenidas! Si tienes alguna sugerencia o encuentras un problema, no dudes en abrir un **issue** o enviar un **pull request**.

