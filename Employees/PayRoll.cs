using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class PayRoll : IPayRoll
    {
        private List<Employee> _employees;

        public PayRoll()
        {
            _employees = new List<Employee>();
        }


        public List<Employee> GetEmployees()
        {
            //ToDo: Fix not good!!!!
            return _employees.ToList();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
        public void AddEmployee(string name, uint salary)
        {
            //Validate
            _employees.Add(new Employee(name, salary));
        }

    }
}
