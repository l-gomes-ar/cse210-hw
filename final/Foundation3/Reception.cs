public class Reception : Event
{
    private string _email; 

    public Reception(string title, string description, string date, string time, string email) : base(title, description, date, time)
    {
        _email = email;
    }

    public override void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Type of Event:\n  {GetTypeEvent()}\n");
        Console.WriteLine($"Email for RSVP:\n  {_email}\n");
    }

    protected override string GetTypeEvent()
    {
        return "Reception";
    }
}