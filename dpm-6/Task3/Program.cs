using System;
class Task3
{
    static void Main()
    {
        Console.WriteLine("write anything");string word = Console.ReadLine();
        Task3.check(word);
    }
    static bool check(string word)
    {
        if (word[0] == word[word.Length-1])
        {
            Console.WriteLine("first and last letter are equal");
            return true;
        }
        else
        {
            Console.WriteLine("first and last letters are not equal");
            return false;
        }
    }
}
