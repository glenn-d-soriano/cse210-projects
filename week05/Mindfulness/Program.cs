using System;
using System.Threading;

public class MindfulnessActivity
{
    protected int durationInSeconds; // This will hold the duration for each activity.

    // This method starts the activity, asks the user for the duration, and prepares them to start.
    public void StartActivity(string activityName, string description)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {activityName} Activity!");
        Console.WriteLine(description);
        Console.Write("Please enter the duration (in seconds): ");
        durationInSeconds = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to begin...");
        Pause(3); // Pause for 3 seconds before starting the activity.
    }

    // This method pauses the program for a specified number of seconds, showing "..." to the user.
    public void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000); // Wait for 1 second
        }
        Console.WriteLine();
    }

    // This method ends the activity and shows a message with the duration.
    public void EndActivity()
    {
        Console.WriteLine("Great job! You've completed the activity.");
        Pause(3);
        Console.WriteLine($"You spent {durationInSeconds} seconds on this activity.");
        Pause(3);
    }
}
