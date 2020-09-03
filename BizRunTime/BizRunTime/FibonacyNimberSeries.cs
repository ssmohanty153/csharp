using System;
using System.Collections.Generic;
using System.Text;

namespace BizRunTime
{
    class FibonacyNimberSeries
    {
        private string str = "The Sun Infosystems";
        public void Display()
        {
            Console.WriteLine("You are in Display method");
            Display(100, "Rupesh");
            Console.WriteLine("------");
            Display(200, "Rupesh", "Ajit");
            Console.WriteLine("------");
            Display(300, "Rupesh", "Vaibhav", "Sam");
        }
        public void Display(int a, params string[] parameterArray)
        {
            foreach (string str in parameterArray)
                Console.WriteLine(str + " " + a);
        }
        static void Main(string[] args)
        {
            FibonacyNimberSeries obj = new FibonacyNimberSeries();
            obj.Display();
            Console.ReadLine();
        }


    }
    }

