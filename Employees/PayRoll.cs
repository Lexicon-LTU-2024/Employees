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


        public IEnumerable<Employee> GetEmployees()
        {
            return _employees.ToList();
        }

        public void AddEmployee(Employee employee)
        {
            if (employee is null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            _employees.Add(employee);
        }
        public void AddEmployee(string name, uint salary)
        {
            ArgumentNullException.ThrowIfNull(name, "name");

            //if (name is null)
            //{
            //    throw new ArgumentNullException(nameof(name));
            //}

            _employees.Add(new Employee(name, salary));
        }

    }
}
