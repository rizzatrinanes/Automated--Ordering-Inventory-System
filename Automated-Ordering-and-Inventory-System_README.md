# Automated Ordering & Inventory System

A collection of Visual Basic desktop applications developed for ordering
and inventory-related tasks.

The repository currently contains two related projects:

-   `InventoryManagementSystem`
-   `cafeorderingsystem`

Both projects are Windows desktop applications built with Visual Basic /
Windows Forms.

## Inventory Management System

The inventory application uses MySQL for storing inventory and
transaction data.

### Features

-   User login
-   Customer management
-   Supplier management
-   Item management
-   Stock-in transactions
-   Stock-out transactions
-   Stock return handling
-   Inventory tracking
-   User management
-   Transaction records
-   Inventory reports
-   Crystal Reports integration
-   Automatic transaction numbering
-   Stock-level highlighting

### Technologies

-   Visual Basic .NET
-   Windows Forms
-   .NET Framework 4.8
-   MySQL
-   MySQL Connector/NET
-   Crystal Reports

### Database

The application connects to a local MySQL database named:

``` text
db_inventory
```

The current source expects a local MySQL server using:

``` text
server=localhost
user=root
password=
database=db_inventory
```

The database connection is defined in:

``` text
inventorymanagementsystem/InventoryManagementSystem/include/connection.vb
```

A matching MySQL database/schema is required for the application to
work.

### Reports

The application uses Crystal Reports for reports such as:

-   Item list
-   Inventory
-   Stock-in
-   Stock-out / sold list
-   Stock returns
-   Customer list

Report templates are stored under the application's `bin/Debug/reports`
directory in the current project files.

## Cafe Ordering System

The repository also contains a separate Windows Forms application for a
cafe ordering workflow.

### Features

-   User login
-   Product selection
-   Coffee ordering
-   Iced latte ordering
-   Dessert selection
-   Frappe selection
-   Best-seller / special-offer section
-   Order processing
-   Payment selection
-   Cash payment handling
-   Product size and quantity selection

The project contains product images and other UI resources inside its
`Resources` folder.

### Database

The cafe ordering project currently uses Microsoft Access database files
through OLE DB.

The project configuration references:

``` text
Microsoft.ACE.OLEDB.12.0
```

The database files are stored with the project and are referenced
through the application's configuration.

## Repository Structure

``` text
Automated-Ordering-Inventory-System/
├── inventorymanagementsystem/
│   └── InventoryManagementSystem/
│       ├── forms/
│       ├── include/
│       ├── Resources/
│       ├── Form1.vb
│       ├── LoginForm1.vb
│       ├── App.config
│       └── InventoryManagementSystem.vbproj
│
└── cafeorderingsystem/
    └── cafeorderingsystem/
        ├── Resources/
        ├── *.vb
        ├── *.resx
        ├── app.config
        └── cafeorderingsystem.vbproj
```

## Requirements

For the inventory application:

-   Windows
-   Visual Studio with Visual Basic / Windows Forms support
-   .NET Framework 4.8
-   MySQL Server
-   MySQL Connector/NET
-   SAP Crystal Reports for Visual Studio

For the cafe ordering application:

-   Windows
-   Visual Studio with Visual Basic / Windows Forms support
-   .NET Framework compatible with the project
-   Microsoft Access Database Engine / ACE OLE DB provider

## Running the Projects

Open the appropriate `.sln` or `.vbproj` file in Visual Studio.

For the inventory application, make sure the MySQL server is running and
the `db_inventory` database and required tables are available before
starting the application.

For the cafe ordering application, make sure the Access database file
and ACE OLE DB provider are available on the machine.

## Notes

The uploaded project contains generated `bin`, `obj`, and executable
files. For a clean GitHub repository, these generated build files should
normally be excluded with a `.gitignore`.

The inventory source also contains a local database connection string,
while the cafe project contains local database file references. These
should be adjusted for the environment where the project is being run.

## Project Status

Academic / Desktop Application Projects
