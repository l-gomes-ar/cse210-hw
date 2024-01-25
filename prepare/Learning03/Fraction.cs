// Step 3
public class Fraction 
{
    private int _top;
    private int _bottom;

    // Step 4: Constructors
    public Fraction() 
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) 
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Step 5: Create Getters and Setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Step 6: Create Methods
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double) _top / (double) _bottom;
    }
}