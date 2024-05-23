using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.UI
{
    public interface IUI
    {
        string GetInput();
        void Print(string message);
    }

    public class ConsoleUI : IUI
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public string GetInput()
        {
            return Console.ReadLine() ?? string.Empty;
        }
    }

    public class MockUI : IUI
    {
        public string SetInput { private get; set; } = "1";
        public string GetInput()
        {
            return SetInput;
        }

        public void Print(string message)
        {
            
        }
    }
}
