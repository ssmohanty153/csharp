using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class2 : Class1
    {
        public Class2()
        {
            Console.WriteLine("Class two constructor");
        }
        public void test3()
        {
            Console.WriteLine("Method Three ");
        }
        public void test4()
        {
            Console.WriteLine("Meyhod Four ");
        }
        static void Main()
        {
            Class2 c2 = new Class2();
            c2.test1();
            c2.test2();
            c2.test3();
            c2.test4();
        }

    }
}
