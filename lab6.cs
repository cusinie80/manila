using System;
using System.Collections.Generic;

interface IPayable
{
    void Pay();
}

class Invoice : IPayable
{
    public void Pay()
    {
        Console.WriteLine("Invoice paid.");
    }
}

class Salary : IPayable
{
    public void Pay()
    {
        Console.WriteLine("Salary paid.");
    }
}

class Program
{
    static void Main()
    {
        List<IPayable> payments = new List<IPayable>();

        payments.Add(new Invoice());
        payments.Add(new Salary());

        foreach (IPayable payment in payments)
        {
            payment.Pay();
        }
    }
}
