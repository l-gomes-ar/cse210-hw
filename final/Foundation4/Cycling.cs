public class Cycling : Activity
{
    private double _speed;

    public Cycling(int year, int month, int day, int lengthMinutes, double speed) : base(year, month, day, lengthMinutes)
    {
        _speed = speed;
    }

    protected override double GetSpeed()
    {
        return _speed;
    }

    protected override string GetActivityType()
    {
        return "Cycling";
    }
}