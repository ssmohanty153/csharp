using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExampleAll
{
    /*public delegate double addDel1(int a, float b, double c);
    public delegate void addDel2(int a, float b, double c);
    public delegate bool addDel3(string str);*/
    class Program
    {
        /*public static double addnum1( int a, float b,double c)
        {
            return a + b + c;
        }
        public static void addnum2(int a, float b, double c)
        {
           
            Console.WriteLine(a + b + c);
        }
        public static bool addnum3(string str)
        {
            if (str.Length >= 5)
            {
                return true;
            }
            else return false;

        }*/

            static void Main(string[] args)
        {
            /* double num = addnum1(10, 230, 47);
             Console.WriteLine(num);
             addnum2(12, 33, 44);
             bool b = addnum3("arrr");
             Console.WriteLine(b);*/


            //using deligate write the name


            /*Program p = new Program();
            addDel1 ad1 = new addDel1(Program.addnum1);
            double num = ad1.Invoke(10, 22, 34);
            Console.WriteLine(num);
            addDel2 ad2 = new addDel2(Program.addnum2);
            ad2.Invoke(10, 22, 34);
            addDel3 ad3 = new addDel3(Program.addnum3);
            bool b = ad3.Invoke("subhransu");
            Console.WriteLine(b);*/
            /*Func<int, float, double,double> obj1 = addnum1;
            double res1 = obj1.Invoke(10, 20, 30);
            Console.WriteLine(res1);
            Action<int, float , double > obj2 = addnum2;
             obj2.Invoke(10, 20, 30);
            Predicate<string> obj3 = addnum3;
            bool status = obj3.Invoke("subhransu");
            Console.WriteLine(status);

*/
            Func<int, double, float, double> obj1 = (x, y, z) =>
              {
                  return x + y + z;
              };
            double res1 = obj1.Invoke(10, 20, 30);
            Console.WriteLine(res1);
            Action<int, float, double> obj2 = (x, y, z) =>
              {
                  Console.WriteLine(x + y + z);
              };
            obj2.Invoke(10, 20, 30);
            Predicate<string> obj3 = (str) =>
             {
                 if (str.Length >= 5)
                     return true;
                 else
                     return false;
 

             };
            bool b = obj3.Invoke("subhransu");
            Console.WriteLine(b);






            Console.ReadLine();

        }
    }
}
