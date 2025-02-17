public class ListingActivity : MindfulnessActivity
{
    private static readonly string[] prompts = 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override void ExecuteActivity()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Pause();

        Console.WriteLine("Start listing now! Press 'Enter' after each item.");
        int itemsListed = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_durationInSeconds);
        
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                itemsListed++;
            }
        }

        Console.WriteLine($"You listed {itemsListed} items!");
    }
}
