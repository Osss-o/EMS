using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EMS
{
    public abstract class Employee : IWorkable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private decimal _Salary;
        public decimal Salary
        {
            get { return _Salary; }
            set
            {
                _Salary = value;
            }
        }
        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            _Salary = salary;
        }
        public abstract void Work();
        public abstract void CalculateSalary();
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID:{Id}, Name:{Name}");
        }
    }
}
