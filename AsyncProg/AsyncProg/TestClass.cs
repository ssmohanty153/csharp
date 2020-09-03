using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProg
{
   public class TestClass
    {
        public static void Main(string[] args)
        {
            var t1 = new Task(() => DoSomeWork(1, 1500));
            var t2 = new Task(() => DoSomeWork(2, 1500));
            var t3 = new Task(() => DoSomeWork(3, 1500));
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadKey();
        }
        static void DoSomeWork(int id,int sleepTime)
        {
            Console.WriteLine("task {0} is begin", id);
            Thread.Sleep(sleepTime );
            Console.WriteLine("task {0} is completated", id);
        }
    }
}
/*task 1 is begin
task 2 is begin
task 3 is begin
task 2 is completated
task 1 is completated
task 3 is completated*/


//different output

/*task 3 is begin
task 1 is begin
task 2 is begin
task 1 is completated
task 3 is completated
task 2 is completated*/


