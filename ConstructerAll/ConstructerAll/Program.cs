using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerAll
{
    public class Program
    {
        public int salary;
        public Program(int anualasalary)
        {
            salary = anualasalary;
        }
        public Program(int annulSalary, int montyInYear) : this(annulSalary * montyInYear)
        {
            

        }
    }
    

   public class Manager :Program
    {
        public Manager(int annulsalary) : base(annulsalary)
        {
        }  
        public static void Main(string[] arg)
            {
                Manager p = new Manager(100000);
                Program p2 = new Program(2000, 12);
                Console.WriteLine(p.salary);
                Console.WriteLine(p2.salary);
                Console.ReadLine();



            }

        }

    }

