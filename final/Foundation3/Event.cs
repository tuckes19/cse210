public abstract class Event
{
    // Attributes.
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected int _time;
    protected Address _address;

    // Constructors.
    public Event(string eventType, string eventTitle, string description, string date, int time, Address address)
    {
        _eventType = eventType;
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // Methods.
    public void ListStandardDetails()
    {
        Console.WriteLine("Standard Details");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.FullAddress()}");
        Console.WriteLine();
    }
    public abstract void ListFullDetails();
    public void ListShortDescription()
    {
        Console.WriteLine("Short Description");
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine();
    }

}