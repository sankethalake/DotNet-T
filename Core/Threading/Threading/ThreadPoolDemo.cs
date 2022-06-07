using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace Threading
{
    class ThreadPoolDemo
    {
        public static void Main()
        {
            for (int i =0; i < 10; i++){
                MethodWithThread();
                MethodWiththreadPool();
            }
            Stopwatch stopwatch = new Stopwatch();
            //Console.WriteLine("Execution using Thread");
            Console.WriteLine("Execution using Thread");
            stopwatch.Start();
            MethodWithThread();
            stopwatch.Stop();
            Console.WriteLine("Time by MethodWithThread:" + stopwatch.ElapsedTicks.ToString());

            Console.WriteLine("Execution using Thread pool");
            stopwatch.Start();
            MethodWiththreadPool();
            stopwatch.Stop();
            Console.WriteLine("Time by MethodWithThreadPool:" + stopwatch.ElapsedTicks.ToString());
        }

        private static void MethodWiththreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
                ThreadPool.QueueUserWorkItem(new WaitCallback(Test));
            }
        }

        private static void MethodWithThread()
        {
            for(int i =0; i<10; i++)
            {
                Thread thread = new Thread(Test);
            }
        }

        public static void Test(Object obj)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("Current Thread Details: " + thread.GetHashCode());
        }
    }

}
