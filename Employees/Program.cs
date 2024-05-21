


namespace Employees
{
    internal class Program
    {
        private static PayRoll _payRoll = new PayRoll();

        static void Main(string[] args)
        {
          
            SeedData();

            do
            {
                ShowMainMeny();
                var input = Console.ReadLine()!;
                //var r = new Robot();
                //Robot r2 = new();

                switch (input)
                {
                    case "1":

                        break;   
                    case "2":
                        PrintEmployees();
                        break;   
                    case "Q":

                        break;
                    default:
                        break;
                }


            } while (true);

        }

        private static void PrintEmployees()
        {
          //  List<Employee> employees = _payRoll.GetEmployees();
            var employees = _payRoll.GetEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            }
        }

        private static void ShowMainMeny()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Print");
            Console.WriteLine("Q. Quit");
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
