using System;

class Program
{
    static void Main(string[] args)
    {
        // Create one event of each type
        Lecture lecture = new Lecture
        (
            "Exploring the Cosmos: A Journey Through Space and Time",
            "Join us for an enlightening evening as Dr. Emily Thompson,\nrenowned astrophysicist takes us on a captivating journey through the cosmos.\nDiscover the wonders of the universe, from distant galaxies\nto elusive black holes, and unravel the mysteries of space and time.",
            "March 10, 2024",
            "7:00 PM - 9:00 PM",
            "Dr. Emily Thompson",
            100
        );
        lecture.AddAddress("Kepler Auditorium, 123 Observatory Way", "Cityville", "ST", "United States");
        
        Reception reception = new Reception
        (
            "Artisanal Delights: A Taste of Local Flavors",
            "Indulge your senses in an evening of culinary delight featuring \nan array of artisanal creations crafted by local chefs. Savor exquisite\nflavors, mingle with fellow food enthusiasts, and immerse\nyourself in a celebration of gastronomy.",
            "April 5, 2024",
            "6:30 PM - 8:30 PM",
            "rsvp@localflavors.com"
        );
        reception.AddAddress("456 Gourmet Avenue", "Townsville", "ST", "United States");

        Outdoor outdoor = new Outdoor
        (
            "Spring Fling Picnic: Embracing Nature's Beauty",
            "Join us for a delightful afternoon amidst nature's splendor as \nwe celebrate the arrival of spring. Bring your blankets and baskets for\na relaxed picnic in the park, surrounded by blooming flowers,\nchirping birds, and the gentle warmth of the sun.",
            "May 15, 2024",
            "12:00 PM - 3:00 PM",
            "The weather forecast predicts a sunny day with a high of 70°F (21°C) and gentle breezes."
        );
        outdoor.AddAddress("Picnic Area A, 789 Nature Trail", "Greenfield", "England", "United Kingdom");

        // For each event call each of the marketing messages
        List<Event> events = new List<Event>
        {
            lecture, reception, outdoor
        };

        Console.Clear();
        Console.WriteLine("Standard Details:\n");
        foreach (Event ev in events)
        {
            ev.DisplayStandardDetails();
            Console.WriteLine();
        }

        Console.WriteLine("Full Details:\n");
        foreach (Event ev in events)
        {
            ev.DisplayFullDetails();
            Console.WriteLine();
        }

        Console.WriteLine("Short Description:\n");
        foreach (Event ev in events)
        {
            ev.DisplayShortDescription();
            Console.WriteLine();
        }
    }
}