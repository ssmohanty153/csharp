using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProgram
{
	delegate bool IsTeenAger(Student1 stud);
	class DelegateLinq
    {
		

		public static void Main()
		{
			/*	IsTeenAger isTeenAger = delegate (Student1 s) { return s.Age > 12 && s.Age < 20; };*/
			//or
			IsTeenAger isTeenAge = s => s.Age > 12 && s.Age < 20;

			Student1 stu = new Student1() { Age = 25 };

			Console.WriteLine(isTeenAge(stu));

			Console.ReadKey();

		}
	}

	public class Student1
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}
}

