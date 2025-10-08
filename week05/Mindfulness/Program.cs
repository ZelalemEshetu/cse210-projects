using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity("Breathing", "Focus on your breath.", 20);
        ListingActivity listing = new ListingActivity("Listing", "List things that make you happy.", 20);
        ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "Reflect on your accomplishments.", 20);

        breathing.DoBreathing();
        listing.DoListing();
        reflecting.DoReflecting();
    }
}

