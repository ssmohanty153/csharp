using System;
using System.Collections.Generic;
using System.Text;

namespace BizRunTime
{
    class EncasulationTest
    {
        private string Studentname;
        private int Studentage;
        public string name
        {
            get                
            {
                return Studentname;
            }
            set
            {
                Studentname = value;

            }
            
        }
        public int age
        {
            get
            {
                return Studentage;
            }
            set
            {
                Studentage = value;
            }
        }
        
    }
    class Test
    {
        static public void Main(string[] arg)
        {
            EncasulationTest et = new EncasulationTest();
            et.age = 15;
            et.name = "subhransu";
            Console.WriteLine(et.name);
            Console.WriteLine(et.age);
            Console.ReadLine();


        }
    }
}
