public class Assignment
{
    private String _studentName;
    private String _topic;

    public Assignment (string _studentName, string _topic)
    {

        _studentName = _studentName;
        _topic = _topic;
    
    }

    public string Getsummary()
    {

        return $"{_studentName} - {_topic}";
    }
}