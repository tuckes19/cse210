public class EternalGoal : Goal
{
    // Attributes.


    // Constructors.
    public EternalGoal()
    {

    }

    // Methods.
    public override void CreateGoalFromUser()
    {
        _goalType = "EternalGoal";
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Convert.ToInt32(Console.ReadLine());
    }
    public override void LoadGoal(string[] list)
    {
        _goalType = list[0];
        _name = list[1];
        _description = list[2];
        _points = Convert.ToInt32(list[3]);
        _completed = BoolCompletionStatus(list[4]);
    }
}