# 🛒 ShopMart — ASP.NET MVC 5 E-Commerce Web System

<p align="center">
  <img src="https://img.shields.io/badge/ASP.NET_MVC-5-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/.NET_Framework-4.7.2-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/SQL_Server-2019-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" />
  <img src="https://img.shields.io/badge/Entity_Framework-6.5-purple?style=for-the-badge" />
  <img src="https://img.shields.io/badge/Developer-ddloi-58A6FF?style=for-the-badge&logo=github&logoColor=white" />
</p>

<p align="center">
  A production-ready e-commerce web application engineered with ASP.NET MVC 5, Entity Framework 6, and Microsoft SQL Server (3NF Relational Schema), developed by <strong>Đặng Đại Lợi (<a href="https://github.com/ddloi">@ddloi</a>)</strong>.
</p>

---

## 📸 Application Screenshot & UI Showcase

<p align="center">
  <img src="pictures/Screenshot%20(41).png" alt="ShopMart Application Preview" width="95%" />
  <br/>
  <em>Figure 1: E-Commerce Storefront — Product catalog, navigation filters, shopping cart, and transaction checkout.</em>
</p>

---

## 🌟 Key Features

### 🛍️ Customer Storefront
- **Dynamic Catalog:** Browse products categorized by taxonomy with real-time stock availability.
- **Product Details:** Rich product description, multi-image view, and pricing calculation.
- **Cart & Checkout:** Session-managed shopping cart (Add, Update, Remove), promotional calculations, and checkout.
- **Customer Account:** User registration, secure session authentication, and order history tracking.

### 🛡️ Administration Management Portal
- **Product Management:** Full CRUD operations for products with image upload handling.
- **Category Management:** Taxonomy tree management and display ordering.
- **Order Processing:** Real-time order status tracking (Pending, Processing, Completed, Cancelled).
- **Customer Registry:** Central customer account management.

---

## 🗄️ Relational Database Architecture

- **Schema Normalization:** Strict 3NF relational model designed in Microsoft SQL Server (`QLBH2025.sql`).
- **ORM:** Entity Framework 6 (Database-First) mapping relational entities with foreign-key referential integrity.
- **Transaction Safety:** ACID compliance across checkout and stock deduction.

```text
Categories (1) ───< Products (N) ───< OrderDetail (N) >─── (1) Orders ───> (1) Customers
```

---

## 🚀 Getting Started

### Prerequisites
- **Visual Studio 2019 / 2022** (ASP.NET & web development workload)
- **Microsoft SQL Server 2019+** / SQL Server Express
- **SQL Server Management Studio (SSMS)**
- **.NET Framework 4.7.2**

### 1. Clone the Repository
```bash
git clone https://github.com/ddloi/aspnet-ecommerce-system.git
cd aspnet-ecommerce-system
```

### 2. Database Setup
1. Open **SQL Server Management Studio (SSMS)**.
2. Open and execute the database script at `Database/QLBH2025.sql`.
3. Verify database `QLBH2025` is created with tables and sample seed records.

### 3. Configure Connection String
Open `Web.config` and verify connection string matches your local SQL Server instance:
```xml
<connectionStrings>
  <add name="QLBHEntities" connectionString="metadata=res://*/Models.DBEntity.csdl|res://*/Models.DBEntity.ssdl|res://*/Models.DBEntity.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.;initial catalog=QLBH2025;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
</connectionStrings>
```

### 4. Run Application
Press **F5** in Visual Studio or run with IIS Express.

---

## 👨‍💻 Author & Contact

- **Developer:** Đặng Đại Lợi
- **GitHub:** [@ddloi](https://github.com/ddloi)
- **Email:** [dangdailoi732006@gmail.com](mailto:dangdailoi732006@gmail.com)
- **LinkedIn:** [ddloi](https://www.linkedin.com/in/ddloi)
- **Institution:** HUFLIT (Ho Chi Minh City University of Foreign Languages & Information Technology)
