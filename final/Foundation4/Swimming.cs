public class Swimming : Activity
{
    private int _numberLaps;
    
    public Swimming(int year, int month, int day, int lengthMinutes, int numberLaps) : base(year, month, day, lengthMinutes)
    {
        _numberLaps = numberLaps;
    }

    protected override double GetDistance()
    {
        return _numberLaps * 50 / 1000 * 0.62;
    }

    protected override string GetActivityType()
    {
        return "Swimming";
    }
}