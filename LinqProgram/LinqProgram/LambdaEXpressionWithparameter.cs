using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProgram
{
    delegate bool young(Student3 stud,int Yage);
    class LambdaEXpressionWithparameter
    {
        static void Main()
        {
            young you = (s, Yage) => s.Age < Yage;
            Student3 std = new Student3() { Age = 23 };
            Console.WriteLine(you(std, 26));
            Console.ReadKey();

        }

    }
    public class  Student3
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
