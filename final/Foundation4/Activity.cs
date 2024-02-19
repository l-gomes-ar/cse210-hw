public abstract class Activity
{
    private DateTime _date;
    private int _lengthMinutes;

    public Activity(int year, int month, int day, int lengthMinutes)
    {
        _date = new DateTime(year, month, day);
        _lengthMinutes = lengthMinutes;
    }

    protected virtual double GetDistance()
    {
        return _lengthMinutes * GetPace();
    }

    protected virtual double GetSpeed()
    {
        return GetDistance() / _lengthMinutes * 60;
    }

    protected double GetPace()
    {
        return GetSpeed() / 60;
    }

    public string GetSummary()
    {
        string date = _date.ToString("dd MMM yyyy");
        string activity = GetActivityType();
        int t = _lengthMinutes;
        double d = Math.Round(GetDistance(), 1);
        double v = Math.Round(GetSpeed(), 1);
        double paceMinMile = Math.Round(1 / GetPace(), 1);

        return $"{date} {activity} ({t} min) - Distance {d} miles, Speed {v} mph, Pace: {paceMinMile} min per mile.";
    }

    protected abstract string GetActivityType();
}