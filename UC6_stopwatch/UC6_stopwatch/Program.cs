using System;
using System.Diagnostics;
public class Stimer
{
    public static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("write 1 to start");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n == 1)
        {
            stopwatch.Start();
            Console.WriteLine("write 0 to stop your clock");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k == 0)
            {
                stopwatch.Stop();
                Console.WriteLine("clock stopped");
            }
            Console.WriteLine("the elapsed time is "+stopwatch.Elapsed);

            

        }
        else
        {
            Console.WriteLine("couldnt start watch");
        }
    }
}