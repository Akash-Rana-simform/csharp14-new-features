# 🚀 C# 14 & .NET 10 Feature Demos

![.NET](https://img.shields.io/badge/.NET-10-purple)
![C#](https://img.shields.io/badge/C%23-14-blue)
![License](https://img.shields.io/badge/license-MIT-green)
![Status](https://img.shields.io/badge/status-learning-orange)

A collection of **practical demos showcasing new language features in C#
14 and key improvements in .NET 10**.

This repository was created as part of a **technical knowledge sharing
session** to help developers understand how modern C# features simplify
code and improve developer productivity.

------------------------------------------------------------------------

# 📚 Topics Covered

## C# 14 Language Features

-   Extension Members
-   `field` keyword for property backing fields
-   Null Conditional Assignment
-   Partial Members improvements
-   Partial Constructors

------------------------------------------------------------------------

# 🗂 Project Structure

    CSharp14Demo
    │
    ├── Program.cs
    ├── ExtensionMembersDemo.cs
    ├── FieldKeywordDemo.cs
    ├── NullConditionalAssignmentDemo.cs
    ├── PartialMembersDemo.cs

Each demo focuses on **one feature with a minimal and clear example.**

------------------------------------------------------------------------

# 🧪 Example Demo

## Partial Constructor (C# 14)

``` csharp
public partial class Calculator
{
    public partial Calculator();
}

public partial class Calculator
{
    public partial Calculator()
    {
        Console.WriteLine("Calculator initialized");
    }
}
```

------------------------------------------------------------------------

# ▶️ Demo Output

    === C# 14 Partial Members Demo ===

    Calculator initialized
    LOG: Adding 5 and 3

    Result: 8

------------------------------------------------------------------------

# ▶️ How to Run

### 1️⃣ Install .NET 10 SDK

Download from Microsoft: https://dotnet.microsoft.com

### 2️⃣ Clone the Repository

``` bash
git clone https://github.com/your-username/csharp14-dotnet10-demos.git
```

### 3️⃣ Run the Project

``` bash
dotnet run
```

------------------------------------------------------------------------

# 🎯 Purpose

This project helps developers:

-   Learn the latest **C# 14 language features**
-   Understand **real-world coding improvements**
-   Explore **modern .NET 10 capabilities**
-   See **simple runnable demos**

------------------------------------------------------------------------
