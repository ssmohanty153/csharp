using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaterInLinqPrograming
{
    class ConcatMethod
    {
		public static void Main()
		{
			IList<int> collection1 = new List<int>() { 1, 2, 3 };
			IList<int> collection2 = new List<int>() { 4, 5, 6 };
			IList<string> collection3 = new List<string> {"hari" };
			IList<string> collection4 = new List<string> { "krishna" };


			var collection5 = collection1.Concat(collection2);

			foreach (int i in collection5)
				Console.WriteLine(i);

			var collection6 = collection3.Concat(collection4);
			foreach(string x in collection6)
				Console.WriteLine(x);

			Console.ReadKey();

		}
	}
}
