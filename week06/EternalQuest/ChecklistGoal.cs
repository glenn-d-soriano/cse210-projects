public class ChecklistGoal : Goal
{
    public int RequiredCompletions { get; set; }
    public int TotalCompletions { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int requiredCompletions, int bonusPoints) : base(name, points)
    {
        RequiredCompletions = requiredCompletions;
        BonusPoints = bonusPoints;
        TotalCompletions = 0;
    }

    public override void RecordEvent()
    {
        if (TotalCompletions < RequiredCompletions)
        {
            TotalCompletions++;
        }
    }

    public override void DisplayGoal()
    {
        Console.WriteLine($"[ ] {Name} (Checklist Goal) - {Points} points per event");
        Console.WriteLine($"Completed {TotalCompletions}/{RequiredCompletions} times");
        if (TotalCompletions == RequiredCompletions)
        {
            Console.WriteLine($"Bonus: {BonusPoints} points");
        }
    }

    public override int GetScore()
    {
        int score = Points * TotalCompletions;
        if (TotalCompletions >= RequiredCompletions)
        {
            score += BonusPoints;
        }
        return score;
    }
}
