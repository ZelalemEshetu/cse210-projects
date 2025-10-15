public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) {}

    public override void Display()
    {
        Console.WriteLine($"[∞] {_name} ({_description}) - {_points} pts each time");
    }

    public override int RecordEvent()
    {
        return _points; // Can repeat indefinitely
    }
}
