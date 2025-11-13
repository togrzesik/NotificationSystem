# 🔔 Notification System – Observer Pattern in C#

## 📋 Project Overview
This project demonstrates the **Observer Design Pattern** implemented in **C# (.NET 8)**.  
It simulates a simple **notification service**, where a user receives messages through multiple channels:
📧 **Email**, 📱 **SMS**, and 🔔 **Push Notifications**.

The main goal is to showcase **Object-Oriented Programming (OOP)**, **SOLID principles**, and **loose coupling** between components using design patterns.

---

## 🧠 Design Pattern: Observer

**Definition:**  
The **Observer Pattern** allows multiple objects (observers) to be notified of state changes in another object (the subject).  
In this project, the `NotificationService` acts as the **Subject**, while different notification channels (Email, SMS, Push) act as **Observers**.

**Key Benefits:**
- Loose coupling between components  
- Easy extensibility – new notification channels can be added without modifying existing code  
- Promotes the **Open/Closed** and **Dependency Inversion** principles from SOLID

## Example Output
🔔 Notification System Demo

📧 [Email] To: tomasz@example.com — Your order has been shipped! 

📱 [SMS] To: +48123123123 — Your order has been shipped! 📦

🔔 [Push] To: Tomasz Grzesik — Your order has been shipped! 📦

❌ Unsubscribing SMS notifications...

📧 [Email] To: tomasz@example.com — Thank you for your purchase!

🔔 [Push] To: Tomasz Grzesik — Thank you for your purchase!
