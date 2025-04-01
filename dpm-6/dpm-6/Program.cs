using System;
class Task1
{
    static void Main()
    {
        int[] mas = {1, 1, 2, 2, 3, 4, 4, 4, 5, 5};
        int[] mas2 = mas.Distinct().ToArray();
        foreach (int i in mas2)
        {
            Console.WriteLine(i);
        }
    }
}