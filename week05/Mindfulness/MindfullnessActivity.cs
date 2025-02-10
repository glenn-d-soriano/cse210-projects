using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected int durationInSeconds;

    public void Start()
    {
        DisplayStartMessage();
        SetDuration();
        PauseForPreparation();
        ExecuteActivity();
        DisplayEndMessage();
    }

    // Method to display the starting message
    protected void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine("Starting mindfulness activity...");
        Console.WriteLine("This activity will help you relax and reflect. Let's begin!");
    }

    // Method to set the duration of the activity
    private void SetDuration()
    {
        Console.Write("Please enter the duration of the activity in seconds: ");
        durationInSeconds = int.Parse(Console.ReadLine());
    }

    // Method to pause before starting the activity
    private void PauseForPreparation()
    {
        Console.WriteLine("Prepare yourself... starting in a few seconds.");
        for (int i = 3; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    // Abstract method to be overridden in derived classes to execute the activity
    protected abstract void ExecuteActivity();

    // Method to display the end message
    protected void DisplayEndMessage()
    {
        Console.WriteLine("Well done! You've completed the activity.");
        Console.WriteLine($"You spent {durationInSeconds} seconds on this activity.");
        Thread.Sleep(2000); 
    }

    // Method to simulate a pause (animation, spinner, or countdown)
    protected void Pause()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
    }
}
