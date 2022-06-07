using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class AsyncAwaitDemo
    {
        public static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Method");
            Console.ReadLine();

        }

        //private static void Method()
        //{
        //    Task.Run(new Action(LongTask));
        //    Console.WriteLine("New Thread");
        //}

        private static async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");
        }

        private static void LongTask()
        {
            Thread.Sleep(2000);
        }
    }
}
