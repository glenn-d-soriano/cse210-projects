using System;

//added random list of scripture for extra points
public class Program
{
    public static void Main(string[] args)
    {
        // Scripture reference list
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16, 17),
                          "For God so loved the world that He gave His only begotten Son, that whoever believes in Him should not perish but have everlasting life."),
            new Scripture(new Reference("Psalm", 23, 1),
                          "The Lord is my shepherd; I shall not want."),
            new Scripture(new Reference("Matthew", 5, 3),
                          "Blessed are the poor in spirit, for theirs is the kingdom of heaven."),  
        };                  

        Scripture selectedScripture = scriptureLibrary[rand.Next(scriptureLibrary.Count)];

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

            selectedScripture.HideRandomWord(rand);

            
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

        
        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nAll words are hidden. Memorization complete!");
        }
    }
}
