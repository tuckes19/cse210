public class BreathingActivity : Activity
{
    // Attributes.
    List<int> _breatheInCounter = new List<int>()
    {
        4, 3, 2, 1
    };
    List<int> _breatheOutCounter = new List<int>()
    {
        6, 5, 4, 3, 2, 1
    };

    // Constructors.
    public BreathingActivity()
    {
    
    }

    // Methods.
    public void DisplayBreatheIn()
    {
        Console.WriteLine("");
        Console.Write("Breathe in... ");
        foreach (int number in _breatheInCounter)
        {
            Console.Write($"{number}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine(" ");
    }
    public void DisplayBreatheOut()
    {
        Console.Write("Breathe out... ");
        foreach (int number in _breatheOutCounter)
        {
            Console.Write($"{number}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine(" ");
    }
}