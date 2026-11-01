using System;

namespace Sirnazam
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Enter number: ");
            string valueFromUser = Console.ReadLine();

            int x = int.Parse(valueFromUser);
            int y = 2;

            if (x > y)
            {
                Console.WriteLine("Greater");
            }
            else if (x < y)
            {
                Console.WriteLine("Less")
            }
            else
            {
                Console.WriteLine("Equal");
            }

        }
    }
}