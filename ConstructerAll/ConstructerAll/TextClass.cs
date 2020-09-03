using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerAll
{
    public class TextClass
    {
        public double x, y;
        public double pi = Math.PI;
        public TextClass()
        {

        }
        public TextClass(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual double area()


        {
            return x * y;
        }
    }
    public class Circle1 : TextClass
    {
        public Circle1(double r) : base(r, 0)
        {
        }
        public override double area()
        {
            return pi * x * x;
        }

    }


    class Sphere : TextClass
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double area()
        {
            return 4 * pi * x * x;
        }
    }

    class Cylinder1 : TextClass
    {
        public Cylinder1(double r, double h) : base(r, h)
        {
        }

        public override double area()
        {
            return 2 * pi * x * x + 2 * pi * x * y;
        }
    }

    public class TextrClass2
    {
        static void Main()
        {


            double r =3, h = 5;
            TextClass c = new Circle1(r);
            TextClass s = new Sphere(r);
            TextClass l = new Cylinder1(r, h);
            Console.WriteLine(c.area());
            Console.WriteLine(l.area());
            Console.WriteLine(c.area());
            Console.ReadKey();

        }

    }
}