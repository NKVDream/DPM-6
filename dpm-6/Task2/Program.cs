using System;
class Task2
{
    static void Main()
    {
        Console.Write("write down anything: ");string a = Console.ReadLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(a);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(a);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(a);
    }
}