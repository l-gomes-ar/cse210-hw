using System;

class Program
{
    static void Main(string[] args)
    {
        // Create one event of each type
        Lecture lecture = new Lecture
        (
            "Exploring the Cosmos: A Journey Through Space and Time",
            "Discover the wonders of the universe, from distant galaxies to elusive black holes, and unravel the mysteries of space and time.",
            "March 10, 2024",
            "7:00 PM - 9:00 PM",
            "Dr. Emily Thompson",
            100
        );
        lecture.AddAddress("Kepler Auditorium, 123 Observatory Way", "Cityville", "ST", "United States");
        
        Reception reception = new Reception
        (
            "Artisanal Delights: A Taste of Local Flavors",
            "Indulge your senses in an evening of culinary delight featuring an array of artisanal creations crafted by local chefs.",
            "April 5, 2024",
            "6:30 PM - 8:30 PM",
            "rsvp@localflavors.com"
        );
        reception.AddAddress("456 Gourmet Avenue", "Townsville", "ST", "United States");

        Outdoor outdoor = new Outdoor
        (
            "Spring Fling Picnic: Embracing Nature's Beauty",
            "Join us for a delightful afternoon amidst nature's splendor as we celebrate the arrival of spring.",
            "May 15, 2024",
            "12:00 PM - 3:00 PM",
            "The weather forecast predicts a sunny day with a high of 70°F (21°C) and gentle breezes."
        );
        outdoor.AddAddress("Picnic Area A, 789 Nature Trail", "Greenfield", "England", "United Kingdom");

        // For each event call each of the marketing messages:
        
        // Lecture
        Console.WriteLine("\nStandard Details:\n");
        lecture.DisplayStandardDetails();

        Console.WriteLine("\nFull Details:\n");
        lecture.DisplayFullDetails();

        Console.WriteLine("\nShort Description:\n");
        lecture.DisplayShortDescription();

        // Reception
        Console.WriteLine("\nStandard Details:\n");
        reception.DisplayStandardDetails();

        Console.WriteLine("\nFull Details:\n");
        reception.DisplayFullDetails();

        Console.WriteLine("\nShort Description:\n");
        reception.DisplayShortDescription();

        // Outdoor Gathering
        Console.WriteLine("\nStandard Details:\n");
        outdoor.DisplayStandardDetails();

        Console.WriteLine("\nFull Details:\n");
        outdoor.DisplayFullDetails();

        Console.WriteLine("\nShort Description:\n");
        outdoor.DisplayShortDescription();
    }
}