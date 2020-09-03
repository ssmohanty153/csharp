using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaterInLinqPrograming
{
    class SequatialFunction
    {
		public static void Main()
		{
			Student std = new Student() { StudentID = 1, StudentName = "subhransu" };

			IList<Student> studentList1 = new List<Student>() { std };

			IList<Student> studentList2 = new List<Student>() { std };

			bool isStudentsEqual = studentList1.SequenceEqual(studentList2); 

			Console.WriteLine(isStudentsEqual);

			Student std1 = new Student() { StudentID = 1, StudentName = "subhransu" };

			Student std2 = new Student() { StudentID = 1, StudentName = "subhransu" };

			IList<Student> studentList3 = new List<Student>() { std1 };

			IList<Student> studentList4 = new List<Student>() { std2 };
			// to get proper output we over tide iequalcompare then return getHash code method

			isStudentsEqual = studentList3.SequenceEqual(studentList4,new StudentComparer()); 

			Console.WriteLine(isStudentsEqual);
			Console.ReadKey();


		}
	}
	class StudentComparer : IEqualityComparer<Student>
	{
		public bool Equals(Student x, Student y)
		{
			if (x.StudentID == y.StudentID && x.StudentName.ToLower() == y.StudentName.ToLower())
				return true;

			return false;
		}

		public int GetHashCode(Student obj)
		{
			return obj.GetHashCode();
		}
	}

}

