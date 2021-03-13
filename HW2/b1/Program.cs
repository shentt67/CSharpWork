using System;

namespace b1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num = 0;
            long[] a= new long[100];
            
            Console.WriteLine("Enter a number:");
            long n = Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine("The prime factors of {0}",n);
           
            for(int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    a[num++] = i;
                    while (n % i == 0)
                        n = n / i;
                }
            }
            if (n > 1)
                a[num++] = n;
            
            for(int i=0;i<num;i++)
            { 
                Console.WriteLine(a[i]); 
            }
        }
    }
}
