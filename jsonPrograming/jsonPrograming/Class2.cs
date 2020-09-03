using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonPrograming
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string AcadmicYear { get; set; }
        public List<Course> Courses { get; set; }
    }

    public class StudentsDatabase : List<Student>
    {
        public StudentsDatabase()
        {
            Add(new Student()
            {
                StudentId = 1,
                StudentName = "Hari",
                AcadmicYear = "First",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="java" },
                 new Course() {CourseId=102,CourseName="hibernate" },
                 new Course() {CourseId=103,CourseName="spring mvc" }
            }
            });

            Add(new Student()
            {
                StudentId = 2,
                StudentName = "Subhasish",
                AcadmicYear = "Second",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=104,CourseName="MVC" },
                 new Course() {CourseId=105,CourseName="AngularJS" }
            }
            });
            Add(new Student()
            {
                StudentId = 3,
                StudentName = "srisant",
                AcadmicYear = "Third",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=102,CourseName="C#" },
                 new Course() {CourseId=104,CourseName="MVC" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
            });
            Add(new Student()
            {
                StudentId = 4,
                StudentName = "kartik",
                AcadmicYear = "fifth",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=102,CourseName="C" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
            });

            Add(new Student()
            {
                StudentId = 5,
                StudentName = "ganesh",
                AcadmicYear = "sixth",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=104,CourseName="MVC" },
                 new Course() {CourseId=105,CourseName="AngularJS" },
                 new Course() {CourseId=106,CourseName="KnockoutJS" }
            }
            });
            Add(new Student()
            {
                StudentId = 6,
                StudentName = "radha",
                AcadmicYear = "senventth",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=102,CourseName="C" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
            });
            Add(new Student()
            {
                StudentId = 7,
                StudentName = "subhransu",
                AcadmicYear = "Forth",
                Courses = new List<Course>()
            {
                 new Course() {CourseId=101,CourseName="C++" },
                 new Course() {CourseId=102,CourseName="C" },
                 new Course() {CourseId=103,CourseName="Visual Basic" }
            }
            });
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
    }

    public class EmployeesDatabase : List<Employee>
    {
        public EmployeesDatabase()
        {
            Add(new Employee() { EmpNo = 1, EmpName = "A", DeptName = "IT" });
            Add(new Employee() { EmpNo = 2, EmpName = "B", DeptName = "Systems Engineer" });
            Add(new Employee() { EmpNo = 3, EmpName = "C", DeptName = "developer" });
            Add(new Employee() { EmpNo = 4, EmpName = "D", DeptName = "network marketinhg" });
            Add(new Employee() { EmpNo = 5, EmpName = "E", DeptName = "tester" });
            Add(new Employee() { EmpNo = 6, EmpName = "F", DeptName = "hr" });
            Add(new Employee() { EmpNo = 7, EmpName = "g", DeptName = "marketing managment" });
        }
    }

    public class Class2
    {
        static void Main(string[] args)
        {
            string StudentsData = JsonConvert.SerializeObject(new StudentsDatabase(), Formatting.Indented);

            JArray studentsArray = JArray.Parse(StudentsData);

            var resStudents = (from s in studentsArray
                               select s["StudentName"]).ToList();

            Console.WriteLine("Student Names");
            foreach (var item in resStudents)
            {
                Console.WriteLine(item.Value<string>().ToString());

            }

            Console.WriteLine("Employee name ") ;

            string employeesData = JsonConvert.SerializeObject(new EmployeesDatabase(), Formatting.Indented);


            JArray employeesArray = JArray.Parse(employeesData);

            var empGroupByDeptName = (from e in employeesArray
                                      select e["EmpName"]).ToList();

            foreach (var ename in empGroupByDeptName)
            {
                Console.WriteLine(ename);
            }

            Console.WriteLine("_______________________-----------------------________________________");

            Console.ReadKey();
        }
    }
}