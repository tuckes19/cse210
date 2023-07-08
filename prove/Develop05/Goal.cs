public abstract class Goal
{
    // Attributes.
    protected string _goalType;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed = false;
    protected int _timesCompleted = 0;
    protected int _timesNeeded = 0;
    protected int _bonus = 0;

    // Constructors.
    public Goal()
    {
        
    }

    // Methods.
    public string GetGoalType()
    {
        return _goalType;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool GetCompletionStatus()
    {
        return _completed;
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }
    public int GetTimesNeeded()
    {
        return _timesNeeded;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void CompleteGoal()
    {
        _completed = true;
    }
    public string StringCompletionStatus()
    {
        if (_completed)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }
    public bool BoolCompletionStatus(string stringCompletionStatus)
    {
        if (stringCompletionStatus == " ")
        {
            _completed = false;
            return _completed;
        }
        else
        {
            _completed = true;
            return _completed;
        }
    }
    public abstract void CreateGoalFromUser();
    public abstract void LoadGoal(string[] list);
}