using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProgram
{
    class Program4
    {

        static void Main()
        {
            IList<string> student = new List<string>()
            {
                "hare krishna",
                "hare rama",
                "rama rama"
            };
            var str = student.Where(s => s.Contains("krishna"));


            foreach(var s in str)
            {
                Console.WriteLine(s);
            }
        }
    }
}
