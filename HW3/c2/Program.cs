using System;

namespace c2
{
    class Program
    {
        static void Main(string[] args)
        {
            clock c = new clock();
            DateTime timelater= DateTime.Now.AddSeconds(5);
            c.SetAlarm(timelater);
            c.run();
        }
    }
}
