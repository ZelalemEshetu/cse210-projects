using System;

class Cycling : Activity
{
    private double _distance; // in km

    public Cycling(DateTime date, double length, double distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => _distance / (GetLength() / 60); // km/h
    public override double GetPace() => GetLength() / _distance;          // min/km
}
