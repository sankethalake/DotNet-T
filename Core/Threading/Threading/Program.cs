using System;
using System.Threading;

namespace Threading
{
    class Program
    {

        public long count;

        public void StartCount()
        {
            while (true)
            {
                //if (count==5) Thread.Sleep(1000);
                count++;
            }
        }

        //static void Main(string[] args)
        //{
        //    Program obj1 = new Program();
        //    Thread t1 = new Thread(new ThreadStart(obj1.StartCount));
        //    t1.Priority = ThreadPriority.Lowest;

        //    Program obj2 = new Program();
        //    Thread t2 = new Thread(new ThreadStart(obj1.StartCount));
        //    t1.Priority = ThreadPriority.Highest;

        //    t1.Start();
        //    Thread.Sleep(1000);

        //    t2.Start();
        //    Thread.Sleep(1000);

        //    t1.Interrupt();
        //    t2.Interrupt();

        //    Console.WriteLine("Low Priority Thread Clicks: " + obj1.count);
        //    Console.WriteLine("High Priority Thread Clicks: " + obj1.count);
        //    Console.ReadLine();
        //}
    }
}
