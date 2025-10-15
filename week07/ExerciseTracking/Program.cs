using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store all activities
        List<Activity> activities = new List<Activity>();

        // Add instances of each activity
        activities.Add(new Running(DateTime.Now, 30, 5));         // Running: 30 min, 5 km
        activities.Add(new Swimming(DateTime.Now, 60, 40, 25));   // Swimming: 60 min, 40 laps, 25 m pool
        activities.Add(new Cycling(DateTime.Now, 45, 20));        // Cycling: 45 min, 20 km

        // Display summary for each activity
        Console.WriteLine("Exercise Tracking Summary:");
        Console.WriteLine("------------------------------------");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
