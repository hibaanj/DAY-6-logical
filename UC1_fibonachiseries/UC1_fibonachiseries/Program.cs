
// C# program for Fibonacci Series
using System;

public class Fibonachi
{
    public static int Fibo(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibo(n - 1) + Fibo(n - 2);
        }
    }

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write(Fibo(n));
    }
}