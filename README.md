## Technologies

* .NET Core 3.1
* ASP .NET Core 3.1
* Entity Framework Core 3.1
* Angular 10
* MediatR
* AutoMapper
* FluentValidation
* NUnit, FluentAssertions, Moq & Respawn

## Getting Started

1. Install the latest [.NET Core SDK](https://dotnet.microsoft.com/download)
2. Install the latest [Node.js LTS](https://nodejs.org/en/)


### Database Migrations

To use `dotnet-ef` for your migrations please add the following flags to your command (values assume you are executing from repository root)

* `--project src/Infrastructure` (optional if in this folder)
* `--startup-project src/WebUI`
* `--output-dir Persistence/Migrations`

For example, to add a new migration from the root folder:

 `dotnet ef migrations add "SampleMigration" --project src\Infrastructure --startup-project src\WebUI --output-dir Persistence\Migrations`

## Overview

### Domain

This will contain all entities, enums, exceptions, interfaces, types and logic specific to the domain layer.

### Application

This layer contains all application logic. It is dependent on the domain layer, but has no dependencies on any other layer or project. This layer defines interfaces that are implemented by outside layers. For example, if the application need to access a notification service, a new interface would be added to application and an implementation would be created within infrastructure.

### Infrastructure

This layer contains classes for accessing external resources such as file systems, web services, smtp, and so on. These classes should be based on interfaces defined within the application layer.
