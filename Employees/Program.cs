
namespace Employees
{
    internal class Program
    {
        private static PayRoll _payRoll = new PayRoll();

        static void Main(string[] args)
        {
          
            SeedData();
            



        }

        private static void SeedData()
        {
            _payRoll.AddEmployee("Anna", 45000);
        }
    }
}
