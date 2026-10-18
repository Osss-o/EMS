namespace EMS
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(int id, string name, decimal fixedsalary) : base(id, name, fixedsalary)
        {

        }
        public override void Work()
        {
            Console.WriteLine($"{Name} is working full time.");
        }
        public override void CalculateSalary()
        {

        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Employment Type: Full Time");
            Console.WriteLine($"Salary: {Salary} JOD\n");
        }
    }
}
