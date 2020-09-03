using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LinqProgram
{
    class Action
    {
        static void Main()
        {
            Action<Student8> printAction=s=>Console .WriteLine("Name:{0}, Age:{1}",s.Name,s.Age);
            Student8 std = new Student8() { Name = "boll", Age = 21 };
            std = new Student8() { Name = "bollii", Age = 201 };

            printAction(std);
            Console.ReadKey();
            

        }
    }
    public class Student8
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
