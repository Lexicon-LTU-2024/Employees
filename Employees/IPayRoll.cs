
namespace Employees
{
    internal interface IPayRoll
    {
        void AddEmployee(Employee employee);
        void AddEmployee(string name, uint salary);
        List<Employee> GetEmployees();
    }
}