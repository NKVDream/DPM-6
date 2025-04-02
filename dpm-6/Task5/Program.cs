using System;
class Task5
{
    static void Main()
    {
        Console.Write("write down any word: ");string word = Console.ReadLine();
        Task5.star(word);
    }
    static void star(string word)
    {
        int count = 0;
        foreach (char item in word)
        {
            count++;
        }
        Console.WriteLine(count);
        for (int i = 0; i < count; count--)
        {
            word += "*";
        }
        Console.WriteLine(word);
    }
}
