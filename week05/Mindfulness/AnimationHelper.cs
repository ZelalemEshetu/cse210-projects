using System;
using System.Threading;

public static class AnimationHelper
{
    /// <summary>
    /// Displays a spinner animation for a given number of seconds
    /// </summary>
    /// <param name="seconds">Duration in seconds</param>
    public static void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int totalSteps = seconds * 4; // 4 steps per second
        for (int i = 0; i < totalSteps; i++)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    /// <summary>
    /// Displays a countdown from a given number of seconds
    /// </summary>
    /// <param name="seconds">Seconds to countdown</param>
    public static void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"Starting in {i} ");
            ShowSpinner(1); // 1-second spinner for each number
            Console.Write("\r"); // overwrite the line
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Pauses the program for the specified number of seconds
    /// </summary>
    /// <param name="seconds">Number of seconds to pause</param>
    public static void Pause(int seconds)
    {
        Thread.Sleep(seconds * 1000);
    }
}
