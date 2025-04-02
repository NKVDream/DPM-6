using System;
class Task4
{
    static void Main()
    {
        double[] ar = new double[15];
        Random random = new Random();
        for (int i = 0; i < ar.Length; i++)
        {
            ar[i] = random.NextDouble();
        }
        foreach (double i in ar)
        {
            Console.WriteLine(i);
        }
    }
}