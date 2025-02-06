public class Assignment
{
    private String _studentName;
    private String _topic;

    public Assignment (string studentName, string topic)
    {

        _studentName = studentName;
        _topic = topic;
    
    }

    public string GetSummary()
    {

        return $"{_studentName} - {_topic}";
    }
    public string GetStudentName()  
    {
        return _studentName;
    }
}