using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference ScriptureReference { get; private set; }
    private List<Word> Words { get; set; }
    private List<bool> IsHidden {get;set}

    // Constructor for scripture with reference and text
    public Scripture(Reference reference, string text)
    {
        ScriptureReference = reference;
        Words = new List<string>(tesxt.Split(''));
    }
    
    public string GetDisplayText()
        List<string> displayedWords = new List<string>();   

        foreach (var word in Words)
        {
            display.Words.Add(word.Contains("_") ? word : word);
            return $"{Reference}\n{string.Join(" ", displayedWords)}";
        }

        public void HideRandomWord(Random rand)
    {
        int index;
        do
        {
            index = rand.Next(Words.Count);  
        } while (Words[index].Contains("_"));  // Ensure the word isn't already hidden

        // Hide the word by replacing it with underscores
        Words[index] = new string('_', Words[index].Length);
    }

    
    public bool IsCompletelyHidden()
    {
        foreach (var word in Words)
        {
            if (!word.Contains("_"))  
            {
                return false;
            }
        }
        return true;  // All words are hidden
    }
    
}    