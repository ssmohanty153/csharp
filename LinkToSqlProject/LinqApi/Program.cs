using System;
using System.Linq;

namespace LinqApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Bill", "Steve", "James", "Mohan" };

            var myLinqQuery = from name in names where name.Contains('e') select name;

            foreach (var name in myLinqQuery)
                Console.Write(name + "  ");

            Console.ReadLine();
        }
    }
}
