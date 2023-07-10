using System.IO;

class Menu
{
    // Attributes.
    protected List<Goal> _goals = new List<Goal>(){};
    protected string _separator = "~|~";
    private string _fileName;
    private int _goalCounter = 0;
    private string _userInput;
    private int _totalPoints = 0;

    // Constructors.
    public Menu()
    {

    }

    // Methods.
    public void DisplayMenu()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_totalPoints} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            _userInput = Console.ReadLine();
            Console.WriteLine("");

            switch (_userInput)
            {
                case "1":

                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("   1. Simple Goal");
                    Console.WriteLine("   2. Eternal Goal");
                    Console.WriteLine("   3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string goalCreate = Console.ReadLine();
                    Console.WriteLine("");

                    switch (goalCreate)
                    {
                        case "1":

                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.CreateGoalFromUser();
                            _goals.Add(simpleGoal);
                            break;

                        case "2":

                            EternalGoal eternalGoal = new EternalGoal();
                            eternalGoal.CreateGoalFromUser();
                            _goals.Add(eternalGoal);
                            break;

                        case "3":

                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            checklistGoal.CreateGoalFromUser();
                            _goals.Add(checklistGoal);
                            break;

                        default:
                            Console.WriteLine("That is not a valid response. Please enter a number 1-3 next time. ");
                            break;
                    }
                    Console.WriteLine("");

                    break;

                case "2":

                    _goalCounter = 0;
                    Console.WriteLine("The goals are: ");
                    foreach (Goal goal in _goals)
                    {
                        _goalCounter += 1;
                        if (goal.GetGoalType() == "SimpleGoal" || goal.GetGoalType() == "EternalGoal")
                        {
                            Console.WriteLine($"{_goalCounter}: [{goal.StringCompletionStatus()}] {goal.GetName()} ({goal.GetDescription()})");
                        }
                        else
                        {
                            Console.WriteLine($"{_goalCounter}: [{goal.StringCompletionStatus()}] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: {goal.GetTimesCompleted()}/{goal.GetTimesNeeded()}");
                        }                        
                    }
                    Console.WriteLine("");
                    break;

                case "3":

                    Console.Write("What is the file name for the goal file? ");
                    _fileName = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(_fileName))
                    {
                        outputFile.WriteLine($"{_totalPoints}");
                        foreach (Goal goal in _goals)
                        {
                            if (goal.GetTimesNeeded() <= 0)
                                outputFile.WriteLine($"{goal.GetGoalType()}{_separator}{goal.GetName()}{_separator}{goal.GetDescription()}{_separator}{goal.GetPoints()}{_separator}{goal.StringCompletionStatus()}");
                            else if (goal.GetTimesNeeded() > 0)
                                outputFile.WriteLine($"{goal.GetGoalType()}{_separator}{goal.GetName()}{_separator}{goal.GetDescription()}{_separator}{goal.GetPoints()}{_separator}{goal.StringCompletionStatus()}{_separator}{goal.GetTimesCompleted()}{_separator}{goal.GetTimesNeeded()}{_separator}{goal.GetBonus()}");
                        }
                    }
                    break;

                case "4":

                    Console.Write("What is the file name of the goal file? ");
                    _fileName = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(_fileName);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("~|~");

                        if (parts[0] == "SimpleGoal")
                        {
                            SimpleGoal simpleGoal = new SimpleGoal();
                            string goalType = parts[0];
                            string goalName = parts[1];
                            string goalDescription = parts[2];
                            string goalPoints = parts[3];
                            string completionStatus = parts[4];
                            string[] items = {goalType, goalName, goalDescription, goalPoints, completionStatus};
                            simpleGoal.LoadGoal(items);
                            _goals.Add(simpleGoal);
                        }
                        else if (parts[0] == "EternalGoal")
                        {
                            EternalGoal eternalGoal = new EternalGoal();
                            string goalType = parts[0];
                            string goalName = parts[1];
                            string goalDescription = parts[2];
                            string goalPoints = parts[3];
                            string completionStatus = parts[4];
                            string[] items = {goalType, goalName, goalDescription, goalPoints, completionStatus};
                            eternalGoal.LoadGoal(items);
                            _goals.Add(eternalGoal);
                        } 
                        else if (parts[0] == "ChecklistGoal")
                        {
                            ChecklistGoal checklistGoal = new ChecklistGoal();
                            string goalType = parts[0];
                            string goalName = parts[1];
                            string goalDescription = parts[2];
                            string goalPoints = parts[3];
                            string completionStatus = parts[4];
                            string timesCompleted = parts[5];
                            string timesNeeded = parts[6];
                            string bonus = parts[7];
                            string[] items = {goalType, goalName, goalDescription, goalPoints, completionStatus, timesCompleted, timesNeeded, bonus};
                            checklistGoal.LoadGoal(items);
                            _goals.Add(checklistGoal);
                        }  
                        else
                        {
                            _totalPoints = Convert.ToInt32(parts[0]);  
                        }                    
                    }

                    break;

                case "5":

                    _goalCounter = 0;
                    Console.WriteLine("The goals are: ");
                    foreach (Goal goal in _goals)
                    {
                        _goalCounter += 1;
                        Console.WriteLine($"{_goalCounter}. [ ] {goal.GetName()}"); 
                    }
                    Console.WriteLine("");
                    Console.Write("Which goal did you accomplish? ");
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    int goalIndex = userInput - 1;
                    Goal completedGoal = _goals[goalIndex];
                    _totalPoints += completedGoal.GetPoints();
                    int _timesCompleted = completedGoal.GetTimesCompleted();
                    _timesCompleted += 1;
                    completedGoal.SetTimesCompleted(_timesCompleted);
                    if (_timesCompleted >= completedGoal.GetTimesNeeded())
                        completedGoal.CompleteGoal();
                    Console.WriteLine();
                    
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("That is not a valid response. Please enter a number 1-6. ");
                    break;
            }

        }
    }

}