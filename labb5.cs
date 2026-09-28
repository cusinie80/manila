using System;

abstract class Employee
{
    public string Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }

    public abstract double CalculateSalary();
}

class Manager : Employee
{
    public Manager(string name) : base(name)
    {
    }

    public override double CalculateSalary()
    {
        return 50000;
    }
}

class Clerk : Employee
{
    public Clerk(string name) : base(name)
    {
    }

    public override double CalculateSalary()
    {
        return 25000;
    }
}

class Program
{
    static void Main()
    {
        Employee manager = new Manager("Kamana");
        Employee clerk = new Clerk("Manila");

        Console.WriteLine($"{manager.Name} Salary: {manager.CalculateSalary()}");
        Console.WriteLine($"{clerk.Name} Salary: {clerk.CalculateSalary()}");
    }
}