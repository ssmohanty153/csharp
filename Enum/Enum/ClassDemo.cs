using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    public enum day2
    {
        monday=1,tuesday,wednesday,thursday,friday,saturday,sunday
    }
    class ClassDemo
    {
        static void Main()
        {
            day2 d = day2.thursday;
            Console.WriteLine((int)d);
        }



    }
}
