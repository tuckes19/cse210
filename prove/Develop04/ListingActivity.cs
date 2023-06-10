public class ListingActivity : Activity
{
    // Attributes.
    List<string> _questions = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructors.
    public ListingActivity()
    {

    }

    // Methods.
    public List<string> GetQuestion()
    {
        return _questions;
    }
    public void BuildList(List<string> list)
    {
        Console.Write("");
        string item = Console.ReadLine();
        list.Add(item);
    }
}