using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace LinqProgram
{
    public class Student
    {
        public string name { get; set; }
        public int studentId { get; set; }
        public int age { get; set; }
    }
    class Program2
    {
        static void Main()
        {
            IList<Student> studentArray = new List<Student>() 
            
                {
                new Student() { studentId = 1, name = "subhransu", age = 30 },
                 new Student() { studentId = 2, name = "hari", age = 20 },
                  new Student() { studentId = 3, name = "sekhar", age = 21 },
                   new Student() { studentId = 4, name = "sankar", age = 33 },
                    new Student() { studentId = 5, name = "mohqnty", age = 24 },


            };
            /*var teenAge = from s in studentArray
                          where s.age > 13 && s.age < 21
                          select s;*/
            var teenAge = studentArray.Where(s => s.age > 13 && s.age <= 21);

            foreach(Student std in teenAge)
            {
                Console.WriteLine(std.name);
            }
            Console.ReadKey();
    }
    }
}
