using System;


public class PromptGenerator
{
    private List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What made you happy today?",
            "What are you grateful for?",
            "Describe a recent challenge you faced and how you overcame it.",
            "What concept of C# are you having trouble with?",
            "Who is someone you look up to, and why?"
        };
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
