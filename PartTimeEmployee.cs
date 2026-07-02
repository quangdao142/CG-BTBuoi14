namespace CG_BTBuoi14
{
    public class PartTimeEmployee : Employee
    {
        public PartTimeEmployee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }
        public override void CalculateSalary()
        {
            Console.WriteLine($"Salary of Part time employee: {Salary * 80}");
        }
    }
}
