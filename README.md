# MyPersonalProjects

# 🐄 Farm Management System

A simple C# console-based application for managing a farm with role-based access (Admin and Farmer). The system allows users to log in, manage animal records, and persist data using file storage. Built using core object-oriented programming principles.

---

## 🚀 Features

- 🔐 **Role-Based Login System**
  - Admin: Can manage farmer accounts and monitor data.
  - Farmer: Can add, remove, and view animals.

- 🐑 **Animal Management**
  - Add new animals (Cattle, Sheep, etc.)
  - Remove animals
  - View all registered animals

- 🧱 **Object-Oriented Architecture**
  - Abstract classes for `Animal`
  - Interfaces to define common behaviors
  - Encapsulation and inheritance for clean structure

- 💾 **Persistent Storage**
  - Save and load animal data to/from text files
  - Data is preserved between sessions

- 🛡️ **Input Validation & Exception Handling**
  - Validates user inputs
  - Handles common runtime errors gracefully

---

## 🛠 Technologies Used

- C# (.NET Console Application)
- Object-Oriented Programming (OOP)
- File I/O
- Exception Handling

---

## 📂 Project Structure

```plaintext
FarmManagementSystem/
├── Program.cs
├── Login.cs
├── Animal.cs
├── Sheep.cs
├── Admin.cs
├── Farmer.cs
├── IAnimal.cs
|-- IAccount.cs
├── files/
│   ├── animals.txt
│   └── users.txt
