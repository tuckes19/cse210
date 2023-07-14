using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("Running", "July 12, 2023", 37.5, 4);
        Cycling cycling = new Cycling("Cycling", "July 13, 2023", 45, 20);
        Swimming swimming = new Swimming("Swimming", "July 14, 2023", 15, 5);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}