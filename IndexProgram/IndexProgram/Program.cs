using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1001, 45000, "krishna", "software developer", ".net", "bangalore");
            Console.WriteLine("eno   " + emp[1]);
            Console.WriteLine("salary   " + emp[2]);
            Console.WriteLine("Ename  " + emp[3]);
            Console.WriteLine("Job   " + emp[4]);
            Console.WriteLine("Dname   " + emp[5]);
            Console.WriteLine("Location   " + emp[6]);
            emp[3] = "sr Manager";
            emp[4] =" .net";
            emp["ename"] = "hari";
            Console.WriteLine();
            Console.WriteLine("eno  " + emp["Eno"]);
            Console.WriteLine("salary  " + emp["Salary"]);
            Console.WriteLine("Ename  " + emp["Ename"]);
            Console.WriteLine("Job  " + emp["Job"]);
            Console.WriteLine("Dname  " + emp["Dname"]);
            Console.WriteLine("Location  " + emp["Location"]);
            Console.ReadLine();
        }
    }
}
