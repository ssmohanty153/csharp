using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProg
{
    class CancelTationRequest
    {
        public static void Main(string[] args)
        {
            try
            {
                var source = new CancellationTokenSource();
                var v1 = Task.Factory.StartNew(() => DoSomeWork(1, 1000,source.Token));
                var v2 = Task.Factory.StartNew(() => DoSomeWork(2, 2000, source.Token));
                var v3 = Task.Factory.StartNew(() => DoSomeWork(3, 500, source.Token));
              
                source.Cancel();

            }
            catch(AggregateException ag)
            {
                Console.WriteLine(ag.GetType());
            }
            Console.WriteLine("Enter some key to exit");
            Console.ReadKey();



        }
        static void DoSomeWork(int id,int waitTime,CancellationToken token)
        {
            if(token.IsCancellationRequested)
            {
                Console.WriteLine("request cancel");
                token.ThrowIfCancellationRequested();
            }
            Console.WriteLine("Task{0} has bigin ",id);
            Thread.Sleep(waitTime);
            Console.WriteLine("Task{0} has complete ", id);

        }
    }
}
