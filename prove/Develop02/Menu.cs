using System.IO;
public class Menu
{
    private Journal _journal;

    public Menu(Journal journal)
    {
        _journal = journal;
    }

    public void Display()
    {
        string fileName = "";
        string response = "";
        string[] options = {"1", "2", "3", "4", "5"};
        while (response != "5")
        {
            while(options.Contains(response) == false)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.Write("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch (response)
            {
                case "1":

                    Prompt prompt = new Prompt();
                    string prompt1 = prompt.GetRandomPrompt();
                    Console.WriteLine(prompt1);
                    string mainAnswer = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Overall Emotion: ");
                    string emotionAnswer = Console.ReadLine() ?? String.Empty;
                    Console.WriteLine("Rating out of 10: ");
                    string ratingAnswer = Console.ReadLine() ?? String.Empty;
                    _journal.AddEntry(new Entry(prompt1, mainAnswer, emotionAnswer, ratingAnswer));
                    break;

                case "2":

                    string file = fileName;
                    string[] lines = System.IO.File.ReadAllLines(file);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("~|~");
                        string entryPrompt = parts[0];
                        string entryText = parts[1];
                        string entryDate = parts[2];
                        string entryEmotion = parts[3];
                        string entryRating = parts[4];

                        Console.WriteLine("");
                        Console.WriteLine($"Date: {entryDate} - Prompt: {entryPrompt}\n{entryText}\nEmotion: {entryEmotion}\nRating: {entryRating}");
                        Console.WriteLine("");

                        }
                    break;

                case "3":

                    Console.WriteLine("What is the file name? ");
                    fileName = Console.ReadLine() ?? String.Empty;
                    break;

                case "4":

                    Console.WriteLine("What is the file name? ");
                    fileName = Console.ReadLine() ?? String.Empty;
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        foreach (Entry entry in _journal._entries)
                        {
                            outputFile.WriteLine($"{entry._prompt}~|~{entry._maintext}~|~{entry._datetime}~|~{entry._emotion}~|~{entry._rating}");
                        }
                    }
                    break;

                case "5":

                    Environment.Exit(0);
                    break;

            }
            response = "";
        }
    }
}