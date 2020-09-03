using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProgram
{
	

	public class UsingFunction
	{
		public static void Main()
		{ 
		Func<Student6, bool> IsteenAger2 = s => s.Age > 13 && s.Age <= 18;

		Student6 std7 = new Student6() { Age = 25 };

		Console.WriteLine(IsteenAger2(std7));

			Console.ReadKey();

		}
}

public class Student6
{

	public int Id { get; set; }
	public string Name { get; set; }
	public int Age { get; set; }
}
    
}
