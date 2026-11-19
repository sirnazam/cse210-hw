
using System;

namespace Sirnazam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a scripture reference.
            Reference reference = new Reference("John", 3, 16, 16);

            // Store the scripture text.
            string text = "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life";

            // Create the Scripture object.
            Scripture scripture = new Scripture(reference, text);

            Console.WriteLine("SCRIPTURE MEMORIZER PROGRAM");
            Console.WriteLine("---------------------------");

            // Display instructions.
            Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

            // Continue until all words are hidden or the user quits.
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(scripture.GetDisplayText());

                // Check whether all words are hidden.
                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations! You have hidden all the words.");
                    break;
                }

                Console.WriteLine();
                Console.Write("Press Enter to continue or type 'quit': ");

                string input = Console.ReadLine();

                // Allow the user to quit.
                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Thank you for using Scripture Memorizer!");
                    break;
                }

                // Hide three random words each time Enter is pressed.
                scripture.HideRandomWords(3);
            }
        }
    }
}
