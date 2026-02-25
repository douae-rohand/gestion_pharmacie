# Pharmacy Management 💊

A complete pharmacy management system developed in C# WinForms, allowing for the management of medication stocks, clients, orders, and suppliers with SQL Server integration.

## 🌟 Key Features

### 📦 Stock Management (Medications)
- **Complete Catalog**: Tracking of medications with references, descriptions, photos, and categories.
- **Stock Tracking**: Real-time visualization of available quantities.
- **Stock Alerts**: Automatic alert system when stock reaches a critical threshold.
- **Expiration Management**: Rigorous tracking of expiration dates with proximity indicators.
- **Price Management**: Control of purchase and sale prices with automatic margin calculation.

### 👥 Client Management
- **Client Database**: Recording of personal information (ID - CIN, Phone, Address).
- **Purchase History**: Detailed tracking of orders placed by each client.
- **Client Statistics**: Analysis of the most active clients and calculation of revenue per client.

### 🧾 Order Management
- **Order Taking**: Intuitive interface for adding products to an order.
- **Order Lines**: Detailed management of items, quantities, and unit prices.
- **Automatic Update**: Automatic stock decrement when an order is validated.
- **Order Status**: Tracking of stages (In Progress, Validated, Delivered, Cancelled).
- **Invoicing**: Automatic generation of invoices for each order.

### 🏢 Supplier Management
- **Supplier Directory**: Management of supplier contact information.
- **Supply Relations**: Tracking of which supplier provides which medication with the associated purchase price.

### 📊 Dashboard & Statistics
- Overview of the pharmacy's performance.
- Statistics on total stock, expiration alerts, and turnover.

## 🛠️ Technologies Used

- **Language**: C#
- **Interface**: Windows Forms (WinForms)
- **Database**: Microsoft SQL Server
- **Data Access**: ADO.NET (Microsoft.Data.SqlClient)
- **Framework**: .NET Framework / .NET Core

## 📂 Project Structure

```text
gestion_pharmacie/
├── Medicament.cs       # Business logic and DB access for medications
├── Client.cs           # Business logic and DB access for clients
├── Commande.cs         # Order and order line management
├── Fournisseur.cs      # Supplier management
├── Program.cs          # Application entry point
├── Forms/              # All user interfaces (Designer.cs, .cs, .resx)
│   ├── FormAjouterMedicament.cs
│   ├── FormAjouterCommandes.cs
│   ├── FormListeCommandes.cs
│   └── ...
└── Resources/          # Images and icons
```

## 🚀 Installation and Configuration

### Prerequisites
- Visual Studio 2022 or later.
- SQL Server LocalDB or SQL Server Express.
- .NET SDK corresponding to the project.

### Database Configuration
1. Create a database named `Pharmacie` in your SQL Server instance.
2. Run the SQL script (if available) or let the application create the tables (check the initialization logic).
3. **Important**: Modify the connection string in the `Medicament.cs`, `Client.cs`, and `Commande.cs` files so that it points to your server:
   ```csharp
   private static string connectionString = "data source=YOUR_SERVER;initial catalog=Pharmacie;integrated security=SSPI;...";
   ```

### Running
1. Open the `gestion_pharmacie.sln` file in Visual Studio.
2. Restore NuGet packages (if necessary).
3. Compile and launch the application (F5).

## 📄 License
This project is open-sourced software licensed under the [MIT license](https://opensource.org/licenses/MIT).

---
*Created with ❤️ for simplified pharmaceutical management.*
