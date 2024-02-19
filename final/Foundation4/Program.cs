using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(2022, 11, 03, 30, 3.0);
        Cycling cycling = new Cycling(2023, 11, 08, 90, 20);
        Swimming swimming = new Swimming(2023, 11, 09, 45, 72);

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