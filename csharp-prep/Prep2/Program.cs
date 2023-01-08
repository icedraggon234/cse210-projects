using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentageText = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageText);


        string letterGrade;
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >=60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine();
        Console.WriteLine($"Letter grade: {letterGrade}");
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed. Congratulations!");
        }
        else
        {
            Console.WriteLine("You have not passed. Keep on trying and you might make it!");
        }
    }
}