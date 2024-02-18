public abstract class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public void AddAddress(string street, string city, string state, string country)
    {
        _address = new Address(street, city, state, country);
    }

    public void DisplayStandardDetails()
    {
       Console.WriteLine($"Title:\n  {_title}\n");
       Console.WriteLine($"Description:\n  {_description}\n");
       Console.WriteLine($"Date:\n  {_date}\n");
       Console.WriteLine($"Time:\n  {_time}\n");
       Console.WriteLine($"Address:\n{_address.GetAddress()}\n");
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"Type of Event:\n  {GetTypeEvent()}\n");
        Console.WriteLine($"Title:\n  {_title}\n");
        Console.WriteLine($"Date:\n  {_date}\n");
    }

    public abstract void DisplayFullDetails();
    protected abstract string GetTypeEvent();
}