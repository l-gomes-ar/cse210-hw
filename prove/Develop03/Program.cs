// Showing Creativity and Exceeding Requirements:
// I chose to have my program load scriptures from a json file and choose scriptures at random to present to the user.

using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        // Create list for all scriptures read from scripturesjson
        List<ScriptureJson> scripturesJson = new List<ScriptureJson>();

        // Read scriptures.json file and deserialize json objects to a list of 'ScripturesJson'
        using (StreamReader r = new StreamReader("scriptures.json"))
        {
            string json = r.ReadToEnd();
            scripturesJson = JsonSerializer.Deserialize<List<ScriptureJson>>(json);
        }

        // Store each scripture from the scripturesJson into a list of <Scripture>
        List<Scripture> scriptures = new List<Scripture>();
        
        foreach (ScriptureJson sJson in scripturesJson)
        {
            Reference r = new Reference(sJson.book, sJson.chapter, sJson.startVerse, sJson.endVerse);
            Scripture s = new Scripture(r, sJson.scripture);

            scriptures.Add(s);
        }

        // Get a random scripture from the list of <Scripture>
        Random rnd = new Random();
        int index = rnd.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        string option = "";
        do 
        {
            Console.Clear();
            Console.WriteLine($"{scripture.GetDisplayText()}");
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            option = Console.ReadLine();

            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(1);
            }
            else
            {
                option = "quit";
            }
        } while (option != "quit");

    }
} 