using System;
using System.Threading;

namespace ThreadClass
{
    class MyThreadStatic
    {
        public static void method1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);

            }
        }

        public void method2()
        {
            for (int i = 12; i < 20; i++)
            {
                Console.WriteLine(i);

            }
        }
        public void method3()
        {
            for (int i = 20; i < 25; i++)
            {
                Console.WriteLine(i);

            }
        }



        static void Main(string[] args)
        {
            //in static we pass the threa using class nme;
            Thread t = new Thread(new ThreadStart(MyThreadStatic.method1));


            Thread t1 = new Thread(new ThreadStart(MyThreadStatic.method1));
            t.Start();
            t1.Start();



            //for nonstatic we pass then value by creat in instance of object;

            MyThreadStatic ms = new MyThreadStatic();
            Thread t3 = new Thread(new ThreadStart(ms.method2));


            Thread t4 = new Thread(new ThreadStart(ms.method3));
            t3.Start();
            t4.Start();



            Console.ReadKey();

        }

    }
}
