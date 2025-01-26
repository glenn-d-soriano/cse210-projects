public class Reference
{
    
    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int Verse { get; private set; }
    public int? EndVerse { get; private set; }  

    
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = null;  
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }

    
    public string GetDisplayText()
    {
        
        if (EndVerse.HasValue)
        {
            return $"{Book} {Chapter}:{Verse}-{EndVerse.Value}";
        }
        
        else
        {
            return $"{Book} {Chapter}:{Verse}";
        }
    }

    // key to remember override to display reference text
    public override string ToString()
    {
        return GetDisplayText();
    }
}