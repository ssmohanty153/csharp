using System;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Subhransu","Mohanty");

            Console.WriteLine(p);
            Console.WriteLine(p.AllCops());
            Person p1 = new Person("Subhransu2", "Mohanty2");

            Console.WriteLine(p);
            Console.WriteLine(p.AllCops());


            Console.ReadLine();
        }
    }
}
