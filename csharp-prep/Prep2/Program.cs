using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that determines the letter grade for a course

        // Ask user for grade percentage, convert answer to int
        Console.Write("Grade Percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Create variable for letter grade and for sign
        string letter;
        string sign = "";
                      
        // Get the letter grade according to the gradePercentage
        if (gradePercentage >= 90)
        {
            letter = "A"; 
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        // Get the letter sign following the logic:
        // "+" if last digit is >= 7 and "-" if last digit is < 3
        // Keep in mind that there are no "A+", "F-", or "F+"
        int lastDigit = gradePercentage % 10;

        if (lastDigit >= 7 && !(letter == "A" || letter == "F"))
        {
            sign = "+";
        }
        else if (lastDigit < 3 && letter != "F")
        {
            sign = "-";
        }

        // Print Letter Grade and sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}