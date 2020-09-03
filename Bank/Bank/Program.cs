using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public enum citys
    {
        delhi,mumbia,chennai,kolkatta,bangalore,hydrabad,bhubaneswar
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer(101, "Hare Krishna", "Karnataka", 5000,false,citys.hydrabad,"india" +
                "");
            Console.WriteLine(obj.custid);
            Console.WriteLine(obj.cname);
            //obj.custid = 102;//its gety property only
            obj.cname = "Hare Rama";
            Console.WriteLine(obj.cname);
            obj.balance -= 3000;
            Console.WriteLine(obj.balance);
            obj.status = true;
            obj.cname = "Hare Rama Rama";
            Console.WriteLine(obj.cname);
            obj.balance -= 3000;
            Console.WriteLine(obj.balance);
            obj.city = citys.kolkatta;

            Console.WriteLine(obj.city);
            Console.WriteLine(obj.country);
            Console.ReadLine();
        }
    }
}
