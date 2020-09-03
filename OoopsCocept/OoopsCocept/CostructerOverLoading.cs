using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsCocept
{
    class CostructerOverLoading
    {

        public double a;
        public double b;
        public CostructerOverLoading()
        {
            Console.WriteLine("zero parameter");
        }
        public CostructerOverLoading(int i, int j)
        {
            this.a = i;
            this.b = j;

            Console.WriteLine(i * j);
        }
        public CostructerOverLoading(double i, double j)
        {
            this.a = i;
            this.b = j;
            Console.WriteLine(i * j);
        }

        public void Area()
        {
            Console.WriteLine(a * b);
        }
    }

    public class Text1
    {
        public static void Main(string[] args)
        {
            CostructerOverLoading c = new CostructerOverLoading();
            CostructerOverLoading c1 = new CostructerOverLoading(10, 20);
            CostructerOverLoading c2 = new CostructerOverLoading(12.5, 20.3);
            c1.Area();
            c2.Area();
            Console.ReadKey();


        }
    }
}


