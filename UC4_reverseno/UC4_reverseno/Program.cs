//reverse of a number
public class Reverse
{
    public void Revnum()
    {
        int reverse = 0;
        int rem;
        int num = Convert.ToInt32(Console.ReadLine());  
        Console.WriteLine($"the number is {num}");
        while(num != 0)
        {
            //step one is taking modulo
            rem = num % 10;
            reverse = (reverse * 10) + rem;
            num = num / 10;
        }

        Console.WriteLine($"the number after reverse is {reverse}");



    }
    public static void Main(string[] args)
    {
        Reverse r = new Reverse();
        r.Revnum();
    }

}