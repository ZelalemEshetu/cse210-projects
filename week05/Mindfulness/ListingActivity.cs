using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    public ListingActivity(string name, string description, int duration)
        : base(name, description, duration) { }

    public void DoListing()
    {
        StartActivity();
        Console.WriteLine("List as many items as you can in your mind:");
        List<string> items = new List<string>();
        var endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
                items.Add(item);
        }
        Console.WriteLine($"You listed {items.Count} items!");
        EndActivity();
    }
}
