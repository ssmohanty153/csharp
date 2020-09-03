using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  var salmis = new List<string>();
            salmis.Add("Hare");
            salmis.Add("Krishna");
            salmis.Add("Hare");
            salmis.Add("Rama");
            salmis.Add("Hare hare");*/
            //or
            var salmis = new List<string>() { "Hare", "Krishna", "Hare", "Rama"," Hare hare" };

              
            foreach (var i in salmis)
                Console.WriteLine(i);



            //remove element

            salmis.Remove("Hare");
            // rmove in index of
            salmis.RemoveAt(2);
            foreach (var i in salmis)
                Console.WriteLine(i);
            Console.ReadKey();
        }


    }
}
