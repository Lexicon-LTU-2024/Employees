
namespace Employees
{
    internal class Program
    {
        private static PayRoll payRoll = new PayRoll();

        static void Main(string[] args)
        {

            SeedData();
         
        }

        private static void SeedData()
        {
            payRoll.AddEmployee("Anna", 45000);
        }
    }
}
