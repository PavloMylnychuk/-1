using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = n switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "не дійсний"
        };
        Console.WriteLine(result);
    }
}
