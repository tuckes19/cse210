public class Lecture : Event
{
    // Attributes.
    string _speaker;
    int _capacity;

    // Constructors.
    public Lecture(string eventType, string eventTitle, string description, string date, int time, Address address, string speaker, int capacity) : base (eventType, eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Methods.
    public string GetSpeaker()
    {
        return _speaker;
    }
    public int GetCapacity()
    {
        return _capacity;
    }
    public override void ListFullDetails()
    {
        Console.WriteLine("Full Details");
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.FullAddress()}");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
        Console.WriteLine();
    }

    
}