using System;
using System.Threading;

namespace ThreadClass
{
    class ThreadAbort
    {
        public void method1()
        {
            Thread.Sleep(10
                );
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
                //  Thread.Sleep(100);
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
            ThreadAbort th = new ThreadAbort();
            Thread t1 = new Thread(new ThreadStart(th.method1));

            Thread t2 = new Thread(new ThreadStart(th.method2));
            t2.Start();
            t2.Join();
            t1.Start();
            // t1.Join();


            

            //  t2.Join();


            /*  t1.Abort();
              t2.Abort();*/



            Console.ReadKey();
        }
    }
}
