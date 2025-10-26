# Unity C# Interface Assignment

A Unity project demonstrating the implementation of interfaces in C# through geometric shape classes.

## 📋 Overview

This project implements the `IShape` interface across three geometric shape classes:

- **Trapezium** - Calculates area, perimeter, and unknown sides
- **Circle** - Calculates area, circumference, and displays radius
- **Nonagon** - Calculates area, perimeter of a 9-sided polygon

## 🎯 Learning Objectives

- Understanding C# interfaces
- Implementing interface methods in multiple classes
- Using polymorphism in Unity
- Testing with Unity's Debug.Log()

## 🚀 Quick Start

1. Open project in Unity (2021.3 or later)
2. Navigate to `Assets/Scripts/Interfaces/InterfaceTestScript.cs`
3. The script is attached to the `ShapeManager` GameObject
4. Press Play ▶️ and check the Console

## 📂 Project Structure

```
Assets/
└── Scripts/
    └── Interfaces/
        └── InterfaceTestScript.cs
```

## 💻 Code Structure

### IShape Interface

```csharp
public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}
```

### Implemented Classes

- `Trapezium : IShape`
- `Circle : IShape`
- `Nonagon : IShape`

Each class implements the interface methods with shape-specific formulas.

## 🖥️ Expected Output

```
=== Testing IShape Interface Implementation ===

--- TRAPEZIUM ---
Trapezium Area: 32 square units
Trapezium Perimeter: 26 units
Trapezium Calculated Unknown Side: 4.12 units

--- CIRCLE ---
Circle Area: 153.94 square units
Circle Circumference: 43.98 units
Circle Radius: 7 units

--- NONAGON ---
Nonagon Area: 154.55 square units
Nonagon Perimeter: 45 units
Number of Sides: 9

=== All Shape Tests Completed ===
```

## 🔧 Requirements

- Unity 2021.3 or later
- Basic understanding of C# and OOP concepts

## 📚 Key Concepts

- **Interface**: A contract defining methods that implementing classes must provide
- **Polymorphism**: Different classes can be treated through a common interface
- **Implementation**: Each shape class provides its own logic for interface methods

## 👨‍💻 Author

Moss Aimelyse

## 📝 License

This project is for educational purposes.
