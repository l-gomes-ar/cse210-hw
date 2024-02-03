public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = "Default";
        _description = "Default Description";
        _duration = 0;

    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine($"{_description}\n");

        while (_duration == 0)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            string duration = Console.ReadLine();

            // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/how-to-determine-whether-a-string-represents-a-numeric-value
            bool result = int.TryParse(duration, out _duration);

            if (!result) 
            {
                Console.WriteLine("Time not valid!");
            }
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>
        {
            "|", "/", "-", "\\"
            
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            if (i == animationStrings.Count - 1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            if (seconds > 9)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
            seconds--;
        }
    }
}