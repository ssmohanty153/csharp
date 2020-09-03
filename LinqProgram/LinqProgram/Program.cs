using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string []name = { "bill", "hare", "krishna", "hareram" };
            var mysql = from na in name
                        where na.Contains("ram")
                        select na;

            foreach(var s in mysql)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

        }
    }
}
