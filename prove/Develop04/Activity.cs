public class Activity
{
    // Attributes.
    private List<string> _descriptions = new List<string>()
    {
        "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    };

    // Constructors.
    public Activity()
    {
    
    }

    // Methods.
    public void DisplayIntroduction(int index, string activity)
    {
        Console.WriteLine($"Welcome to the {activity}.");
        Console.WriteLine("");
        Console.WriteLine($"{_descriptions[index]}");
        Console.WriteLine("");
    }
    public int ActivityDuration()
    {
        Console.Write($"How long, in seconds, would you like for your session? ");
        int duration = Convert.ToInt32(Console.ReadLine());
        return duration;
    }

    public void DisplayFinish(int duration, string activity)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Great job!");
        Thread.Sleep(3000);
        Console.WriteLine(" ");
        Console.WriteLine($"You have completed the {activity}. You did this activity for {duration} seconds.");
        Console.WriteLine(" ");
    }
    public void DisplayRandomPrompt(List<string> prompt)
    {
        var _random = new Random();
        int randomNumber = _random.Next(0, prompt.Count());
        string randomPrompt = prompt[randomNumber];
        Console.WriteLine(randomPrompt);
    }
    public void SpinnerAnimation()
    {
        DateTime startTime = DateTime.Now;
        TimeSpan duration = TimeSpan.FromSeconds(5);

        while (DateTime.Now - startTime < duration)
        {
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }
}