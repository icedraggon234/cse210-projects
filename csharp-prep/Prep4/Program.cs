using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        int numberEnterd;
        List<int> numbers = new List<int>();


        do
        {
            Console.Write("Enter number: ");
            numberEnterd = int.Parse(Console.ReadLine());

            if (numberEnterd != 0)
            {
                numbers.Add(numberEnterd);
            }

        } while (numberEnterd != 0);

        int sum = 0;
        int largest = 0;
        bool firstLoop = true;


        foreach (int number in numbers)
        {
            sum += number;
            if (firstLoop)
            {
                largest = number;
                firstLoop = false;
            }
            else
            {
                if (number > largest)
                {
                    largest = number;
                }
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {(float)sum / numbers.Count}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}