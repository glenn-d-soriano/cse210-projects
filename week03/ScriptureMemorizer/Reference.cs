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