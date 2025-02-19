public class EternalGoal : Goal
{
    public int TimesCompleted { get; set; }

    public EternalGoal(string name, int points) : base(name, points)
    {
        TimesCompleted = 0;
    }

    public override void RecordEvent()
    {
        TimesCompleted++;
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Name} (Eternal Goal) - {Points} points per event");
        Console.WriteLine($"Completed {TimesCompleted} times.");
    }

    public override int GetScore()
    {
        return Points * TimesCompleted;
    }
}
