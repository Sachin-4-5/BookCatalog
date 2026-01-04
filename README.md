## BookCatalog


### 📘 Overview
BookCatalog is a simple yet professionally structured CRUD-based web application developed using ASP.NET Core Razor Pages in .NET 8.
The application allows users to create, view, update, and delete book records using Entity Framework Core with a Code-First approach.
This project is designed to demonstrate modern Razor Pages concepts, clean project structure, and best practices followed in real-world enterprise applications.

---
<br />



### ✨ Features
✅ Entity Framework Core (Code-First) <br />
✅ Asynchronous database operations <br />
✅ Clean separation of concerns using Razor Pages <br />

---
<br />



### 🚀 Future Enhancements
✅ Authentication & Authorization (ASP.NET Core Identity) <br />
✅ Search and filter books <br />
✅ Pagination & sorting <br />
✅ Category/Author management <br />
✅ Audit fields (CreatedDate, ModifiedDate) <br />
✅ Unit testing with NUnit / xUnit <br />
✅ REST API integration (future Web API module) <br />
✅ Clean Architecture (Repository & Service layers) <br />

---
<br />



### 🎯 Key Learnings
✅ Understanding Razor Pages architecture <br />
✅ Difference between Web Forms vs Razor Pages <br />
✅ PageModel lifecycle (OnGet, OnPost) <br />
✅ Model binding & validation <br />
✅ Dependency Injection in ASP.NET Core <br />
✅ EF Core Code-First migrations <br />
✅ Asynchronous programming using async/await <br />
✅ Folder-based routing in Razor Pages <br />
✅ Configuration management using appsettings.json <br />

---
<br />



### 🛠️ Technologies Used
✅ ASP.NET Core  <br />
✅ Razor Pages <br />
✅ .NET 8 (LTS) <br />
✅ Entity Framework Core <br />
✅ MS SQL Server <br />
✅ Bootstrap <br />

---
<br />



### 🗂️ Project Structure
```
BookStore/
│
├── Pages/
│   ├── Book/
│   │   ├── Index.cshtml     
│   │   ├── Create.cshtml    
│   │   ├── Edit.cshtml      
│   │   ├── Delete.cshtml    
│   │   └── Detail.cshtml
│
├── Data/
│   └── AppDbContext.cs 
│
├── Models/
│   └── Books.cs           
│
├── Migrations/
├── Properties/
├── wwwroot/                 
├── Program.cs              
└── appsettings.json 

```

---
<br />



### 📷 UI Screenshots
![Landing Page](https://github.com/Sachin-4-5/Online_Learning_Management_System/blob/main/Output%20Images/Landing%20Page.png)

---
<br />



### ⚙️ How to Clone and Run the Project
```
✅ Prerequisites - .NET 8 SDK, SQL Server, Visual Studio / VS Code
✅ git clone https://github.com/your-username/BookCatalog.git
    cd BookCatalog
✅ Update Database
    Update Connection String
    dotnet ef database update
✅ Run the application - dotnet run
✅ Navigate to: https://localhost:xxxx/Book

```

---
<br />



### 🤝 Contribution
✅ Contributions are welcome! <br />
✅ Fork the repository <br />
✅ Create a feature branch <br />
✅ Commit your changes <br />
✅ Raise a Pull Request <br />

---
<br >



### 📜 License
This project is licensed under the MIT License.

---
<br />








