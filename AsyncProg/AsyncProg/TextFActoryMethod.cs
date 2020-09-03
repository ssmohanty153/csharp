using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProg
{
    class TextFActoryMethod
    {
        public static void Main(String [] args)
        {
            var v1 = Task.Factory.StartNew(() => DoSomeWork(1, 500));
            var v2 = Task.Factory.StartNew(() => DoSomeWork(2, 500));
            var v3 = Task.Factory.StartNew(() => DoSomeWork(3, 500));
            Console.WriteLine("Enter any key to exit");
            Console.ReadKey();
        }
        static void DoSomeWork(int id, int sleepTime)
        {
            Console.WriteLine("task {0} is begin", id);
            Thread.Sleep(sleepTime);
            Console.WriteLine("task {0} is completated", id);
        }
    }
}
/*Enter any key to exit
 task 1 is begin
task 2 is begin
task 3 is begin
task 3 is completated
task 1 is completated
task 2 is completated
*/
//or

/*
 Enter any key to exit
 * task 1 is begin
task 3 is begin
task 2 is begin
task 3 is completated
task 1 is completated
task 2 is completated*/



