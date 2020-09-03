using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerAll
{
    class CopyConstructer
    {
        int X;
        public CopyConstructer(int x)
        {

            X = x;
      
        }
        public CopyConstructer (CopyConstructer obj)
        {
            X = obj.X;
        }
        public void display()
        {
            Console.WriteLine("value of x" + X);
        }
        static void Main()
        {
            CopyConstructer c1 = new CopyConstructer(100);
            CopyConstructer c2 = new CopyConstructer(c1);
            c1.display();
            c2.display();
            Console.ReadKey();

        }

    }
}
