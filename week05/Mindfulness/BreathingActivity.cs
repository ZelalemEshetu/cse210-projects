using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration) { }

    public void DoBreathing()
    {
        StartActivity();
        for (int i = 0; i < _duration / 4; i++)
        {
            Console.WriteLine("Breathe in...");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Breathe out...");
            System.Threading.Thread.Sleep(2000);
        }
        EndActivity();
    }
}
