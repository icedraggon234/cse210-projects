using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");

        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");



        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine();

        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}