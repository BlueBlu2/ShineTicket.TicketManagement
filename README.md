# 🎟️ ShineTicket.TicketManagement – Event Ticket Reservation System

ShineTicket is a backend-focused **event ticket reservation system** built with **ASP.NET Core** following **Clean Architecture** and **Domain-Driven Design (DDD)** principles.

The project demonstrates how to design a scalable, maintainable, and testable system for managing events, tickets, and reservations using real-world enterprise patterns.

---

## 📌 Overview

ShineTicket allows users to:
- Browse available events
- Reserve tickets with availability validation
- Manage reservations and orders
- Enforce business rules at the domain level

The system is designed with a strong separation of concerns, making it easy to extend, test, and adapt to new requirements.

---

## ✨ Features

- Event management (CRUD operations)
- Ticket reservation with capacity checks
- Reservation and order lifecycle handling
- Domain-driven business rules
- RESTful API endpoints
- Clean Architecture layering
- Fully testable business logic
- Ready for future extensions (payments, authentication, notifications)

---

## 🏗️ Architecture

ShineTicket follows **Clean Architecture**, ensuring that the core business logic is independent of frameworks, databases, and external services.

### Layers

├── Domain
│ ├── Entities
│ ├── ValueObjects
│ └── Business Rules
│
├── Application
│ ├── Use Cases
│ ├── Commands & Queries (CQRS)
│ ├── DTOs
│ └── Interfaces
│
├── Infrastructure
│ ├── Persistence (EF Core)
│ ├── Repositories
│ └── External Services
│
├── API
│ ├── Controllers
│ ├── Request/Response Models
│ └── Dependency Injection
│
└── Tests
├── Unit Tests
└── Integration Tests


### Key Principles

- Dependency Rule enforced (outer layers depend on inner layers)
- Business logic isolated in the Domain layer
- Use-case driven Application layer
- Infrastructure details kept replaceable

---

## 🛠️ Tech Stack

- **ASP.NET Core**
- **Entity Framework Core**
- **Clean Architecture**
- **CQRS pattern**
- **xUnit** for testing

---

## 🚀 Getting Started

### Prerequisites

- .NET SDK (latest LTS recommended)
- SQL Server or compatible database
- Visual Studio / Rider / VS Code

