using System;

abstract class Activity
{
    private DateTime _date;
    private double _length; // in minutes

    public Activity(DateTime date, double length)
    {
        _date = date;
        _length = length;
    }

    public DateTime GetDate() => _date;
    public double GetLength() => _length;

    // Abstract methods to override in derived classes
    public abstract double GetDistance();  // e.g., km
    public abstract double GetSpeed();     // e.g., km/h
    public abstract double GetPace();      // e.g., min/km

    // Virtual method calling abstract methods
    public virtual string GetSummary()
    {
        return $"{GetDate().ToShortDateString()} | Distance: {GetDistance():0.00} km | Speed: {GetSpeed():0.00} km/h | Pace: {GetPace():0.00} min/km";
    }
}
