using Employees.Helpers;
using Employees.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class Main
    {
        private IPayRoll _payRoll;
        private IUI _ui;

        public Main(IPayRoll payRoll, IUI ui)
        {
            _payRoll = payRoll;
            _ui = ui;
        }

        public void Run()
        {
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

        private void AddEmployee()
        {

            string name = Util.AskForString("Name", _ui);
            uint salary = Util.AskForUInt("Salary", _ui);

            _payRoll.AddEmployee(name, salary);

        }

        private void PrintEmployees()
        {
            IEnumerable<Employee> employees = _payRoll.GetEmployees();
            // var employees = _payRoll.GetEmployees();
            //employees = null;
           
            foreach (Employee employee in employees)
            {
                _ui.Print(employee.Print());
            }
        }

        private  void ShowMainMeny()
        {
            _ui.Print($"{MenyHelpers.Add}. Add");
            _ui.Print($"{MenyHelpers.Print}. Print");
            _ui.Print($"{MenyHelpers.Quit}. Quit");
        }

        private  void SeedData()
        {
            _payRoll.AddEmployee("Anna", 20000);
            _payRoll.AddEmployee("Bengt", 70000);
            _payRoll.AddEmployee("Nisse", 45000);
            _payRoll.AddEmployee("Pelle", 25000);
        }
    }
}
