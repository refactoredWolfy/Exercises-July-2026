# C# Object-Oriented Programming Practice

This repository contains three beginner-to-intermediate C# exercises that I completed to strengthen my understanding of object-oriented programming (OOP).

The goal of these exercises was to practice writing clean, maintainable code while becoming more comfortable with core C# concepts.

## Exercise 1: Rectangle Class

### Concepts Practiced

- Classes and objects
- Constructors
- Read-only properties
- Input validation with `ArgumentException`
- Methods

### Description

I implemented a `Rectangle` class that validates its constructor arguments and provides a `GetArea()` method to calculate the rectangle's area.

---

## Exercise 2: Employee Hierarchy

### Concepts Practiced

- Abstract classes
- Inheritance
- Method overriding
- Constructor chaining with `base(...)`
- Polymorphism

### Description

I created an abstract `Employee` base class together with two derived classes:

- `FullTimeEmployee`
- `PartTimeEmployee`

Each class overrides the abstract `CalculateSalary()` method according to its own salary calculation.

The employees are stored in a `List<Employee>` to demonstrate polymorphism.

---

## Exercise 3: Machines and Interfaces

### Concepts Practiced

- Interfaces
- Abstract classes
- Interface implementation
- Method overriding
- Polymorphism

### Description

I implemented an abstract `Machine` class together with an `IRechargeable` interface.

The `Robot` class inherits from `Machine` and implements `IRechargeable`. This exercise demonstrates how inheritance and interfaces can be used together.

---

## What I Learned

Through these exercises, I practised:

- Object-oriented programming principles
- Constructors and constructor validation
- Exception handling
- Abstract classes
- Interfaces
- Method overriding
- Polymorphism
- Working with collections such as `List<T>`

---

## Areas I Still Need to Improve

Although these exercises helped me improve my understanding of C#, I still need to work on several areas:

- Writing cleaner and more idiomatic C# code
- Reducing syntax and compiler errors
- Understanding access modifiers such as `public`, `private`, and `protected`
- Remembering correct constructor and method syntax
- Knowing when to use an interface instead of an abstract class
- Following C# and .NET naming conventions consistently
- Designing larger object-oriented applications

I am still learning, and some parts of the original solution required corrections. However, the exercises helped me identify the areas that I need to practise more carefully.

---

## About This Repository

I am currently learning C# with the goal of becoming a professional .NET developer.

This repository documents my progress and serves as a collection of practice exercises as I continue improving my programming skills.

Constructive feedback and suggestions are always welcome.

