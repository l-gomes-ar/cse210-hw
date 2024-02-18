public class Outdoor : Event
{
    private string _weatherInfo; 

    public Outdoor(string title, string description, string date, string time, string weatherInfo) : base(title, description, date, time)
    {
        _weatherInfo = weatherInfo;
    }

    public override void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Type of Event:\n  {GetTypeEvent()}\n");
        Console.WriteLine($"Weather Info:\n  {_weatherInfo}\n");
    }

    protected override string GetTypeEvent()
    {
        return "Outdoor Gathering";
    }
}