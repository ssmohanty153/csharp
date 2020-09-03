using System;

namespace Constructer
{
    class Program
    {
        public int salary;
        public Program(int anualasalary)
        {
            salary = anualasalary;
        }
        public Program(int annulSalary,int montyInYear )
            {
            salary=annulSalary* montyInYear;

            }
        static void Main(string[] args)
        {
            Program p = new Program(100000);
            Program p2 = new Program(2000,12);
            Console.WriteLine (p.salary);
        }
    }
}
