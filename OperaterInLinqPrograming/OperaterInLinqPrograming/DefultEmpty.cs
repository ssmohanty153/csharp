using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaterInLinqPrograming
{
    class DefultEmpty
    {
		public static void Main()
		{
			IList<Student> emptyStudentList = new List<Student>();

			var newStudentList1 = emptyStudentList.DefaultIfEmpty();
			var newStudentList2 = emptyStudentList.DefaultIfEmpty(new Student() { StudentID = 1, StudentName = "dcsdccdc" });

			Console.WriteLine("Count: {0} ", newStudentList1.Count());
			Console.WriteLine("Student ID: {0} ", newStudentList1.ElementAt(0));

			Console.WriteLine("Count: {0} ", newStudentList2.Count());
			Console.WriteLine("Student ID: {0} {1}", newStudentList2.ElementAt(0).StudentID, newStudentList2.ElementAt(0).StudentName);
			Console.ReadKey();

		}
	}
}

