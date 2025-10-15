public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void Display()
    {
        string status = _timesCompleted >= _target ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {_name} ({_description}) - {_points} pts each, {_timesCompleted}/{_target} times, Bonus: {_bonus}");
    }

    public override int RecordEvent()
    {
        if (_timesCompleted < _target)
        {
            _timesCompleted++;
            if (_timesCompleted == _target)
                return _points + _bonus;
            return _points;
        }
        return 0;
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _target;
    }
}
