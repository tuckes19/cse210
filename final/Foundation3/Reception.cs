public class Reception : Event
{
    // Attributes.
    string _rsvp;

    // Constructors.
    public Reception(string eventType, string eventTitle, string description, string date, int time, Address address, string rsvp) : base(eventType, eventTitle, description, date, time, address)
    {
        _rsvp = rsvp;
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
        Console.WriteLine($"RSVP Email: {_rsvp}");
        Console.WriteLine();
    }
    
}