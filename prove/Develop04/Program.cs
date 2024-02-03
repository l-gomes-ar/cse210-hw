// Exceeding Requirements: Added input validation for the options.
// Made sure no random prompts/questions are selected until they have all been used at least once in that session.
using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity activity1 = new BreathingActivity();
        ReflectingActivity activity2 = new ReflectingActivity();
        ListingActivity activity3 = new ListingActivity();

        int option = 0;
        while (option != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            bool result = int.TryParse(Console.ReadLine(), out option);

            if (!result || option < 1 || option > 4)
            {
                Console.WriteLine("Not a valid option!");
                Thread.Sleep(1500);
                continue;
            }
            
            switch (option) 
            {
                case 1:
                    activity1.Run();
                    break;
                case 2:
                    activity2.Run();
                    break;
                case 3:
                    activity3.Run();
                    break;
                default:
                    break;
            }
        }
    }
}