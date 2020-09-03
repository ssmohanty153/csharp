using System;
using System.Collections.Generic;
using System.Text;

namespace BizRunTime
{
    class FibonesiSeries
    {
        static void Main(string[] args)
        {
            var fibonaccy = new List<int> { 1, 1 };
            while(fibonaccy.Count<20)
            {
                var pre = fibonaccy[fibonaccy.Count - 1];
                var next = fibonaccy[fibonaccy.Count - 2];
              var sum = next + pre;
                fibonaccy.Add(sum);
            }
            foreach(var fibo in fibonaccy)
            {
                Console.WriteLine(fibo);
            }


        }
    }
}
