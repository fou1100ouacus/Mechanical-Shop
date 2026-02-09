# Mechanic Shop Management System

A web-based workshop operations platform designed to streamline daily operations for automotive repair shops.

## Overview

The **Mechanic Shop Management System** helps repair shops manage:

- Customers and vehicles
- Repair task templates
- Work orders and their lifecycle
- Scheduling (technicians & service bays)
- Labor assignment
- Basic operational visibility

The system eliminates paper-based processes, prevents scheduling conflicts and double-bookings, standardizes repair procedures, and provides real-time visibility into workshop status.

## Problem It Solves

Most mechanic shops still rely on:

- Paper records or spreadsheets
- Manual scheduling leading to double-bookings
- No centralized view of work in progress
- Difficulty tracking job status and technician assignments

This system provides a single source of truth for workshop management.

## Goals

- Digitize all workshop operations
- Eliminate scheduling conflicts & double-bookings
- Improve visibility of work order status
- Enable data-driven decisions with real-time metrics
- Standardize repairs using reusable task templates
- Increase efficiency and customer satisfaction

## User Roles

| Role              | Permissions                                                                 |
|-------------------|-----------------------------------------------------------------------------|
| **Manager**       | Full access: customers, vehicles, tasks, work orders, scheduling, reports   |
| **Technician**    | Limited access: view & update status of their assigned work orders only     |

## Key Features

### 1. Customer & Vehicle Management
- Create/update/delete customers (with contact info)
- Add/update/remove vehicles (make, model, year, VIN)
- VIN uniqueness enforced
- Cannot delete customer/vehicle with active work orders

### 2. Repair Task Catalog
- Create reusable repair task templates (name, description, est. cost, est. duration)
- Attach required parts to templates
- Templates are shared across multiple work orders
- Deleting a template does **not** affect existing work orders

### 3. Work Order Management
- Create work orders for vehicles
- Add multiple repair tasks from catalog
- Assign technician and service bay
- Full lifecycle: **Scheduled → In Progress → Completed** or **Cancelled**
- Technicians can only update status of their own assigned orders
- Auto-cancellation of no-shows (15 min after scheduled time)

### 4. Scheduling
- Schedule work orders with date, time, technician, and service bay
- Prevent overlapping bookings (technician & bay)
- Daily & technician-specific schedule views
- Drag-and-drop rescheduling (planned UI feature)
- All scheduling changes must happen on the Schedule page

### 5. Labor Management
- View all technicians and their availability
- Assign/reassign technicians to work orders
- Double-booking prevention enforced

### 6. Dashboard & Reporting
- Real-time overview of work orders (total, in progress, completed, cancelled)
- Filter by date range
- Basic statistics (future: revenue, productivity, customer history)

### 7. Authentication & Security
- Username/password login
- Role-based access control
- Session timeout after inactivity
- HTTPS, secure password storage, rate limiting on login attempts

## Non-Functional Requirements

- Page load < 2 seconds
- API responses < 500 ms
- Support ≥ 10 concurrent users
- Responsive design (desktop + tablet)
- Daily backups
- Available during business hours (6 AM – 8 PM)

## Out of Scope (Phase 1)

- Parts inventory & stock management
- Payment processing
- Email/SMS notifications
- Multi-shop support
- Mobile app
- Customer portal
- Third-party integrations

## Success Metrics (6 months post-launch)

- ≥ 90% reduction in scheduling conflicts
- 100% work order tracking accuracy
- > 80% user adoption in first month
- Average work order creation time < 2 minutes
- ≥ 30% reduction in no-show rate
- Manager & technician satisfaction > 4/5

## Tech Stack (Suggested)

- **Backend**: Node.js / Express, Python (FastAPI/Django), or similar
- **Frontend**: React / Vue / Angular
- **Database**: PostgreSQL (recommended) or MySQL
- **API**: RESTful
- **Authentication**: JWT or session-based
- **Deployment**: Docker + modern cloud (Vercel, Railway, Render, AWS, etc.)

## Contributing

This project is currently in the planning/requirements phase.

1. Review the full PRD
2. Open an issue to discuss features or improvements
3. Fork & create PRs for code contributions once development begins

## License

[MIT License](LICENSE) (or choose appropriate license)

---

Built with clarity and structure based on the official Product Requirements Document.