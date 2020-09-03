using System;
using System.Threading;

namespace ThreadClass
{
    class ThreadSleep
    {
        public static void method1()
        {
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
                //Thread.Sleep(1000);


            }
        }

        public void method2()
        {
            for (int i = 7; i < 12; i++)
            {
                Console.WriteLine(i);

            }
        }
        static void Main(string[] args)
        {
            ThreadSleep th = new ThreadSleep();
            Thread t = new Thread(new ThreadStart(ThreadSleep.method1));

            Thread t2 = new Thread(new ThreadStart(th.method2));
            t.Start();
            t2.Start();
            Console.ReadKey();
            //any method will be executated

        }
    }
}
