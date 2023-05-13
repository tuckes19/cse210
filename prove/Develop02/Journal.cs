public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    private string _entry;

    public Journal()
    {
        
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
}