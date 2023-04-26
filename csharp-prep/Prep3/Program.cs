using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.WriteLine("This is the Magic Number Game!");
        Console.Write("What is your guess? ");
        string user_guess_text = Console.ReadLine();
        int user_guess = int.Parse(user_guess_text);
        
        while (user_guess != number)
        {
            if (user_guess > number)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                user_guess_text = Console.ReadLine();
                user_guess = int.Parse(user_guess_text);
            }
            else if (user_guess < number)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                user_guess_text = Console.ReadLine();
                user_guess = int.Parse(user_guess_text);
            }
        }

        Console.WriteLine("You guessed it!");
    }
}