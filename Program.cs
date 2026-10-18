// Program.cs
using EMS;
using System;

class Program
{
    static void Main()
    {
        FullTimeEmployee ahmad = new FullTimeEmployee(1, "Ahmad", 1200m);
        ahmad.CalculateSalary();
        ahmad.DisplayInfo();

        PartTimeEmployee omar = new PartTimeEmployee(2, "Omar", 10m, 40);
        omar.CalculateSalary();
        omar.DisplayInfo();

        ahmad.Work();
        omar.Work();
    }
}