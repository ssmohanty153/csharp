using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaterInLinqPrograming
{
    class ContainsCompareMethod
    {
        static void Main()
        {
            IList<Student> student = new List<Student>()
            {
                new Student(){StudentID=1,StudentName ="subhransu",Age=33},
               new Student(){StudentID=2,StudentName ="god",Age=18},

                new Student(){StudentID=3,StudentName ="krishna",Age=22},
               new Student(){StudentID=4,StudentName ="hare",Age=17},

                new Student(){StudentID=6,StudentName ="sekhar",Age=5},
               new Student(){StudentID=5,StudentName ="mohanty",Age=24},

            };
            Student std = new Student() { StudentID = 3, StudentName = "krishna" };
            bool num = student.Contains(std ,new AIcomparable());
            Console.WriteLine(num);
            Console.ReadKey();


        }
    }
    public class AIcomparable : IEqualityComparer<Student>

    {
        public bool Equals(Student x,Student y)
        {
            if(x.StudentID==y.StudentID && x.StudentName.ToLower()==y.StudentName.ToLower())
                {
                return true;
            }
            else
            return false;
        }
        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
}

