namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("Kalle", 20000);
            Robot robot2 = new Robot("Nisse",2);
            Robot robot3 = new Robot("Pelle",54);
            // Robot robot2 = new Robot();
            
            Console.WriteLine(robot.GetName());
            robot.SetName("Kalle Anka");
            robot.Salary = 54;
            Console.WriteLine(robot.GetName());

            robot.Somethingelse = 54;
            int someValue = robot.Somethingelse;
        }
    }
}
