public class Word
{
    public string Text { get; private set; }
    private bool _isHidden;

    
    public Word(string text)
    {
        Text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Show the word
    public void Show()
    {
        _isHidden = false;
    }

    
    public bool IsHidden() => _isHidden;

    
    public string GetDisplayText() => _isHidden ? new string('_', Text.Length) : Text;
}
