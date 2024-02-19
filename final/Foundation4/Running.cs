public class Running : Activity
{
    private double _distance;

    public Running(int year, int month, int day, int lengthMinutes, double distance) : base(year, month, day, lengthMinutes)
    {
        _distance = distance;
    }

    protected override double GetDistance()
    {
        return _distance;
    }

    protected override string GetActivityType()
    {
        return "Running";
    }
}