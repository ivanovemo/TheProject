# TheProject

Welcome to **TheProject**, an innovative online course platform designed to streamline the learning experience for students while offering administrators a robust set of tools to create, manage, and deliver educational content.

## Features

- **Course Management**: Admins can add new courses, ensuring that the platform stays up-to-date with the latest educational trends and subject matters.
- **Instructor Assignment**: Easily assign instructors to courses, allowing for a tailored teaching approach for each subject.
- **Lecture Integration**: Enhance courses with comprehensive lectures, supporting a wide range of multimedia content to enrich the learning experience.
- **Role-Based Access Control**: With predefined roles for `user` and `admin`, manage the platform and its content securely and efficiently.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

Before you begin, ensure you have the following installed:
- Git
- .NET SDK 8.0
- .NET CLI (If needed)
```
dotnet tool install --global dotnet-ef
```
- An SQL Server instance for the database

### Installation

1. **Clone the repository**

```bash
git clone https://github.com/ivanovemo/TheProject.git
```

2. **Configure the Database Connection**

Navigate to the appsettings.json file and modify the connection string to match your database configuration:

```bash
"ConnectionStrings": {
    "DefaultConnection": "YOUR_DATABASE_CONNECTION_STRING_HERE"
}
```

3. **Update the Database**

Run the following command to update the database with the required schema:

Using terminal:
```bash
dotnet ef database update
```

Using Package Manager Console:
```bash
Update-Database
```

4. **Running the Project**

Once the database is set up, you can run the project using:

```bash
dotnet run
```

# Seeded Users

To help you get started with testing, the platform is pre-seeded with two users:

### Admin Account
- **Username:** admin1
- **Password:** - Check in UserConfiguration.cs file
- **Role:** admin

### User Account
- **Username:** user1
- **Password:** - Check in UserConfiguration.cs file
- **Role:** user

Use these credentials to log in and explore the functionalities available to each role.

# License

This project is licensed under the MIT License - see the `LICENSE.md` file for details.

**Thank you for choosing TheProject for your educational and administrative needs. We're excited to be a part of your journey in creating a dynamic and engaging learning environment.**
