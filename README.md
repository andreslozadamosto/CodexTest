# CodexTest

Este repositorio contiene un ejemplo minimal de una solucion .NET 8 que utiliza **.NET Aspire**. La solucion incluye un proyecto de API, un proyecto de pruebas y un proyecto de AppHost para orquestar la aplicacion.

## Estructura
- `BasicApi` – API minimal que expone el endpoint `/api/test` devolviendo "hola mundo".
- `BasicApi.Tests` – proyecto de pruebas basado en xUnit.
- `BasicApi.AppHost` – host que usa `Aspire.Hosting` para registrar el API.

## Uso

No se incluye el runtime de .NET en este contenedor, pero en un entorno local con .NET 8 instalado se puede ejecutar:

```bash
# Restaurar paquetes
 dotnet restore CodexTest.sln

# Ejecutar la API
 dotnet run --project BasicApi

# Ejecutar las pruebas
 dotnet test BasicApi.Tests
```
