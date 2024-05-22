


using Employees.Helpers;
using System.Threading.Channels;

namespace Employees
{
    internal class Program
    {
        private static PayRoll _payRoll = new PayRoll();

        //Programmets startpunkt
        //Får bara finnas EN!
        //Måste vara static
        static void Main(string[] args)
        {

            //Employee kalle = new Employee("Kalle", 35000);
            //_payRoll.AddEmployee(kalle);

            //List<Employee> employees = _payRoll.GetEmployees();
            //Console.WriteLine(employees[0].Name);

            //employees[0].Name = "Anna";
            //List<Employee> after = _payRoll.GetEmployees();
            //Console.WriteLine(after[0].Name);

            SeedData();

            do
            {
                ShowMainMeny();
                var input = Console.ReadLine()!;

                switch (input)
                {
                    case MenyHelpers.Add:
                        AddEmployee();
                        break;   
                    case MenyHelpers.Print:
                        PrintEmployees();
                        break;   
                    case MenyHelpers.Quit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }


            } while (true);

        }

        private static void AddEmployee()
        {

            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary");

            _payRoll.AddEmployee(name, salary);

        }

        private static void PrintEmployees()
        {
            List<Employee> employees = _payRoll.GetEmployees();
            // var employees = _payRoll.GetEmployees();
            //employees = null;

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.Print());
            }
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine($"{MenyHelpers.Add}. Add");
            Console.WriteLine($"{MenyHelpers.Print}. Print");
            Console.WriteLine($"{MenyHelpers.Quit}. Quit");
        }

        private static void SeedData()
        {
            _payRoll.AddEmployee("Anna", 20000);
            _payRoll.AddEmployee("Bengt", 70000);
            _payRoll.AddEmployee("Nisse", 45000);
            _payRoll.AddEmployee("Pelle", 25000);
        }
    }
}
