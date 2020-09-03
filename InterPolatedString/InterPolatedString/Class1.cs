using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterPolatedString
{
    class Class1
    {
        static void Main(string[] args)
        {
            /*var item=(name:"subhransu",age:24,height:172);
            var date = DateTime.Now;
            Console.WriteLine(item.age);
*/

            /*var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
            var date = DateTime.Now;
            Console.WriteLine($"On {date:d}, the price of {item.Name} was {item.Price:C2} per {item.perPackage} items");*/

            var products = new Dictionary<string, int>()
            {
                ["hammer,ballPen"] = 18,
                ["hammer,jelPen"] = 25,
                ["hammer,nib"] = 10



            };
            Console.WriteLine($"{"item",-25}|{"quantity",10}");
            foreach(var item in products)
            {
                Console.WriteLine($"{item.Key,-25}|{item.Value ,10}");
            }
        
        
        }
    }
}
