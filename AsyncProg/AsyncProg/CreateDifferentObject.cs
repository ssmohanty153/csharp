using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProg
{
    class CreateDifferentObject
    {
        public static void Main(string [] args)
        {
            Action<object> action = (object obj)
                  => {
                      Console.WriteLine("task={0},object={1},thread={2}", Task.CurrentId, obj, Thread.CurrentThread.ManagedThreadId);


            };

            Task t1 = new Task(action, "a");
            Task t2 = Task.Factory.StartNew(action, "b");
            t2.Wait();
            t1.Start();
            t1.Wait();
           
            Task t3 = new Task(action,"c");
            //Runs the Task synchronously on the current TaskScheduler.
            t3.RunSynchronously();
            t3.Wait();
            string taskdata = "d";
            Task t4 = Task.Run(() =>
            {
                Console.WriteLine("Task{0},obj={1} ,thread={2} ", Task.CurrentId, taskdata, Thread.CurrentThread.ManagedThreadId);


            });

            t4.Wait();

           
            Console.WriteLine("enter any key");
            Console.ReadKey();
                
        }
    }
}
/*task=1,object=b,thread=3
task=2,object=a,thread=3
task=3,object=c,thread=1
Task4,obj=d ,thread=4
enter any key*/
