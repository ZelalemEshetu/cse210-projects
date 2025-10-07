using System;

public class Activity
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}: {_description}");
        Console.WriteLine($"Duration: {_duration} seconds.\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Finished {_name}.\n");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
