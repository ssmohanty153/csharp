using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProgram
{
    class FunctionAndWhere
    {
        static public void Main()
        {
            IList<Student8> str = new List<Student8>()

            {
                new Student8() { Name = "subhransu", Age = 10, Id = 144 },
                new Student8() { Name = "subhransu", Age = 10, Id = 144 },
                new Student8() {Name="subhransu",Age=10,Id=144 },
                new Student8() {Name="subhransu",Age=10,Id=144 },
                new Student8() {Name="subhransu",Age=10,Id=144 },
            };
            Func<Student8, bool> studentAge = s => s.Age > 18 && s.Age < 21;
            var teenAgerStudent = from s in str
                                  where studentAge(s)
                                  select s;

            Console.WriteLine("Teen age Students:");

            foreach (Student8 std in teenAgerStudent)
            {
                Console.WriteLine(std.Name);
            }
        }
    }
}
