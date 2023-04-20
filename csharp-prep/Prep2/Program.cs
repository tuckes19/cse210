using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userPercentageText = Console.ReadLine();
        int userPercentage = int.Parse(userPercentageText);

        string grade = "";
        string word = " ";
        string message = "";

        if (userPercentage >= 90)
        {
            grade = "A";
            word = "n ";
            message = "Congratulations! You passed!";
        }
        else if (userPercentage < 90 && userPercentage >= 80)
        {
            grade = "B";
            message = "Congratulations! You passed!";
        }
        else if (userPercentage < 80 && userPercentage >= 70)
        {
            grade = "C";
            message = "Congratulations! You passed!";
        }
        else if (userPercentage < 70 && userPercentage >= 60)
        {
            grade = "D";
            message = "You did not pass. Better luck next time";
        }
        else
        {
            grade = "F";
            word = "n ";
            message = "You did not pass. Better luck next time.";
        }

        Console.Write($"You received a{word}{grade}. {message}");
    }
}