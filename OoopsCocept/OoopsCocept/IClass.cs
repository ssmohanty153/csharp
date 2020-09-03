using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoopsCocept
{
    interface IClass
    {     
    void Draw();
    }
    public class Rectangle : IClass
    {
        public void Draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : IClass
    {
        public void Draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class TestInterface
    {
        public static void Main()
        {
            IClass d;
            d = new Rectangle();
            d.Draw();
            d = new Circle();
            d.Draw();
        }
    }
}
