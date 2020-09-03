using System;
using System.Threading;

namespace ThreadClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
             Thread t = Thread.CurrentThread;
          
            
          

            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
