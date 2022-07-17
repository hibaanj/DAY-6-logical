public class Logic
{
    
    public int random()            
        
    {
    
        
        Random rn = new Random();
        int r = rn.Next(1, 10);
        return r;
    }
    int i = 0;

    public void distinct(int n)          
    {
        int[] a = new int[n];
        for(i=1; i<n; i++)
        {
            a[i] = random();
            for (int j = 0; j < i; j++)
            {
                if ((a[i] == n)&&( a[i] == a[j] ))
                {
                    a[i] = random();
                    i--;
                    break;
                }
            }
        }
        for(i=0; i<n; i++)
        {
            Console.WriteLine("the new discting number for coupon are ");
            Console.WriteLine(a[i]);
        }
        

    }
    public static void Main(string[] args)
    {
        Logic l = new Logic();
        int n = Convert.ToInt32(Console.ReadLine());
        l.distinct(n);

    }
}