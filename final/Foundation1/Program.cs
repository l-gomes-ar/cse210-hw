using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video perfectPancakes = new Video("10 Tips for Perfect Pancakes", "ChefMastery", 460);
        Video adventureVlog = new Video("Exploring Hidden Waterfalls: Adventure Vlog", "WanderlustJourney", 900);
        Video yogaBeginners = new Video("10 Minute Yoga Flow for Beginners", "YogaWithJosh", 600);
        Video diyTutorial = new Video("DIY Succulent Terrarium Tutorial", "GreenDIY", 720);

        // Add Comments
        perfectPancakes.AddComment("Emily", "Wow, these tips really upped my pancake game! Thanks, ChefMastery!");
        perfectPancakes.AddComment("Jake92", "I've been struggling with pancakes forever, but this video made it so easy to understand. Great job!");
        perfectPancakes.AddComment("PancakeQueen", "Can't wait to try these tips out for brunch tomorrow!");
        perfectPancakes.AddComment("CookingNovice21", "I never knew you could do so much to make pancakes better. This was super helpful!");

        adventureVlog.AddComment("TravelerGirl23", "This video inspired me to go on my own waterfall adventure. So beautiful!");
        adventureVlog.AddComment("AdventureSeeker87", "WanderlustJourney always finds the most amazing spots! Definitely adding this to my bucket list.");
        adventureVlog.AddComment("NatureLover99", "Watching this is like going on a virtual hike! Thanks for sharing your adventures with us.");
        adventureVlog.AddComment("OutdoorExplorer45", "Absolutely stunning footage! Can't wait to explore these hidden gems myself.");

        yogaBeginners.AddComment("ZenMaster33", "Exactly what I needed to start my day on the right foot. Thank you!");
        yogaBeginners.AddComment("YogaNewbie22", "This was gentle yet effective. Feeling so relaxed and energized!");
        yogaBeginners.AddComment("StretchySara", "I struggle with yoga, but this was perfect for beginners like me. Grace, you're a lifesaver!");
        yogaBeginners.AddComment("MindfulMomma", "I've been wanting to try yoga, and this video made it seem so accessible. Loved it!");

        diyTutorial.AddComment("PlantLover45", "Finally, a tutorial that's easy to follow! Can't wait to make my own terrarium now.");
        diyTutorial.AddComment("DIYEnthusiast22", "I've been wanting to try my hand at making a terrarium, and this video broke it down perfectly. Thank you!");
        diyTutorial.AddComment("SucculentObsessed", "GreenThumbDIY, you're my hero! Now I know what to do with all those succulents I've been collecting.");
        diyTutorial.AddComment("CraftyGardener", "This was so creative and fun! Can't wait to get my hands dirty and make one for myself.");

        // Create a list of videos, and add the videos created
        List<Video> videos = new List<Video>
        {
            perfectPancakes, adventureVlog, yogaBeginners, diyTutorial
        };

        // Iterate through list, display info and commments
        foreach (Video video in videos)
        {
            video.DisplayInfo();
            Console.WriteLine();

            video.DisplayComments();
            Console.WriteLine();
        }
    }
}