using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Galaxy
    {
        public string Name { get; set; }
        public int LightYear { get; set; }


    }
    public class Text
    {


        private static void ItrrateThroughList()
        {
            var TheGalaxy = new List<Galaxy>
            {
                new Galaxy(){Name ="subhransu",LightYear =10},
                new Galaxy(){Name ="Hari",LightYear =20},
new Galaxy(){Name ="sankar",LightYear =40},
new Galaxy(){Name ="sekhar",LightYear =9},


            };
            foreach(Galaxy va in TheGalaxy)
            {
                Console.WriteLine(va.Name+ "---" + va.LightYear);
            }
        }
        static void Main()
        {
            ItrrateThroughList();
            Console.ReadKey();
        }
    }
}
