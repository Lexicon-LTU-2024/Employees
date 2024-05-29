


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

            //string name = Console.ReadLine()!;
            //int x = int.Parse(name);
            IPayRoll payRoll = new PayRoll();
            IUI ui = new ConsoleUI();
            Main main = new Main(payRoll, ui);

            try
            {
                main.Run();
               // payRoll.AddEmployee(null, 35000);

            }
            catch (ArgumentNullException ex)
            {

                //...
            }
            catch(ArgumentException ex)
            {
                //....
            }
            catch(Exception ex)
            {

            }
            finally
            {
                main.Run();
            }

        }

       
    }
}
