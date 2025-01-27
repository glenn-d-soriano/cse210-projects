using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference ScriptureReference { get; private set; }
    private List<Word> Words { get; set; }
    

    // Constructor for scripture with reference and text
    public Scripture(Reference reference, string text)
    {
        ScriptureReference = reference;
        Words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (var word in wordArray)
        {
            Words.Add(new Word(word));
        }
    
    }

    public string GetDisplayText()
    {
        List<string> displayedWords = new List<string>();   

        foreach (var word in Words)
        {
            displayedWords.Add(word.GetDisplayText()); 
            
        }
        return $"{ScriptureReference}\n{string.Join(" ", displayedWords)}";
        
    }

    public void HideRandomWord(Random rand)
    {
        int index;
        do
        {
            index = rand.Next(Words.Count);  
        } while (Words[index].IsHidden());

        Words[index].Hide();
    }

    
    public bool IsCompletelyHidden()
    {
        foreach (var word in Words)
        {
            if (!word.IsHidden())  
            {
                return false;  
            }
        }
        return true;  
    }
    
}    