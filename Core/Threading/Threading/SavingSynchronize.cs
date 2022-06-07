using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    class SavingSynchronize
    {

        float Bal;
        int AccNo;
        string Name;

        public float Balance
        {
            get { return Bal; }
            private set { Bal = value; }
        }

        public SavingSynchronize(int AccNo, float Bal, string Name)
        {
            this.AccNo = AccNo;
            this.Bal = Bal;
            this.Name = Name;
        }

        public void Deposit(float amount)
        {
            Bal = Bal + amount;
            Console.WriteLine("Balance After deposit = " + Bal.ToString());
        }

        public void Withdraw(float amount)
        {
            Bal = Bal - amount;
            Console.WriteLine("Balance After Withdraw = " + Bal.ToString());
        }

        public void Transaction(Object amt)
        {
            Monitor.Enter(this);
            string ThreadName = Thread.CurrentThread.Name;
            Console.WriteLine("Depositing AMount by : " + ThreadName);
            Console.WriteLine("Initial Balance: " + Balance);
            Deposit((float)amt);
            Withdraw((float)amt);
            Console.WriteLine("===================================");
            Monitor.Exit(this);
        }

        public static void Main()
        {
            SavingSynchronize s1 = new SavingSynchronize(101, 1000f, "Sanket");
            Thread thread1 = new Thread(new ParameterizedThreadStart(s1.Transaction));
            Thread thread2 = new Thread(new ParameterizedThreadStart(s1.Transaction));
            Thread thread3 = new Thread(new ParameterizedThreadStart(s1.Transaction));

            thread1.Name = "Thread 1";
            thread2.Name = "Thread 2";
            thread3.Name = "Thread 3";

            thread1.Start(500f);
            thread2.Start(1500f);
            thread3.Start(750f);
            Console.ReadLine();
        }
    }
}
