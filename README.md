# 🫀 Organ Donation Management System

A **desktop-based CRUD application** developed using **C# (.NET WinForms)** and **Microsoft SQL Server**. This system is designed to manage organ donation records efficiently, including donor details, organ information, blood groups, and hospital data.

This project was developed as an **academic / DBMS project** and demonstrates complete **Create, Read, Update, and Delete (CRUD)** operations with a structured database backend.

---

## 🚀 Features

* ✅ Add new organ donation records
* 🔍 View and search existing records
* ✏️ Update donor and organ details
* 🗑️ Delete donation records with confirmation
* 📊 Display data using DataGridView
* 🔐 Uses **stored procedures** for database operations
* ⚙️ Input validation and error handling

---

## 🛠️ Technologies Used

* **Frontend:** C# (.NET WinForms)
* **Backend:** Microsoft SQL Server
* **Database Access:** ADO.NET
* **IDE:** Visual Studio

---

## 📂 Database Design

**Database Name:** `OrganBloodDonation`

### Main Table: `Organs`

| Column Name   | Data Type | Description               |
| ------------- | --------- | ------------------------- |
| OrganID       | INT (PK)  | Unique organ record ID    |
| DonorName     | NVARCHAR  | Name of the donor         |
| OrganName     | NVARCHAR  | Name of the donated organ |
| BloodGroup    | NVARCHAR  | Donor blood group         |
| DonorAge      | INT       | Age of the donor          |
| DonorHospital | NVARCHAR  | Hospital name             |
| HospitalPhone | NVARCHAR  | Hospital contact number   |

---

## ⚙️ Stored Procedures Used

* `UpdateOrgan` – Updates an existing organ donation record
* `DeleteOrgan` – Deletes a record using OrganID
* (Optional) Insert and Search procedures

Stored procedures improve:

* Security
* Performance
* Maintainability

---

## 🧩 CRUD Functionality

| Operation | Description                           |
| --------- | ------------------------------------- |
| Create    | Add new donor and organ records       |
| Read      | View and search records from database |
| Update    | Modify existing donation records      |
| Delete    | Remove records with confirmation      |

---

## ▶️ How to Run the Project

1. Clone the repository:

```bash
git clone https://github.com/your-username/Organ-Donation-Management-System.git
```

2. Open the project in **Visual Studio**

3. Restore the SQL Server database:

* Create database `OrganBloodDonation`
* Run the provided SQL script or create tables manually

4. Update the connection string in code:

```csharp
Server=.\\SQLEXPRESS;Database=OrganBloodDonation;Trusted_Connection=True;
```

5. Run the application

---

## 📸 Screenshots

*Add screenshots of your application UI here (optional but recommended)*

---

## 🎓 Academic Purpose

This project fulfills the requirements of:

* Database Management Systems (DBMS)
* C# Desktop Application Development
* CRUD-based application design

---

## 🔮 Future Enhancements

* User authentication & roles
* Advanced filtering and reports
* Export data to PDF / Excel
* Cloud database integration

---

## 👨‍💻 Author

**Owais**
University Student | C# Developer

---

## 📜 License

This project is for **educational purposes only**.

---

⭐ If you find this project helpful, feel free to star the repository!
