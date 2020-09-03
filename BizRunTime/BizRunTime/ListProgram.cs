using System;
using System.Collections.Generic;
using System.Text;

namespace BizRunTime
{
    class ListProgram
    {
        static void Main(string[] args)
        {
            SomeDataBase();
        }
        static void SomeDataBase()
        {

            var name = new List<String> { "subhransu ", "sekhar", "Mohanty" };
            Console.WriteLine("Total elrement enter " + name.Count);
            name.Add( "Hare");
            name.Add("Krishna");
            Console.WriteLine("Total modified after add" + name.Count);
            name.Remove("sekhar");
            Console.WriteLine("Total modified after remove" + name.Count);
            foreach(var li in name)
            {
                Console.WriteLine(li.ToUpper());

            }


            Console.WriteLine($"my name is{name[0]}");

            var index = name.IndexOf("Hare");
            if (index == -1)
            {
                Console.WriteLine("hare is not found");
            }
            else
            {
                Console.WriteLine("hare is found");
            }
            name.Sort();
            foreach(var listSort in name)
            {
                Console.WriteLine(listSort.ToUpper());
            }


        }
    }
}
