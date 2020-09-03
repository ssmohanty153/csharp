using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProg
{
    class WaitAllMethod1
    {
        public static void Main(string[] args)
        {
            var v1 = Task.Factory.StartNew(() => DoSomeWork(1, 500));
            //  Task.WaitAny(v1);
           Task.WhenAny(v1);
            var v2 = Task.Factory.StartNew(() => DoSomeWork(2, 500));
          //  Task.WaitAny(v2);





            var v3 = Task.Factory.StartNew(() => DoSomeWork(3, 500));
             var taskList = new List<Task> { v1, v2, v3 };
            //Toarray():- Copies the elements of the ArrayList to a new Object array.
          //await Task.WhenAll(taskList.ToArray());
           // Console.WriteLine("-------------");
           Task.WaitAll(taskList.ToArray());



            Task.WaitAny(v2);
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
/*task 3 is begin
task 1 is begin
task 2 is begin
task 1 is completated
task 3 is completated
task 2 is completated
Enter any key to exit
*/
//or
/*task 3 is begin
task 2 is begin
task 1 is begin
task 2 is completated
task 1 is completated
task 3 is completated
Enter any key to exit*/

