# 🏢 Job Shop – Online Job Portal

**Job Shop** is a dynamic **ASP.NET MVC** web application designed to bridge the gap between **job providers** (employers/companies) and **job seekers**.
The platform allows employers to post job opportunities and job seekers to search, apply, and upload their resumes seamlessly.

---

## 📜 Table of Contents

* [Introduction](#-introduction)
* [Problem Statement](#-problem-statement)
* [Proposed Solution](#-proposed-solution)
* [Features](#-features)
* [Modules](#-modules)
* [Tech Stack](#-tech-stack)
* [System Requirements](#-system-requirements)
* [Database Schema](#-database-schema)
* [Setup Instructions](#-setup-instructions)
* [Usage](#-usage)
* [Testing](#-testing)
* [Future Enhancements](#-future-enhancements)
* [Screenshots](#-screenshots)
* [License](#-license)
* [Acknowledgments](#-acknowledgments)

---

## 🌟 Introduction

**Job Shop** connects **talent** with **opportunity** through an intuitive online portal.
It provides a single platform where:

* Employers can post job openings and manage applicants.
* Job seekers can find, apply for, and track job opportunities.

The system also features a **blogging module** and **feedback system** to engage the user community.

---

## ❗ Problem Statement

The traditional hiring process is **time-consuming** and **inefficient**:

* Employers rely on outdated methods such as newspaper ads or manual application collection.
* Job seekers face difficulties finding relevant job opportunities.

Existing online job portals have **limited features**, dull interfaces, and are often **hard to navigate**.

---

## 💡 Proposed Solution

The **Job Shop** platform simplifies hiring by:

* Allowing **job seekers** to search, apply, and upload resumes digitally.
* Enabling **employers** to manage job postings, download resumes, and communicate with applicants.
* Providing **filters** to search jobs by **category**, **city**, or **salary range**.
* Offering a **blog section** for career guidance and company updates.

---

## ✨ Features

* **User Roles**:

  * Admin
  * Employer/Company
  * Job Seeker
* **Job Search Filters**: Search by title, city, or salary.
* **Dynamic Resume Uploads**: Upload multiple formats (PDF, DOC, TXT).
* **Job Application Management**:

  * Employers can view, accept, or reject applications.
  * Download candidate resumes directly.
* **Blogging Module**: Post and categorize blogs.
* **Feedback System**: Collect user feedback and inquiries.
* **Secure Authentication**: Role-based login system.

---

## 🧩 Modules

### **1. Admin**

* Manage users, employers, jobs, resumes, blogs, and feedback.
* Notify users about job updates.

### **2. Employer / Job Provider**

* Post, update, and delete job listings.
* Download resumes and manage applications.
* Communicate with job seekers via the portal.

### **3. Job Seeker**

* Search and apply for jobs.
* Upload and manage resumes.
* Download job application forms.
* View blogs and leave feedback.

---

## 🛠 Tech Stack

| **Category**        | **Technology**                                    |
| ------------------- | ------------------------------------------------- |
| **Frontend**        | HTML5, CSS3, Bootstrap, JavaScript, jQuery, Razor |
| **Backend**         | ASP.NET MVC 5                                     |
| **Database**        | Microsoft SQL Server 2017                         |
| **Tools**           | Visual Studio 2017, Notepad++                     |
| **Version Control** | Git & GitHub                                      |

---

## 💻 System Requirements

| **Component** | **Minimum Specs**           |
| ------------- | --------------------------- |
| **Processor** | Intel Core i5               |
| **RAM**       | 4 GB                        |
| **Storage**   | 500 MB                      |
| **OS**        | Windows 7/10/11             |
| **IDE**       | Visual Studio 2017 or above |

---

## 🗃 Database Schema

The project uses **Entity Framework Code-First Approach**.
Main entities:

* **User** (Admin, Employer, Job Seeker)
* **Job**
* **Job Category**
* **Resume**
* **Blog**
* **Feedback**

---

## ⚙️ Setup Instructions

1. **Clone Repository**

   ```bash
   git clone https://github.com/yourusername/job-shop.git
   cd job-shop
