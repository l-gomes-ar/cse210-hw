public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void Run()
    {
        DisplayStartingMessage();

        // Run main part of activity
        DateTime startTime = DateTime.Now;
        int roundedSeconds = ((GetDuration() + 5) / 10) * 10;
        DateTime endTime = startTime.AddSeconds(roundedSeconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine("\n");

            Console.Write("Now Breathe out... ");
            ShowCountDown(6);
            Console.WriteLine("\n");
        }

        DisplayEndingMessage();
    }
}