using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncProg
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Task<int> task = HandleFileAsync();

            Console.WriteLine("please  wait");
            string line = Console.ReadLine();
            task.Wait();
            var x = task.Result;
            Console.WriteLine("count" + x);
            Console.ReadLine();

        }
        static async Task<int> HandleFileAsync()
        {
            string file = @"C:\Users\ssmoh\Downloads\Training document.txt";
            Console.ReadLine();
            int count = 0;

            using (StreamReader read = new StreamReader(file))
            {
                string v = await read.ReadToEndAsync();
                string[] str = v.Split(' ');
                count = str.Length;
                //count += v.Length;
            }
            Console.WriteLine(" ");
                return count;
        }
    }
}
