//Created better animation to show creativity and exceed requirements
public class BreathingActivity : MindfulnessActivity
{
    protected override void ExecuteActivity()
    {
        Console.Clear();
        Console.WriteLine("This activity will help you relax by guiding you through deep breathing.");
        
        // Calculate number of cycles (e.g., 5-second intervals)
        int cycles = durationInSeconds / 5; 

        for (int i = 0; i < cycles; i++)
        {
            // Breathe in animation (4 seconds)
            Console.Clear();
            Console.WriteLine("Breathe in...");
            for (int j = 0; j < 4; j++) // Breathe in for 4 seconds
            {
                Console.Write(".");
                Thread.Sleep(1000); // Wait 1 second between each dot
            }
            Pause();

            // Breathe out animation (4 seconds)
            Console.Clear();
            Console.WriteLine("Breathe out...");
            for (int j = 0; j < 4; j++) // Breathe out for 4 seconds
            {
                Console.Write(".");
                Thread.Sleep(1000); // Wait 1 second between each dot
            }
            Pause();
        }

        Console.WriteLine("Well done! You've completed the breathing activity.");
    }
}

