using System;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration; // in seconds

    public Activity(string name, string description, int duration)
    {
        _activityName = name;
        _description = description;
        _duration = duration;
    }

    public void StartActivity()
    {
        Console.WriteLine($"\nStarting {_activityName}...");
        Console.WriteLine(_description);
        ShowAnimation(3); // optional countdown before starting
    }

    public void EndActivity()
    {
        Console.WriteLine($"\nEnding {_activityName}. Good job!");
        ShowAnimation(2); // optional
    }

    protected void ShowAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b-");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b\\");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b|");
            System.Threading.Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.WriteLine();
    }
}
