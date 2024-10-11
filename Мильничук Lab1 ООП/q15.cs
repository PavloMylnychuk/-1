using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        bool isNegative = (a < 0 && b >= 0 && c >= 0) || (a >= 0 && b < 0 && c >= 0) || (a >= 0 && b >= 0 && c < 0);
        string result = isNegative ? "Негативний" : "Позитивний";
        Console.WriteLine(result);
    }
}
