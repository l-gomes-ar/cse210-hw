public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string speaker, int capacity) : base(title, description, date, time)
    {
        _speakerName = speaker;
        _capacity = capacity;
    }

    public override void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Type of Event:\n  {GetTypeEvent()}\n");
        Console.WriteLine($"Speaker:\n  {_speakerName}\n");
        Console.WriteLine($"Capacity:\n  {_capacity} People\n");
    }

    protected override string GetTypeEvent()
    {
        return "Lecture";
    }
}