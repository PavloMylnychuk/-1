using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string numString = number.ToString();

        char result = (n > numString.Length) ? '-' : numString[numString.Length - n];
        Console.WriteLine(result);
    }
}
