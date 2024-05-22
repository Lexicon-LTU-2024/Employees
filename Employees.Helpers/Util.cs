namespace Employees.Helpers
{
    public static class Util
    {
        public static string AskForString()
        {
            bool success = false;
            string name;

            do
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("You must enter a valid name");
                }
                else
                {
                    success = true;
                }


            } while (!success);

            return name;
        }
    }
}
