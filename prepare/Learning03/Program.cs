using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Fraction test_1 = new Fraction();
        Fraction test_2 = new Fraction(6);
        Fraction test_3 = new Fraction(6, 7);



        Console.WriteLine(test_1.GetNumerator());
        Console.WriteLine(test_1.GetDenominator());
        Console.WriteLine(test_1.GetFractionString());
        Console.WriteLine(test_1.GetDecimalValue());
        test_1.SetNumerator(3);
        test_1.SetDenominator(41);
        Console.WriteLine(test_1.GetNumerator());
        Console.WriteLine(test_1.GetDenominator());
        Console.WriteLine(test_1.GetFractionString());
        Console.WriteLine(test_1.GetDecimalValue());
    }
}