namespace EMS
{
    public class PartTimeEmployee : Employee
    {
        private decimal hourlyRate;
        private int hoursWorked;
        public PartTimeEmployee(int id, string name, decimal hourlyRate, int hoursWorked) : base(id, name, 0)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }
        public override void CalculateSalary()
        {
            Salary = hourlyRate * hoursWorked;
        }
        public override void Work()
        {
            Console.WriteLine($"{Name} is working part time.");
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Employment Type: Part Time");
            Console.WriteLine($"Salary: {Salary} JOD\n");
        }
    }
}
