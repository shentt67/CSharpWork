using System;

    public class c1
    {
        public static void Main()
        {
            GenericList<int> intList = new GenericList<int>();
            for(int x = 0; x < 10; x++)
            {  
                intList.Add(x);
            }
            //ForEach
            intList.ForEach(N => Console.WriteLine(N.Data));

            GenericList<string> strList = new GenericList<string>();
            for(int x = 0; x < 10; x++)
            {
                strList.Add("str" + x);
            }
            //ForEach
            strList.ForEach(N => Console.WriteLine(N.Data));
            
        }
    }
