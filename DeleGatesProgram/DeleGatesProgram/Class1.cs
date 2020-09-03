using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleGatesProgram
{
    public delegate string geteDele(string name);
    class Class1
    {

       /* public static string gettingDelegte(string name)
        {
            return "Hello " + name + " Welcome To Bangalore .";
        }*/
        static void Main(string[] args)
        {
            // Class1 cl = new Class1();

            /*string str = gettingDelegte("subhransu");
            Console.WriteLine(str);
*/
            /*  geteDele gd = new geteDele(Class1.gettingDelegte);
             string str= gd.Invoke("Hare krishna");
              Console.WriteLine(str);
             */
            /* geteDele obj = delegate (string name)
             {
                 return "Hello" + name + " a very good boy";
             };*/

            geteDele obj = (name) =>
              {
                  return "Hello" + name + " a very good boy";
              };001111111
            string str = obj.Invoke("subhransu");
            Console.WriteLine(str);


            Console.ReadLine();

        }
    }
}
