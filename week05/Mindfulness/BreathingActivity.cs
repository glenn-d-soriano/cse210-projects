public class BreathingActivity : MindfulnessActivity
{
    protected override void ExecuteActivity()
    {
        Console.Clear();
        Console.WriteLine("This activity will help you relax by guiding you through deep breathing.");
        for (int i = 0; i < durationInSeconds / 5; i++)  // Breathing lasts for durationInSeconds
        {
            Console.WriteLine("Breathe in...");
            Pause();
            Console.WriteLine("Breathe out...");
            Pause();
        }
    }
}
