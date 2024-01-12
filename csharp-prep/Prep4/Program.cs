using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;

        // Create an instance of the List<int> class
        List<int> numbers = new List<int>();

        // Ask user for numbers until they exit by typing 0
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Compute sum and min positive number
        double sum = 0;
        int largestNumber = numbers.Max();
        int minPositive = largestNumber;
        foreach (int num in numbers)
        {
            sum += num;

            if (num < minPositive && num > 0)
            {
                minPositive = num;
            }
        }

        // Compute average
        double average = sum / numbers.Count;

        // Display all info required
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {minPositive}");

        // Sort and display list
        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }


    }
}