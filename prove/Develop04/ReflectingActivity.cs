public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity() : base()
    {
        SetName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        AddPrompts();
        AddQuestions();
    }

    public void Run()
    {
        DisplayStartingMessage();

        // Run main part of activity
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DisplayQuestions();
        Console.WriteLine();

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

    public string GetRandomQuestion()
    {
        // Check we still have questions, add all of them otherwise
        if (_questions.Count == 0)
        {
            AddQuestions();
        }

        // Get random int for index, get question from list, remove question from list
        Random random = new Random();
        int randIndex = random.Next(0, _questions.Count);
        string question = _questions[randIndex];
        _questions.RemoveAt(randIndex);

        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestions()
    {
        Console.Clear();

        DateTime startTime = DateTime.Now;
        int roundedSeconds = ((GetDuration() + 5) / 10) * 10;
        DateTime endTime = startTime.AddSeconds(roundedSeconds);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(20);
            Console.WriteLine();
        }
    }

    private void AddPrompts()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }

    private void AddQuestions()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
}