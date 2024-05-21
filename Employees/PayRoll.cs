using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class PayRoll
    {
        private List<Employee> _employees;

        public PayRoll()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(string name, int salary)
        {
            _employees.Add(new Employee(name, salary)); 
        }

        public List<Employee> GetEmployees()
        {
            //ToDo: Fix not good!!!!
            return _employees;
        }
    }
}
