using System;
using System.Collections.Generic;
using System.Text;

namespace BizRunTime
{
    class Class1
    {
        static void Mymethod(string country = "india")
        {
            Console.WriteLine(country);

        }
        static void Mymethod2(string name,string mName)
        {
            Console.WriteLine(mName);
        }
        static void Main()
        {
           /* string abb ="    subhransu        ";
            Mymethod();
            Mymethod("Usa");
            Mymethod2(name: "subhransu", mName: "Mohanty");
            Console.WriteLine($"hello  {abb}");
            Console.WriteLine($"[{abb.TrimEnd()}]");
            Console.WriteLine($"[{abb.TrimStart()}]");
            Console.WriteLine($"[{abb.Trim()}]");
*/
            /*decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);*/


           /* double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
            Console.WriteLine(Math.PI);*/

            //next
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

        }

    }
}
