


using Employees.Helpers;
using Employees.UI;
using System.Threading.Channels;

namespace Employees
{
    internal class Program
    {
        private static IPayRoll _payRoll = new PayRoll();
        private static IUI _ui = new MockUI();

        //Programmets startpunkt
        //Får bara finnas EN!
        //Måste vara static
        static void Main(string[] args)
        {

            //MockUI mockUI = new MockUI();
            //mockUI.SetInput = "fem";
            //var result = Util.AskForUInt("", mockUI);


            SeedData();

            do
            {
                ShowMainMeny();
                var input = _ui.GetInput();

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

            string name = Util.AskForString("Name", _ui);
            uint salary = Util.AskForUInt("Salary", _ui);

            _payRoll.AddEmployee(name, salary);

        }

        private static void PrintEmployees()
        {
            List<Employee> employees = _payRoll.GetEmployees();
            // var employees = _payRoll.GetEmployees();
            //employees = null;

            foreach (Employee employee in employees)
            {
                _ui.Print(employee.Print());
            }
        }

        private static void ShowMainMeny()
        {
            _ui.Print($"{MenyHelpers.Add}. Add");
            _ui.Print($"{MenyHelpers.Print}. Print");
            _ui.Print($"{MenyHelpers.Quit}. Quit");
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
