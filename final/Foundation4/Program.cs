using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(2023, 10, 03, 60, 5);
        Cycling cycling = new Cycling(2023, 11, 08, 80, 15);
        Swimming swimming = new Swimming(2023, 12, 09, 45, 60);

        List<Activity> activities = new List<Activity>
        {
            running, cycling, swimming
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}