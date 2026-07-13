using System;
using System.Collections.Generic;

// ---------------------------------
// Exercise 3: Interface and Machine
// ---------------------------------

public interface IRechargeable
{
    void Recharge();
}

public abstract class Machine
{
    protected string Name { get; }

    protected Machine(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "The name must not be null, empty, or whitespace.",
                nameof(name));
        }

        Name = name;
    }

    public abstract void Start();
}

public class Robot : Machine, IRechargeable
{
    public Robot(string name)
        : base(name)
    {
    }

    public override void Start()
    {
        Console.WriteLine($"{Name} started the engine.");
    }

    public void Recharge()
    {
        Console.WriteLine($"{Name} was recharged.");
    }
}

// ---------------------------------
// Exercise 2: Employees
// ---------------------------------

public abstract class Employee
{
    public string Name { get; }

    protected Employee(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException(
                "The name must not be null, empty, or whitespace.",
                nameof(name));
        }

        Name = name;
    }

    public abstract decimal CalculateSalary();
}

public class FullTimeEmployee : Employee
{
    private readonly decimal _monthlySalary;

    public FullTimeEmployee(string name, decimal monthlySalary)
        : base(name)
    {
        if (monthlySalary < 0)
        {
            throw new ArgumentException(
                "The monthly salary must not be negative.",
                nameof(monthlySalary));
        }

        _monthlySalary = monthlySalary;
    }

    public override decimal CalculateSalary()
    {
        return _monthlySalary;
    }
}

public class PartTimeEmployee : Employee
{
    private readonly decimal _hourlyWage;
    private readonly int _hoursWorked;

    public PartTimeEmployee(
        string name,
        decimal hourlyWage,
        int hoursWorked)
        : base(name)
    {
        if (hourlyWage < 0)
        {
            throw new ArgumentException(
                "The hourly wage must not be negative.",
                nameof(hourlyWage));
        }

        if (hoursWorked < 0)
        {
            throw new ArgumentException(
                "The hours worked must not be negative.",
                nameof(hoursWorked));
        }

        _hourlyWage = hourlyWage;
        _hoursWorked = hoursWorked;
    }

    public override decimal CalculateSalary()
    {
        return _hourlyWage * _hoursWorked;
    }
}

// ---------------------------------
// Exercise 1: Rectangle
// ---------------------------------

public class Rectangle
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        if (width <= 0)
        {
            throw new ArgumentException(
                "The width must be greater than zero.",
                nameof(width));
        }

        if (height <= 0)
        {
            throw new ArgumentException(
                "The height must be greater than zero.",
                nameof(height));
        }

        Width = width;
        Height = height;
    }

    public double GetArea()
    {
        return Width * Height;
    }
}

// ---------------------------------
// Program
// ---------------------------------

public class Program
{
    public static void Main(string[] args)
    {
        // -----------------
        // Exercise 1
        // -----------------

        Rectangle rectangle = new Rectangle(8.8, 15.5);

        Console.WriteLine("Rectangle:");
        Console.WriteLine($"Width: {rectangle.Width}");
        Console.WriteLine($"Height: {rectangle.Height}");
        Console.WriteLine($"Area: {rectangle.GetArea()}");

        Console.WriteLine();

        // -----------------
        // Exercise 2
        // -----------------

        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee("Wolfi", 2000m),
            new PartTimeEmployee("Julia", 30m, 20)
        };

        Console.WriteLine("Employees:");

        foreach (Employee employee in employees)
        {
            Console.WriteLine(
                $"{employee.Name}: {employee.CalculateSalary():0.00}");
        }

        Console.WriteLine();

        // -----------------
        // Exercise 3
        // -----------------

        List<Machine> machines = new List<Machine>
        {
            new Robot("Wolfi"),
            new Robot("Julia")
        };

        Console.WriteLine("Machines:");

        foreach (Machine machine in machines)
        {
            machine.Start();
        }

        Console.WriteLine();

        IRechargeable rechargeableRobot = new Robot("Robert");
        rechargeableRobot.Recharge();
    }
}