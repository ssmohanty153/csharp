using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Element
    {
        public string symble { get; set; }
            public string name { get; set; }
        public int automaticNUmber { get; set; }


    }
    public class Tes

    {
        private  static void iteratateThroughDire()
        {
            Dictionary<string,Element> elements = BuildDictionary();

            foreach (KeyValuePair<string , Element> i in elements)
            {
                Element ele = i.Value;
                Console.WriteLine("key" + i.Key);
                Console.WriteLine(ele.symble + ""+ele.automaticNUmber+""+ele.name);
            }


        }
        private  static Dictionary<string ,Element> BuildDictionary()
        {
            var elements = new Dictionary<string, Element>();
            addDirectory(elements, "k", "patasium", 19);
            addDirectory(elements, "o", "oxigen", 16);
            addDirectory(elements, "o" ,"heloum", 2);
            addDirectory(elements, "li", "lithum", 4);
            addDirectory(elements, "c", "carbon", 8);
            return elements;
        }
        private static void addDirectory(Dictionary<string, Element> elements, string symble, string name, int automaticNUmber)
        {
            Element ele = new Element();
            ele.automaticNUmber = automaticNUmber;
            ele.symble = symble;
            ele.name = name;
            elements.Add(key: ele.symble, value: ele);

        }
        static void main()
        {
            iteratateThroughDire();
        }


    }



    



}

