public class Assignment
{
    // Attributes.
    protected string _studentName = "Default";
    string _topic;

    // Constructors.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Methods.
    public string GetSummary()
    {
        return $"{_studentName}, {_topic}";
    }
}