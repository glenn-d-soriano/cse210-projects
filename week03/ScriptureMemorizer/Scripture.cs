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
    
}    