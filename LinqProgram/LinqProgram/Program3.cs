using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqProgram
{
    class Program3
    {
        static void Main()
        {
            IList<string> stringList = new List<string>()
            {
                "csharp tuterial",
                    "java yuterial",
                   " c tuterial"
            };
            var res = from s in stringList
                      where s.Contains("tuterial")
                      select s;

            foreach (string str in res)

                Console.WriteLine(str);
        }
    }
}
