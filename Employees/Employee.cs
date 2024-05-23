namespace Employees
{
    internal class Employee
    {
        public string Name { get; }
        public uint Salary { get; }

        public SalaryLevel SalaryLevel => Salary < 25000 ? SalaryLevel.Junior : SalaryLevel.Senior;
        //{
        //    get
        //    {
        //        if(Salary< 25000)
        //        {
        //            return SalaryLevel.Junior;
        //        }
        //        else
        //        {
        //            return SalaryLevel.Senior;
        //        }
        //    }
        //}

        public Employee(string name, uint salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Print()
        {
            return $"Name: {Name} Salary: {Salary} SalaryLevel: {SalaryLevel}";
        }
    }
}