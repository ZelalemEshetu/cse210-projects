using System;

class Running : Activity
{
    private double _distance; // in km

    public Running(DateTime date, double length, double distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => _distance / (GetLength() / 60); // km/h
    public override double GetPace() => GetLength() / _distance;          // min/km
}
