namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Kalle", 30000);
            employee.Name = "Nisse";
            int salary = employee.Salary;
         
        }
    }
}
