using System;
using System.Collections;

namespace b2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("Enter the number of elements:");
            int n = Convert.ToInt32(Console.ReadLine());

            ArrayList a = new ArrayList();

            Console.WriteLine("Enter these elements:");
            string readLine = Console.ReadLine();
            string[] stringArray = readLine.Split(' ');
            for (int i=0;i<n;i++)
            a.Add(int.Parse(stringArray[i]));

            a.Sort();

            for(int i=0;i<a.Count;i++)
                sum += (int)a[i];

            Console.WriteLine("The max in array is "+(int)a[a.Count - 1]);
            Console.WriteLine("The min in array is " + (int)a[0]);
            Console.WriteLine("The sum of array is " + sum);
            Console.WriteLine("The average of array is " + sum/a.Count);

        }
    }
}
