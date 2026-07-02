namespace CG_BTBuoi14
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public override void CalculateSalary()
        {
            Console.WriteLine($"Salary of Full time employee: {Salary * 160}");
        }
    }
}
