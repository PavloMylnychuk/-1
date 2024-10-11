using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool result = n > 20 && n % 2 != 0;
        Console.WriteLine(result);
    }
}
