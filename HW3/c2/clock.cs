using System;

namespace c2
{
    class clock
    {
        DateTime time = DateTime.Now;

        public delegate void tick(object eventsender);
        public delegate void alarm(object eventsender,DateTime t);

        public event tick clocktick;
        public event alarm clockalarm;

        public clock()
        {
            clocktick += Tick;
            clockalarm += Alarm;
        }
        public void Tick(object eventsender)
        {
             Console.WriteLine("DiDa "+DateTime.Now);
                      
        }

        public void Alarm(object eventsender, DateTime t1)
        {
            {
                Console.WriteLine("DIDIDIDIDI! The time is " + t1);
            }
            System.Threading.Thread.Sleep(3000);
        }

        public void SetAlarm(DateTime t2)
        {
            time = t2;
        }

        public void run()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                clocktick(this);
                if (DateTime.Now.ToString() == time.ToString()) 
                {
                    clockalarm(this, time); 
                }
            }            
        }


    }
}
