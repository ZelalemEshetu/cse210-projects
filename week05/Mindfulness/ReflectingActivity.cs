using System;

public class ReflectingActivity : Activity
{
    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration) { }

    public void DoReflecting()
    {
        StartActivity();
        Console.WriteLine("Think about a positive experience...");
        System.Threading.Thread.Sleep(_duration * 1000);
        EndActivity();
    }
}
