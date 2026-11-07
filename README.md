# MechanicShop System

Welcome to the **MechanicShop System**! This project is a modern web application designed to streamline the operations of a mechanic workshop: manage customers and vehicles, schedule and relocate work orders by spot and time, track states, define repair tasks and labor, and handle invoicing (issue, fetch, PDF download, mark paid) with role-based access. 🚀

# Demo :
### https://drive.google.com/drive/folders/1ZucFrs5UYB3Rbrj4wAJ3b-SAyUF-rC4g?usp=sharing

## 🔐 Test Credentials

| Role    | Email          | Password |
|---------|----------------|----------|
| Manager | pm@localhost   |pm@localhost 

> Use **`pm@localhost`** to log in as a Manager and explore the full system features.

# ✨ Features

- **Comprehensive Workshop Management** — Manage work orders, customer data, and repair tasks efficiently.
- **Modern Web Interface** — A responsive and interactive frontend for a seamless user experience.
- **Robust Backend API** — A powerful ASP.NET Core API handling all business logic and data interactions.
- **Containerized Environment** — Easy setup and deployment using Docker and Docker Compose.
- **Real-time Updates** — Stay informed with live updates on work order statuses.
- **Advanced Monitoring & Logging** — Integrated tools for performance monitoring and centralized logging.
- **Secure Authentication** — JWT-based authentication for secure access.

## 🏗️ Project Structure

The project is organized into several logical layers within the `src` directory, promoting a clean architecture and separation of concerns:

| Project | Description |
|---------|-------------|
| `src/MechanicShop.Api` | The heart of the backend — an ASP.NET Core Web API that exposes endpoints for frontend interaction and handles core business processes. |
| `src/MechanicShop.Client` | The interactive frontend application (Blazor WebAssembly), providing a rich user interface. |
| `src/MechanicShop.Application` | Contains the application's business logic and use cases, orchestrating operations between the domain and infrastructure layers. |
| `src/MechanicShop.Domain` | Defines the core business entities, value objects, and domain rules — the essence of the MechanicShop business. |
| `src/MechanicShop.Contracts` | Holds shared data transfer objects (DTOs) and interfaces used for communication between different layers and services. |
| `src/MechanicShop.Infrastructure` | Manages external concerns such as database interactions, identity management, external services, and real-time communication. |

### Infrastructure Layer Details

The `src/MechanicShop.Infrastructure` layer abstracts external technical concerns from the core business logic. It provides implementations for interfaces defined in the Application and Domain layers:

- **Data Access** — Entity Framework Core (`AppDbContext`) and interceptors (e.g. `AuditableEntityInterceptor`) for automated auditing.
- **Identity & Authentication** — ASP.NET Core Identity + JWT Bearer tokens, with authorization policies such as `ManagerOnly` and `SelfScopedWorkOrderAccess`.
- **Real-time Communication** — SignalR integration (e.g. `SignalRWorkOrderNotifier`) to push instant updates to clients.
- **External Services** — Concrete implementations like `InvoicePdfGenerator` and `NotificationService`.
- **Background Jobs** — Services such as `OverdueBookingCleanupService` for periodic tasks.
- **Caching** — `HybridCache` for performance optimization.

This separation keeps the core business logic clean, testable, and flexible.

## 🚀 Technologies Used

| Technology | Purpose |
|------------|---------|
| **.NET 9.0** | Latest Microsoft development platform |
| **ASP.NET Core** | High-performance, cross-platform web APIs |
| **Blazor WebAssembly** | Interactive client-side web UIs with C# |
| **Docker / Docker Compose** | Containerization and multi-container orchestration |
| **SQL Server** | Relational database for persistent storage |
| **Entity Framework Core** | ORM for database interactions |
| **JWT Bearer Authentication** | Secure token-based authentication |
| **SignalR** | Real-time web functionality |
| **Serilog** | Flexible structured logging |
| **Seq** | Centralized logging server |
| **Prometheus** | Metrics collection and monitoring |
| **Grafana** | Metrics visualization and dashboards |

## 🚀 Getting Started

### Prerequisites

- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/install/)

### Run the Application

From the project root:

```bash
docker-compose up --build
