using System;

class Program
{
    static void Main(string[] args)
    {
        // Step 4
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        // Step 5
        Fraction fraction4 = new Fraction();
        fraction4.SetTop(3);
        Console.WriteLine(fraction4.GetTop());
        fraction4.SetBottom(4);
        Console.WriteLine(fraction4.GetBottom());
        Console.WriteLine();

        // Step 6
        Fraction fraction5 = new Fraction();
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());

        fraction5.SetTop(5);
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());

        fraction5.SetTop(3);
        fraction5.SetBottom(4);
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());

        fraction5.SetTop(1);
        fraction5.SetBottom(3);
        Console.WriteLine(fraction5.GetFractionString());
        Console.WriteLine(fraction5.GetDecimalValue());
    }
}