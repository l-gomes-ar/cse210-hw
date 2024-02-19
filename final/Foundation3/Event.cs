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
       Console.WriteLine($"Title: {_title}");
       Console.WriteLine($"Description: {_description}");
       Console.WriteLine($"Date: {_date}");
       Console.WriteLine($"Time: {_time}");
       Console.WriteLine($"Address: {_address.GetAddress()}");
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"Type of Event: {GetTypeEvent()}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }

    public abstract void DisplayFullDetails();
    protected abstract string GetTypeEvent();
}