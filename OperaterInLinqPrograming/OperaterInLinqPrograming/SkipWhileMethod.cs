using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaterInLinqPrograming
{
    class SkipWhileMethod
    {
		public static void Main()
		{
			IList<string> strList = new List<string>() {
			"Three",
			"Four",
			"One",
			"Two",
			"Four",
			"Five",
			"Six"  };

			var result = strList.SkipWhile(s => s.Length > 4);
			/*Four
			One
			Two
			Four									
			Five
			Six*/
			//var result = strList.SkipWhile(s => s.Length < 4);
			/*	Three
				Four
				One
				Two
				Four
				Five
				Six*/
			



			foreach (string str in result)
				Console.WriteLine(str);
			Console.ReadKey();


		}
	}
}
