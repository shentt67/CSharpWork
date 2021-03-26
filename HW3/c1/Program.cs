using System;

namespace c1
{
    public class c1
    {
        static int min;
        static int max;
        static int sum;        
        public static void Main()
        {
            GenericList<int> intList = new GenericList<int>();            
            for(int x = 0; x < 10; x++)
            {  
                intList.Add(x);
            }
            min = max = intList.Head.Data;
            //ForEach
            intList.ForEach(N => Console.WriteLine(N.Data));

            intList.ForEach(N=> {
                if (N.Next != null && N.Next.Data <= min)
                    min = N.Next.Data;
            });
            Console.WriteLine("min: "+ min);

            intList.ForEach(N=> {
                if (N.Next != null && N.Next.Data >= max)
                    max = N.Next.Data;
            });
            Console.WriteLine("max: " + max);

            intList.ForEach(N=> { sum += N.Data; });
            Console.WriteLine("sum: " + sum);

        }
        
    }
}

