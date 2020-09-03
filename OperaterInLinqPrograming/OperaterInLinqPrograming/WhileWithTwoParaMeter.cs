using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaterInLinqPrograming
{
    class WhileWithTwoParaMeter
    {
		public static void Main()
		{
			IList<string> strList = new List<string>() {
			"One",
			"Two",
			"Three",
			"one",
			"Oe",
			"Four",
			"Five",
			"Six"  };

			var resultList = strList.SkipWhile((s, i) => s.Length > i);
			//i is index start from 0 and check all the string length which greater then
			//the index then its skip and rest of things print.

			foreach (string str in resultList)
				Console.WriteLine(str);


		}
	}
}
