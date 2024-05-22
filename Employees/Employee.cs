namespace Employees
{
    internal class Employee
    {
        public string Name { get; }
        public uint Salary { get; }

        public Employee(string name, uint salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Print()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}