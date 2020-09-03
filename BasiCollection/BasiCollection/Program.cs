using System;
using System.Collections.Generic;

namespace BasiCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string ,string> names = new Dictionary<string, string>();
            names.Add("1 ", "subhransu");
            names.Add("2 ", "bhai");
            names.Add("3 ", "sekhar ");
            names.Add("4 ", "kalia");
            names.Add("5 ", "durga maa");
            foreach(KeyValuePair<string ,string > k in names)
            {
                Console.WriteLine(k);

            }


            Console.WriteLine("Hello World!");

        }
    }
}
