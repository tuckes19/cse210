using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment1 = new Assignment("Seth", "Girls");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Seth", "Math", "Chapter 3", "2, 5, 6");
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Seth", "Writing", "Poop, A History");
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}