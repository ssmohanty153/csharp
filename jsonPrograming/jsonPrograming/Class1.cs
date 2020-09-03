using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace jsonPrograming
{
    public class Class1
    {
        public int id { get; set; }

        public string name { get; set; }

        public string addresh { get; set; }

        public string Ename { get; set; }


        public Class1()
            {
            id = 11;
            name = "subhransu";
            addresh = "btm";
            Ename = null;




            }
        internal void OnSerializingMethod(StreamingContext context)
        {
            id = 111;

        }
        internal void OnSerializedMethod(StreamingContext context)
        {
            name = "subhransu mohanty";
           

        }
        internal void OnDeSerializingMethod(StreamingContext context)
        {
           
            addresh = "btm layout";
         

        }
        [OnDeserialized]
        internal void OnDeSerializedMethod(StreamingContext context)
        {
          
            Ename = "subhransu";

        }

        public static  void Main(string[] args)
        {
            Class1 obj = new Class1();

            Console.WriteLine(obj.id);
           
            Console.WriteLine(obj.name);
           
            Console.WriteLine(obj.addresh);
            
            Console.WriteLine(obj.Ename);
           
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            {
                Console.WriteLine("your object is :-{0}",json);
            }

            Console.WriteLine(obj.id);
           
            Console.WriteLine(obj.name);
            
            Console.WriteLine(obj.addresh);
          
            Console.WriteLine(obj.Ename);
           
         Class1   obj1 = JsonConvert.DeserializeObject<Class1>(json);
            Console.WriteLine(obj1);

            Console.WriteLine(obj1.id);
          
            Console.WriteLine(obj1.name);
      
            Console.WriteLine(obj1.addresh);
            Console.WriteLine(obj1.Ename);

            Console.ReadLine();
          }
    }
}
