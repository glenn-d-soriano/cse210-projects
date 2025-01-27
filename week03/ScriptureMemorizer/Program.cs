using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Scripture reference
        string reference = "John 3:16-17";
        string text = "For God so loved the world that He gave His only begotten Son, that whoever believes in Him should not perish but have everlasting life.";

        Reference scriptureReference = new Reference("John", 3, 16, 17);
        Scripture scripture = new Scripture(scriptureReference, text);

        
        Console.WriteLine("Scripture to memorize:");
        Console.WriteLine(scripture.GetDisplayText());

        Random rand = new Random();

        // Hide some words and display the updated scripture
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to hide a random word, or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            
            scripture.HideRandomWord(rand);

            
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

        
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nAll words are hidden. Memorization complete!");
        }
    }
}
