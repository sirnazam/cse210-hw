
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Entry newEntry = new Entry();

                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;

                    theJournal.AddEntry(newEntry);

                    break;

                case 2:
                    theJournal.DisplayAll();
                    break;

                case 3:
                    Console.Write("Enter the filename: ");
                    string saveFile = Console.ReadLine();

                    theJournal.SaveToFile(saveFile);
                    break;

                case 4:
                    Console.Write("Enter the filename: ");
                    string loadFile = Console.ReadLine();

                    theJournal.LoadFromFile(loadFile);
                    break;

                case 5:
                    Console.WriteLine("Thank you for using the Journal Program!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
