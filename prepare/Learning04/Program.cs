using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assign0 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assign0.GetSummary());
        Console.WriteLine();

        MathAssignment assign1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assign1.GetSummary());
        Console.WriteLine(assign1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment assign2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetWritingInformation());

    }
}