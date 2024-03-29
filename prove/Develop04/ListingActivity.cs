public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity() : base()
    {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        AddPrompts();
        _count = 0;
    }

    public void Run() 
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> items = GetListFromUser();
        _count = items.Count;
        Console.WriteLine($"You listed {_count} items!\n");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        // Check we still have prompts, add all of them otherwise
        if (_prompts.Count == 0)
        {
            AddPrompts();
        }

        // Get random int for index, get prompt from list, remove prompt from list
        Random random = new Random();
        int randIndex = random.Next(0, _prompts.Count);
        string prompt = _prompts[randIndex];
        _prompts.RemoveAt(randIndex);

        return prompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
        }

        return items;
    }

    private void AddPrompts()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
}