# User Registration API

## Descripción

El **User Registration API** es una aplicación desarrollada en **C#** utilizando **ASP.NET Core** que permite registrar usuarios con información detallada, incluyendo nombre, teléfono, dirección y referencias geográficas como país, departamento y municipio. La aplicación utiliza una base de datos **PostgreSQL** para almacenar la información y emplea **Stored Procedures** para la interacción con la base de datos. Además, se han implementado patrones de diseño para mejorar la mantenibilidad y escalabilidad del código.

---

## Tecnologías Utilizadas

- **Lenguaje de Programación**: C#
- **Framework**: ASP.NET Core
- **Base de Datos**: PostgreSQL
- **ORM**: Dapper
- **Validación de Datos**: FluentValidation
- **Patrones de Diseño**: Repository, Service
- **Documentación de API**: Swagger UI
- **Herramientas de Desarrollo**: Visual Studio Code, pgAdmin, Postman

---

## Patrones de Diseño Implementados

### 1. **Patrón Repository**

**Descripción**: El patrón Repository se utiliza para abstraer el acceso a los datos y separar la lógica de la aplicación de los detalles de la persistencia de datos. Permite que la lógica de negocio interactúe con una interfaz de repositorio en lugar de con la base de datos directamente.

**Implementación en el Proyecto**:
- **Interfaces**:
  - `IUserRepository`: Define métodos para interactuar con la tabla `users`.
- **Clases Concretas**:
  - `UserRepository`: Implementa `IUserRepository` utilizando Dapper para ejecutar Stored Procedures.

### 2. **Patrón Service**

**Descripción**: El patrón Service encapsula la lógica de negocio de la aplicación. Actúa como una capa intermedia entre los controladores y los repositorios, manejando las operaciones complejas y las validaciones.

**Implementación en el Proyecto**:
- **Interfaces**:
  - `IUserService`: Define métodos para registrar usuarios.
- **Clases Concretas**:
  - `UserService`: Implementa `IUserService` y utiliza `IUserRepository` para interactuar con la base de datos. También incluye validaciones adicionales para asegurar la integridad de los datos.

### 3. **Middleware de Manejo de Errores**

**Descripción**: Un middleware personalizado para capturar y manejar excepciones de manera centralizada, proporcionando respuestas de error consistentes y claras a los clientes de la API.

**Implementación en el Proyecto**:
- **Clases**:
  - `ErrorHandlerMiddleware`: Captura excepciones y devuelve respuestas JSON apropiadas según el tipo de error.

---

## Prerrequisitos

Antes de comenzar, asegúrate de tener instalado lo siguiente en tu máquina:

- **.NET SDK**: [Descargar .NET SDK](https://dotnet.microsoft.com/download)
- **PostgreSQL**: [Descargar PostgreSQL](https://www.postgresql.org/download/)
- **Visual Studio Code**: [Descargar VS Code](https://code.visualstudio.com/)
- **Extensiones de VS Code**:
  - **C# Extension**: Proporciona soporte para desarrollo en C#.
  - **SQLTools** (opcional): Para interactuar con PostgreSQL directamente desde VS Code.
- **Herramientas Adicionales**:
  - **pgAdmin**: Herramienta gráfica para gestionar PostgreSQL.
  - **Postman**: Para probar los endpoints de la API.

---
**Tener en cuenta**
Se debe crear una base de datos con el nombre de **UserRegistrationDB** y ejecutar los scripts adjuntos al .zip de este prueba

## Probar la API

Para probar la API, se debe ejecutar el proyecto en Visual Studio Code o en la terminal con el comando `dotnet run` desde la carpeta del proyecto

Ver en postman o usar la herramienta de Swagger UI para probar los endpoints http://localhost:5069/swagger/index.html
