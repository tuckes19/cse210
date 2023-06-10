public class Menu
{
    // Attributes.
    int _activityDuration = 0;
    int _breathingCounter = 0;
    int _reflectionCounter = 0;
    int _listingCounter = 0;

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
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Activity Counter");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":

                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayIntroduction(0, "Breathing Activity");
                    _activityDuration = breathingActivity.ActivityDuration();

                    DateTime breathingStartTime = DateTime.Now;
                    TimeSpan breathingDuration = TimeSpan.FromSeconds(_activityDuration);

                    bool breathing = true;
                    while(breathing)
                    {
                        breathingActivity.DisplayBreatheIn();
                        breathingActivity.DisplayBreatheOut();
                        if (DateTime.Now - breathingStartTime >= breathingDuration)
                        {
                            breathing = false;
                        }
                    }
                    breathingActivity.DisplayFinish(_activityDuration, "Breathing Activity");
                    _breathingCounter += 1;
                    break;

                case "2":

                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.DisplayIntroduction(1, "Reflection Activity");
                    _activityDuration = reflectionActivity.ActivityDuration();

                    List<string> think = reflectionActivity.GetThink();
                    List<string> reflectingQuestion = reflectionActivity.GetQuestion();

                    Console.WriteLine(" ");
                    reflectionActivity.DisplayRandomPrompt(think);
                    reflectionActivity.SpinnerAnimation();
                    Console.WriteLine(" ");

                    DateTime reflectionStartTime = DateTime.Now;
                    TimeSpan reflectionDuration = TimeSpan.FromSeconds(_activityDuration);

                    bool reflecting = true;
                    while(reflecting)
                    {
                        reflectionActivity.DisplayRandomPrompt(reflectingQuestion);
                        reflectionActivity.SpinnerAnimation();
                        Console.WriteLine(" ");
                        if (DateTime.Now - reflectionStartTime >= reflectionDuration)
                        {
                            reflecting = false;
                        }
                    }
                    reflectionActivity.DisplayFinish(_activityDuration, "Reflection Activity");
                    _reflectionCounter += 1;
                    break;

                case "3":

                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.DisplayIntroduction(2, "Listing Activity");
                    _activityDuration = listingActivity.ActivityDuration();

                    List<string> listingQuestion = listingActivity.GetQuestion();
                    List<string> itemList = new List<string>();

                    Console.WriteLine(" ");
                    listingActivity.DisplayRandomPrompt(listingQuestion); 
                    Console.WriteLine(" ");              

                    DateTime listingStartTime = DateTime.Now;
                    TimeSpan listingDuration = TimeSpan.FromSeconds(_activityDuration);

                    bool listing = true;
                    while(listing)
                    {
                        listingActivity.BuildList(itemList);
                        if (DateTime.Now - listingStartTime >= listingDuration)
                        {
                            listing = false;
                        }
                    }

                    int length = itemList.Count;
                    Console.WriteLine("");
                    Console.WriteLine($"You listed {length} items!");

                    listingActivity.DisplayFinish(_activityDuration, "Listing Activity");
                    _listingCounter += 1;
                    break;

                case "4":

                    Activity counterLog = new Activity();

                    counterLog.SpinnerAnimation();
                    Console.WriteLine("");
                    Console.WriteLine($"    Breathing Activities completed: {_breathingCounter}");
                    Console.WriteLine($"    Reflection Activities completed: {_reflectionCounter}");
                    Console.WriteLine($"    Listing Activities completed: {_listingCounter}");
                    counterLog.SpinnerAnimation();
                    Console.WriteLine("");
                    break;

                case "5":

                    running = false;
                    break;

                default:

                    Console.WriteLine("That is not a valid response. Please enter a number from 1-5");
                    Activity spinner = new Activity();
                    spinner.SpinnerAnimation();
                    break;

            }
        }
    }
}