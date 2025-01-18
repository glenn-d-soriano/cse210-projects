public class Entry
{
    // Use DateTime for the date property for more accurate information
    public DateTime Date { get; set; }  
    public string PromptText { get; set; }
    public string EntryText { get; set; }

    
    public Entry(DateTime date, string promptText, string entryText)
    {
        Date = date; 
        PromptText = promptText;
        EntryText = entryText;
    }

    // Display method for each entry
    public void Display()
    {
        Console.WriteLine($"Date: {Date.ToShortDateString()}");  // Displaying the DateTime as a short date string
        Console.WriteLine($"Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
    }

    // ToString method to output the entry in string format
    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {PromptText}\n{EntryText}\n";
    }
}
