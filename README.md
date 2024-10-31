# 🚚 TransConnect - Transport Management Application

## 📝 Project Overview

Welcome to **TransConnect**, a C# application designed to manage a road transport company. This application enables efficient management of employees, clients, and orders for TransConnect, a company specializing in goods delivery across France. The project leverages advanced object-oriented programming concepts to provide an intuitive interface and robust management of fleet vehicles and delivery operations.

## 🔑 Key Features

### 👥 Employee Management
- 🗂️ **Visual Organizational Chart**: Displays the full company org chart with clear hierarchical links between employees.
- ➕ **Hiring and Firing**: Add or remove employees while automatically updating the org chart.
- ✏️ **Profile Updates**: Modify employee details, including position, salary, and contact information.

### 🧑‍💼 Client Management
- 🆕 **Add, Edit, and Delete Clients**: Manage client information via the console or from a file.
- 📊 **Client Ranking**: Sort clients alphabetically, by city, or by total purchase amount to identify top clients.

### 📦 Order Management
- 📝 **Order Creation and Tracking**: Manage the lifecycle of orders, including creation, modification, and saving to a self-updating database.
- 💰 **Price Calculation**: Estimate delivery costs based on distance, vehicle type, and driver seniority.
- 🛣️ **Route Optimization**: Uses Dijkstra’s algorithm to determine the shortest route between delivery points, factoring in driver availability.

### 📊 Statistics and Reports
- 🚛 **Driver Performance Tracking**: Display the number of deliveries completed by each driver.
- 📅 **Order Statistics**: Provide reports on orders for a given time period, average prices, and client accounts.
- 📜 **Order History**: Allows viewing the order history for each client.

### 🚀 Advanced Features
- 🚗 **Vehicle Management**: Organize the fleet by vehicle type (cars, vans, trucks) and specific use (liquid transport, fragile goods, etc.).
- 📆 **Optimized Scheduling**: Team leaders can efficiently plan driver schedules and routes to maximize productivity.
- 💡 **Creative Module**: Suggestions to enhance transport operation management (choose 4 custom suggestions).

## ⚙️ Technologies Used

- **C#** for application logic and user interface.
- **Dijkstra’s Algorithm** for delivery route optimization.
- **Generic Collections** to manage dynamic lists of clients, employees, and orders.
- **Advanced Data Structures**: N-ary tree for the org chart, linked list for some collections.

## 📖 Usage Guide

1. **Installation**: Clone the repository and open the project in Visual Studio.
2. **Configuration**: Ensure .NET is installed, then run the solution.
3. **Navigation**: Use the main menu to access employee, client, and order management modules.

## 👥 Contributors

Project created by [Killian FOURNIER/Lucas LOPES].

## 🙏 Acknowledgments

As part of the Advanced C# course
