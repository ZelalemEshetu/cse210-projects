using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual void Display()
    {
        Console.WriteLine($"{_name} ({_description}) - {_points} pts");
    }

    public virtual int RecordEvent()
    {
        return _points;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string SaveString()
    {
        return $"{GetType().Name}|{_name}|{_description}|{_points}";
    }
}
