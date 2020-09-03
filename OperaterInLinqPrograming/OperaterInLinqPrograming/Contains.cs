using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaterInLinqPrograming
{
    class Contains
    {
        static void Main()
        {
            IList<int> li = new List<int>() { 1, 2, 3, 4, 5 };
            bool isNum= li.Contains(3);
            Console.WriteLine(isNum);
            Console.ReadKey();
        }
    }
}
