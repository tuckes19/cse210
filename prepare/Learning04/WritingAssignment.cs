public class WritingAssignment : Assignment
{
    // Attributes.
    string _title;

    // Constructors.
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // Methods.
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}