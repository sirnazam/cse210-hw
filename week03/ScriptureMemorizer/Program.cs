
using System;

namespace Sirnazam
{
    class Program
    {
        static void Main(string[] args)
        {
            Reference reference = new Reference("John", 3, 16, 16);

            string text = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life";

            Scripture scripture = new Scripture(reference, text);

            Console.WriteLine("SCRIPTURE MEMORIZER PROGRAM");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations! You have hidden all the words.");
                    break;
                }

                Console.WriteLine();
                Console.Write("Press Enter to continue or type 'quit': ");

                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Thank you for using Scripture Memorizer!");
                    break;
                }

                scripture.HideRandomWords(3);
            }
        }
    }
}
