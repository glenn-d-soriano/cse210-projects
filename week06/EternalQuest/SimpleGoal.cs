public class SimpleGoal : Goal
{
    public bool IsCompleted { get; set; }

    public SimpleGoal(string name, int points) : base(name, points)
    {
        IsCompleted = false;
    }

    public override void RecordEvent()
    {
        IsCompleted = true; // Simple goals are completed when recorded
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Name} (Simple Goal) - {Points} points");
        if (IsCompleted)
        {
            Console.WriteLine($"[X] Completed");
        }
    }

    public override int GetScore()
    {
        return IsCompleted ? Points : 0;
    }
}
