using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProgram
{
	delegate bool IsTeenAger1(Student5 std);

	class LocalVariable
    {

		public static void Main()
		{
			
			IsTeenAger1 IsTeenAger1 = delegate (Student5 s) { int age = 18; return s.Age >= age; };

			Student5 stu = new Student5() { Age = 25 };

			Console.WriteLine(IsTeenAger1(stu));

			Console.ReadKey();

		}
	}

	public class Student5
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}
}

