using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructerAll
{
    abstract class Shape
    {
        public double pi = Math.PI;
        public double x, y;
        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double Area();
    }

    class Circle : Shape
    {
        public Circle(double radius)
            : base(radius, 0)
        {
        }
        public override double Area()
        {
            return pi * x * x;
        }
    }

    class Cylinder : Circle
    {
        public Cylinder(double radius, double height)
            : base(radius)
        {
            y = height;
        }

        public override double Area()
        {
            return (2 * base.Area()) + (2 * pi * x * y);
        }
    }

    class TestShapes
    {
        static void Main()
        {
            double radius = 2.5;
            double height = 3.0;

            Circle ring = new Circle(radius);
            Cylinder tube = new Cylinder(radius, height);

            Console.WriteLine("Area of the circle = "+ ring.Area());
            Console.WriteLine("Area of the cylinder = "+ tube.Area());

            Console.ReadKey();
        }
    }
}

