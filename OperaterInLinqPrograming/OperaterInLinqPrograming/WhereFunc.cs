using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaterInLinqPrograming
{
    class WhereFunc
    {
        static void Main(string[] args)
        {
            IList<Student1> studentInfo = new List<Student1>()
            {
            new Student1(){ StudentID=1,StudentName="hare",Age=23},
            new Student1(){ StudentID=1,StudentName="durga",Age=44},
            new Student1(){ StudentID=1,StudentName="krishna",Age=24},
            new Student1(){ StudentID=1,StudentName="kali",Age=645},
            new Student1(){ StudentID=1,StudentName="jayJAgannath",Age=112}
            };
            Func<Student1, bool> GetName = delegate (Student1 s)
              {
                  return s.Age > 100 && s.Age < 200;

              };
            var resulyty = from s in studentInfo
                           where GetName(s)
                           select s;

            foreach( var sa in resulyty)
            {
                Console.WriteLine(sa.StudentName);
            }
            Console.ReadKey();
            
        }
    }
    public class Student1
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }


}

