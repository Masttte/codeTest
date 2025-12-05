using System;

public class twonumbercompare
{
    static void Main()
    {
        int[] numlist = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        if (numlist[0] > numlist[1])
        {
            Console.WriteLine(">");
        }
        else if (numlist[0] < numlist[1])
        {
            Console.WriteLine("<");
        }
        else
        {
            Console.WriteLine("==");
        }
    }
}