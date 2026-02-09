# Mechanic Shop Management System 🛠️🚗

A modern web-based platform built to supercharge daily operations for **automotive repair shops**!

## Overview ✨

The **Mechanic Shop Management System** helps workshops manage everything in one clean place:

- 👥 Customers & Vehicles
- 🔧 Repair Task Templates
- 📋 Work Orders & full lifecycle
- 🗓️ Smart Scheduling (technicians + bays)
- 👷 Labor Assignment
- 📊 Basic real-time visibility & stats

Say goodbye to paper chaos, double-bookings, and lost job status! 📅❌

## The Problem It Solves 🛠️💥

Most mechanic shops still struggle with:

- 📄 Paper records or messy spreadsheets
- ⏰ Manual scheduling → frequent double-bookings
- 👀 No real-time view of what's happening in the shop
- 😓 Hard to track who’s working on what

This system creates **one single source of truth** for the entire workshop.

## Goals 🎯

- 🌱 **Digitize** all workshop operations
- 🚫 Eliminate scheduling conflicts & double-bookings
- 👀 Give everyone clear visibility of job status
- 📈 Enable smart, data-driven decisions
- 🔄 Standardize repairs with reusable templates
- 😊 Boost efficiency + customer happiness

## User Roles 👤🔐

| Role              | Permissions                                                                 | Emoji |
|-------------------|-----------------------------------------------------------------------------|-------|
| **Manager** 👑    | Full access: customers, vehicles, tasks, orders, scheduling, reports        | 📊🛠️ |
| **Technician** 👷 | View & update **only their assigned** work orders (status: In Progress / Done) | 🔧✅ |

## Key Features 🔥

### 1. Customer & Vehicle Management 👨‍👩‍👧🚙
- Add / update / remove customers & vehicles
- VIN uniqueness enforced 🔢
- Protected delete (can't remove if active jobs exist) 🔒

### 2. Repair Task Catalog 📋🔧
- Create reusable task templates (name, description, est. cost & time)
- Attach required parts
- Safe delete — doesn't break existing work orders 🛡️

### 3. Work Order Management 📑
- Create orders → add tasks → assign tech & bay
- Lifecycle: **Scheduled → In Progress → Completed** or **Cancelled** 🔄
- Auto-cancel no-shows after 15 min ⏰🚫
- Technicians update their own jobs only

### 4. Smart Scheduling 🗓️✨
- Prevent double-booking of techs & bays
- Daily + per-technician views
- Drag-and-drop rescheduling (planned) 🖱️
- All changes happen in one safe place

### 5. Labor Management 👷‍♂️
- See who’s available
- Assign & reassign technicians safely
- No overlapping assignments allowed ✅

### 6. Dashboard & Quick Stats 📊
- Real-time counts: total / in progress / completed / cancelled
- Date filtering
- Clean overview of shop status at a glance 👀

### 7. Secure Login & Permissions 🔐
- Username + password
- Role-based access
- Session timeout
- HTTPS + secure storage

## Non-Functional Highlights ⚡

- ⚡ Pages load < 2 seconds
- 🚀 API < 500 ms
- 🏋️ Supports 10+ concurrent users
- 📱 Responsive (desktop + tablet)
- 💾 Daily backups
- 🕒 Available during business hours

## Out of Scope for Phase 1 🚫

- 📦 Parts inventory
- 💳 Payments
- ✉️ Email/SMS
- 🏬 Multi-location
- 📱 Mobile app
- 🌐 Customer portal

## Success Looks Like (6 months after launch) 🏆

- 📉 90% fewer scheduling conflicts
- 🎯 100% work order accuracy
- 🔥 >80% team adoption in first month
- ⏱️ Work order created in < 2 minutes
- 😄 Manager & tech satisfaction > 4/5

## Tech Stack Suggestions (2025+) 🖥️

- Frontend: React / Next.js / Vue
- Backend: Node.js + Express / FastAPI / Laravel
- Database: PostgreSQL (strongly recommended)
- Auth: JWT or secure sessions
- Deployment: Docker + Vercel / Railway / Render / AWS

## Contributing 🤝

We’re in the planning / early development phase!

1. Read the full PRD 📖
2. Open issues for ideas / questions 💬
3. Fork & PR when coding starts 🚀

---

Made with ❤️ + 🛠️ + 🚗  
Let's build the best shop management tool together!