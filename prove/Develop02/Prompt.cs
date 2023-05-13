public class Prompt
{
    public List<string> _prompts = new List<string>()
    {
        "What was the craziest thing that happened to me today?",
        "What was your biggest setback today and how will you rebound from it?",
        "When did God bless you the most today?",
        "Describe the most attractive girl you saw/met today.",
        "What did you learn today that you will teach your children?"
    };
    
    private string _prompt;

    public Prompt()
    {
        
    }

    public string GetRandomPrompt()
    {
        var _random = new Random();
        int randomNumber = _random.Next(0, _prompts.Count());
        string randomPrompt = _prompts[randomNumber];
        return randomPrompt;
    }

}