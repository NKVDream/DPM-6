using System;
class Task7
{
    static void Main()
    {
        Console.Write("write down anything: "); string word = Console.ReadLine();
        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(word);
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(word);
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(word);
        Console.ResetColor();
    }
}