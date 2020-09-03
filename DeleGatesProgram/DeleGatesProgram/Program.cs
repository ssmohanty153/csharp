using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DeleGatesProgram
{
    public delegate void addDele(int x, int y);
    public delegate string sayDele(string name);
    public delegate void areaDele(int c, int d);
   // public delegate void premeterDele(int a, int b);
    class Program
    {
        public void add(int x, int y)
        {
            Console.WriteLine(x + y);

        }
        public static string sayHello( string name)
        {
            return "Hello" + name;

        }
        public void area(int a,int b)
        {
            Console.WriteLine(a * b);

        }
        public  void PareMeter(int c, int d)
        {
            Console.WriteLine((c+d)*2);

        }

        static void Main(string[] args)
        {
            Program p = new Program();

            /*p.add(12, 23);
            Console.WriteLine();
            string str=sayHello("Krishna");
            Console.WriteLine(str);
            Console.ReadLine();
       */

           addDele ad = new addDele(p.add);
            //ad(100, 50);
            ad.Invoke(100, 50);


            sayDele str = new sayDele(Program.sayHello);
           string str1= str.Invoke("subhransu");
            Console.WriteLine(str1);


            /*p.area(5, 6);
            PareMeter(10, 20);
           */
            /*
                        areaDele addd = new areaDele(p.area);
                        addd.Invoke(10, 20);

                        premeterDele pre = new premeterDele(Program.PareMeter);
                        pre.Invoke(5, 20);*/


            areaDele addd = new areaDele(p.area);
          //  Object t = Program.PareMeter;
            addd.Invoke(10, 20);






            Console.ReadLine();

        }
    }
}
