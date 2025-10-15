using System;

class Swimming : Activity
{
    private int _laps;
    private double _poolLength; // in meters

    public Swimming(DateTime date, double length, int laps, double poolLength)
        : base(date, length)
    {
        _laps = laps;
        _poolLength = poolLength;
    }

    public override double GetDistance() => (_laps * _poolLength) / 1000.0; // km
    public override double GetSpeed() => GetDistance() / (GetLength() / 60); // km/h
    public override double GetPace() => GetLength() / GetDistance();          // min/km
}
