using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Breathing Activity
        BreathingActivity breathing = new BreathingActivity("Breathing", "Breathing Exercise", 10);
        breathing.Run();

        // Listing Activity
        List<string> listingPrompts = new List<string>
        {
            "List 3 things you are grateful for",
            "List 3 things that made you happy today"
        };
        ListingActivity listing = new ListingActivity("Listing", "Listing Exercise", 15, listingPrompts);
        listing.Run();

        // Reflecting Activity
        List<string> reflectingPrompts = new List<string>
        {
            "Think about a happy memory",
            "Think about a personal achievement"
        };
        List<string> questions = new List<string>
        {
            "Why was it special?",
            "How did it make you feel?",
            "What did you learn from it?"
        };
        ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "Reflection Exercise", 15, reflectingPrompts, questions);
        reflecting.Run();

        Console.WriteLine("All activities completed. Press any key to exit.");
        Console.ReadKey();
    }
}
