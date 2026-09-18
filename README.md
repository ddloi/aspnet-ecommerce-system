# ShopMart — E-Commerce Web Application

<p align="center">
  <img src="https://img.shields.io/badge/ASP.NET_MVC-5-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET_Framework-4.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/SQL_Server-2019-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" />
  <img src="https://img.shields.io/badge/Entity_Framework-6.5-purple?style=for-the-badge" />
  <img src="https://img.shields.io/badge/Bootstrap-3.x-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white" />
</p>

<p align="center">
  A full-featured e-commerce web application built with ASP.NET MVC 5 and Entity Framework 6, featuring customer shopping, admin management, and order processing.
</p>

---

## Features

### Customer Portal
- Browse products by category
- Product detail pages
- Shopping cart management (add, update, remove items)
- Checkout and order placement
- User registration and login
- Order history and tracking

### Admin Dashboard
- **Product Management** — Add, edit, delete products with images
- **Category Management** — Organize products by category
- **Order Management** — View and update order status
- **Customer Management** — View and manage customer accounts

---

## Tech Stack

| Layer | Technology |
|---|---|
| **Frontend** | ASP.NET MVC Razor Views, Bootstrap 3, jQuery |
| **Backend** | ASP.NET MVC 5, C# |
| **ORM** | Entity Framework 6 (Database First) |
| **Database** | Microsoft SQL Server |
| **Authentication** | Custom session-based authentication |
| **Framework** | .NET Framework 4.7.2 |

---

## Project Structure

```
ShopOnline/
├── Controllers/
│   ├── TrangChuController.cs    # Home / Product listing
│   ├── DetailController.cs      # Product detail
│   ├── CartController.cs        # Shopping cart & checkout
│   ├── UserController.cs        # Login & Registration
│   ├── AdminController.cs       # Admin dashboard
│   ├── ProductsAdminController.cs   # Product CRUD
│   ├── CategoryAdminController.cs   # Category CRUD
│   ├── OrderAdminController.cs      # Order management
│   └── CustomerAdminController.cs   # Customer management
├── Models/
│   ├── Product.cs               # Product entity
│   ├── Category.cs              # Category entity
│   ├── Customer.cs              # Customer entity
│   ├── OrderPro.cs              # Order entity
│   ├── OrderDetail.cs           # Order line items
│   ├── Cart.cs                  # Shopping cart model
│   └── DBEntity.edmx            # Entity Framework model
├── Views/                       # Razor view templates
├── Content/                     # CSS, images
├── Scripts/                     # JavaScript, jQuery, Bootstrap
└── Database/
    └── QLBH2025.sql             # Database schema & seed data
```

---

## Getting Started

### Prerequisites

- **Visual Studio 2019 / 2022** (with ASP.NET workload installed)
- **SQL Server 2017+** or **SQL Server Express**
- **SQL Server Management Studio (SSMS)** (optional but recommended)
- **.NET Framework 4.7.2**

### 1. Clone the Repository

```bash
git clone https://github.com/DataZenLab/shopmart.git
cd shopmart
```

### 2. Database Setup

1. Open **SQL Server Management Studio (SSMS)**
2. Connect to your SQL Server instance
3. Open and execute the script: `Database/QLBH2025.sql`
4. This will create all tables and insert sample data

### 3. Configure Connection String

Open `Web.config` and update the connection string:

```xml
<connectionStrings>
  <add name="DBEntities"
       connectionString="metadata=res://*/Models.DBEntity.csdl|...;
                         provider=System.Data.SqlClient;
                         provider connection string=&quot;
                         Data Source=YOUR_SERVER_NAME;
                         Initial Catalog=QLBH2025;
                         Integrated Security=True&quot;"
       providerName="System.Data.EntityClient" />
</connectionStrings>
```

Replace `YOUR_SERVER_NAME` with your SQL Server instance name (e.g., `.\SQLEXPRESS`).

### 4. Build & Run

1. Open `ShopOnline.sln` in Visual Studio
2. Right-click the solution → **Restore NuGet Packages**
3. Press `F5` to build and run in debug mode
4. The app will open in your browser at `http://localhost:PORT`

---

## Default Admin Credentials

```
Username: admin
Password: (check AdminUser table or seed data in SQL script)
```

---

## Database Schema

```
Category (CategoryID, CategoryName)
    |
    +-- Product (ProductID, ProductName, Price, Image, Quantity, CategoryID)
                    |
                    +-- OrderDetail (OrderDetailID, OrderID, ProductID, Quantity, Price)
                                        |
Customer (CustomerID, Name, Email, Phone, Address, Password)
    |
    +-- OrderPro (OrderID, CustomerID, OrderDate, TotalAmount, Status)
                    |
                    +-- OrderDetail (...)
```

---

## Screenshots

> _Run the application locally to see the full UI. Admin panel accessible at `/Admin/Index`._

---

## Known Limitations

- No JWT authentication (session-based only)
- No payment gateway integration (demo checkout only)
- Images stored as file paths (no cloud storage)

---

## Author

**DataZenLab**
- GitHub: [@DataZenLab](https://github.com/DataZenLab)

---

## License

This project is licensed under the **MIT License**.
