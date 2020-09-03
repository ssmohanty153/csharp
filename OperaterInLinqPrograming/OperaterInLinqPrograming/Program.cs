using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaterInLinqPrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studebtInfo = new List<Student>()
            { 
            new Student(){ StudentID=1,StudentName="hare",Age=23},
            new Student(){ StudentID=1,StudentName="durga",Age=44},
            new Student(){ StudentID=1,StudentName="krishna",Age=24},
            new Student(){ StudentID=1,StudentName="kali",Age=645},
             new Student(){ StudentID=1,StudentName="jayJAgannath",Age=112},
            };
            var name = from s in studebtInfo
                       where s.Age > 200 && s.Age <= 100
                       select s;
            foreach( Student s in name)
            {
                Console.WriteLine(s.StudentName);
            }

        }
    }
    /*public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }*/
}
