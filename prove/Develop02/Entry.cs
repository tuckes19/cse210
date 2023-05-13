public class Entry
{
    List<Prompt> _prompts = new List<Prompt>();

    // I made these public to make my program work,
    // but I don't know if that's the best practice
    // going forward.
    public string _datetime;
    public string _prompt;
    public string _maintext;
    public string _emotion;
    public string _rating;

    public Entry(string prompt, string text, string emotion, string rating)
    {
        _prompt = prompt;
        _maintext = text;
        _emotion = emotion;
        _rating = rating;
        _datetime = TodayDate();
    }

    public string TodayDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return dateText;
    }
}