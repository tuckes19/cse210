using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create the list for putting the numbers in
        List<int> numbers = new List<int>();
        //Initialize the variable "sum"
        float sum = 0;
        // Initialize the largest number.
        float largestNumber = 0;

        //Initial Greeting and input entry
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number: ");
        string number_text = Console.ReadLine();
        int userNumber = int.Parse(number_text);

        //Add each of the user's number to a list until they enter "0"
        while (userNumber != 0)
        {
            numbers.Add(userNumber);
            Console.Write("Enter a number: ");
            number_text = Console.ReadLine();
            userNumber = int.Parse(number_text);
        }

        //Cycle through the list and add up all the numbers.
        foreach(int number in numbers)
        {
            sum += number ;
        }

        //Find the Average
        float average = ((float)sum) / numbers.Count;

        //Find the biggest number
        foreach(int number in numbers)
        {
            if (number > largestNumber)
                largestNumber = number;
        }

        //Print the sum and average to the terminal
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}