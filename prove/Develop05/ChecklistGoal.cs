public class ChecklistGoal : Goal
{
    // Attributes.


    // Constructors.
    public ChecklistGoal()
    {
        
    }

    // Methods.
    public override void CreateGoalFromUser()
    {
        _goalType = "ChecklistGoal";
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _timesNeeded = Convert.ToInt32(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = Convert.ToInt32(Console.ReadLine());
    }
    public override void LoadGoal(string[] list)
    {
        _goalType = list[0];
        _name = list[1];
        _description = list[2];
        _points = Convert.ToInt32(list[3]);
        _completed = BoolCompletionStatus(list[4]);
        _timesCompleted = Convert.ToInt32(list[5]);
        _timesNeeded = Convert.ToInt32(list[6]);
        _bonus = Convert.ToInt32(list[7]);
    }
}