


using Employees.Helpers;
using Employees.UI;
using System.Threading.Channels;

namespace Employees
{
    internal class Program
    {

        //Programmets startpunkt
        //Får bara finnas EN!
        //Måste vara static
        static void Main(string[] args)
        {
            IPayRoll payRoll = new PayRoll();
            IUI ui = new ConsoleUI();
            Main main = new Main(payRoll, ui);
            main.Run();

        }

       
    }
}
