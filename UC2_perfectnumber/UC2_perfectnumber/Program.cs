public class Perfectnumber
{

    // Returns true if n is perfect
    static string Perfect(int n)
    {
        // To store sum of divisors
        int sum = 1;

        // Find all divisors and add them
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                if (i * i != n)
                    sum = sum + i + n / i;
                else
                    sum = sum + i;
            }
        }
        
        if (sum == n && n != 1)
            return "is a perfect number";

        return "is not a perfect number";
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Perfect( n);
        Console.WriteLine(Perfect(n));
    }
}
