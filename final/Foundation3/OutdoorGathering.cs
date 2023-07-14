public class OutdoorGathering : Event
{
    // Attributes.
    string _weather;

    // Constructors.
    public OutdoorGathering(string eventType, string eventTitle, string description, string date, int time, Address address, string weather) : base(eventType, eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    // Methods.
    public override void ListFullDetails()
    {
        Console.WriteLine("Full Details");
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.FullAddress()}");
        Console.WriteLine($"Weather: {_weather}");
        Console.WriteLine();
    }
    
}