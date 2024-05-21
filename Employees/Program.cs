namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PayRoll payRoll = new PayRoll();
            payRoll.AddEmployee("Anna", 45000);

            Employee employee = new Employee("Kalle", 30000);
            employee.Name = "Nisse";
            int salary = employee.Salary;
         
        }
    }
}
