using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}
