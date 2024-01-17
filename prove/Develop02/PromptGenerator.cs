public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most interesting thing I learned today?",
        "Has something upset me today?"
    };

    public string GetRandomPrompt()
    {
        // Initialise new instance of a Random object to get a random integer as index in the prompts list
        Random random = new Random();
        
        return _prompts[random.Next(0, 7)];
    }


}