// Exceeding Requirements: Added a safe check for options like "Load" and "Quit", if current Journal not empty
// ask user if they wish to continue/quit with a reminder that unsaved changes will be lost.

using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        List<string> options = new List<string>
        {
            "1. Write", "2. Display", "3. Load", "4. Save", "5. Quit"
        };

        PromptGenerator promptGenerator = new PromptGenerator();
        Journal myJournal = new Journal();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            foreach(string option in options)
            {
                Console.WriteLine(option);
            }

            Console.Write("What would you like to do? ");
            choice = (Console.ReadLine());

            switch (choice)
            {
                // 1. Write
                case "1":
                    // Create an instance of Entry
                    Entry entry = new Entry();

                    // Add its attributes
                    DateTime currentTime = DateTime.Now;
                    entry._date = currentTime.ToShortDateString();

                    entry._promptText = promptGenerator.GetRandomPrompt();

                    Console.WriteLine(entry._promptText);
                    Console.Write("> ");
                    entry._entryText = Console.ReadLine();

                    // Add entry to myJournal
                    myJournal.AddEntry(entry);

                    break;
                // 2. Display
                case "2":
                    // Display all entries in myJournal
                    myJournal.DisplayAll();

                    break;
                // 3. Load
                case "3":
                    // If current journal not empty, double check for saving
                    if (myJournal._entries.Count != 0)
                    {
                        Console.Write("Do you wish to load another journal? All unsaved changes will be lost. (Y/N)? ");
                        string saveFirst = Console.ReadLine();

                        if (saveFirst == "N")
                        {
                            break;
                        }
                    }
                
                    Console.Write("What is the filename for loading? ");
                    string filename = Console.ReadLine();

                    myJournal.LoadFromFile(filename);

                    break;
                // 4. Save
                case "4":
                    Console.Write("What is the filename for saving? ");
                    filename = Console.ReadLine();

                    myJournal.SaveToFile(filename);

                    break;
                // 5. Quit
                case "5":
                    // If current journal not empty, double check for saving
                    if (myJournal._entries.Count != 0)
                    {
                        Console.Write("Do you wish to quit? All unsaved changes will be lost. (Y/N) ");
                        string saveFirst = Console.ReadLine();

                        if (saveFirst == "N")
                        {
                            choice = "0";
                            break;
                        }
                    }

                    break;
                // Default: If user does not choose valid option
                default:
                    Console.WriteLine("Please, choose an option from 1 to 5!");
                    break;
            }
        }
    }
}